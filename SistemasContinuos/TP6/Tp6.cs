using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetodosNumericos.MetodosNumericos;

namespace TP6
{
    public partial class Tp6 : Form
    {
        private const int Decimales = 2;

        private readonly CultureInfo _culture;

        private Thread _calcularC1Thread;
        private Thread _calcularC2Thread;
        private Thread _calcularC3Thread;
        private Thread _calcularOptimoThread;

        private delegate void LimpiarDelegate(Chart grafico);
        private delegate void PuntoDelegate(Chart grafico, DataPoint punto);
        private delegate void ResultadoDelegate(TextBox txt, decimal resultado);

        private bool _cancelar;

        public Tp6()
        {
            _culture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentCulture = _culture;
            Thread.CurrentThread.CurrentUICulture = _culture;

            InitializeComponent();
        }

        private void rb_euler_CheckedChanged(object sender, EventArgs e)
        {
            btn_calcular.Enabled = true;
            btn_optimo.Enabled = true;
        }

        private void rb_euler_mejorado_CheckedChanged(object sender, EventArgs e)
        {
            btn_calcular.Enabled = true;
            btn_optimo.Enabled = true;
        }

        private void rb_runge_kutta_CheckedChanged(object sender, EventArgs e)
        {
            btn_calcular.Enabled = true;
            btn_optimo.Enabled = true;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (!FormularioValidoCalcular())
                return;

            _cancelar = false;
        }

        private void Calcular()
        {
            
        }

        private void btn_optimo_Click(object sender, EventArgs e)
        {
            if (!FormularioValidoOptimo())
                return;

            _calcularOptimoThread = new Thread(ObtenerOptimo)
            {
                CurrentCulture = _culture,
                CurrentUICulture = _culture,
            };

            _calcularOptimoThread.Start();
        }

        private void ObtenerOptimo()
        {
            _cancelar = false;

            var limpiarInstancia = new LimpiarDelegate(LimpiarGrafico);
            var puntoInstancia = new PuntoDelegate(AgregarPunto);
            var resultadoInstancia = new ResultadoDelegate(MostrarResultado);

            Invoke(limpiarInstancia, graph_optimo);

            var y0 = decimal.Parse(txt_y_0.Text);
            var yPrima0 = decimal.Parse(txt_y_prima_0.Text);
            var h = decimal.Parse(txt_h.Text);

            var min = decimal.Parse(txt_min.Text);
            var max = decimal.Parse(txt_max.Text);
            var paso = (max - min) / 100;

            var valores = new List<decimal>();
            for (var i = min; i < max + paso; i+= paso)
            {
                valores.Add(i);
            }

            var puntos = new List<DataPoint>();

            foreach (var c in valores)
            {
                if (_cancelar)
                    break;

                decimal t = 0;

                var funcion = new FuncionTp6(c);

                IMetodoNumerico metodo;

                if (rb_euler.Checked)
                    metodo = new Euler(h, funcion, y0, yPrima0);
                else if (rb_euler_mejorado.Checked)
                    metodo = new EulerMejorado(h, funcion, y0, yPrima0);
                else
                    metodo = new RungeKutta(h, funcion, y0, yPrima0);

                while (!funcion.Estable(metodo.Y(), metodo.Yprima()))
                {
                    if (_cancelar)
                        break;

                    t += h;
                    metodo.CalcularSiguiente();
                }

                var punto = new DataPoint((double) c, (double) t);

                puntos.Add(punto);

                Invoke(puntoInstancia, graph_optimo, punto);
            }

            var tiempoMinimo = puntos.Min(p => p.YValues[0]);
            var cOptimo = puntos.Single(p => Math.Abs(p.YValues[0] - tiempoMinimo) < (double)h).XValue;

            var tMinRound = decimal.Round((decimal)tiempoMinimo, Decimales);
            var cOptRound = decimal.Round((decimal)cOptimo, Decimales);

            Invoke(resultadoInstancia, txt_c_optimo, cOptRound);
            Invoke(resultadoInstancia, txt_tiempo_optimo, tMinRound);

            MessageBox.Show(
                $@"El valor óptimo de c es {cOptRound} con un tiempo de establecimiento de {tMinRound}",
                @"Resultado");
        }

        private void LimpiarGrafico(Chart grafico)
        {
            grafico.Series[0].Points.Clear();
            grafico.Visible = true;
        }

        private void AgregarPunto(Chart grafico, DataPoint punto)
        {
            grafico.Series[0].Points.Add(punto);
        }

        private void MostrarResultado(TextBox txt, decimal resultado)
        {
            txt.Text = resultado.ToString();
        }

        private bool FormularioValidoCalcular()
        {
            if (!ValidarConstantes())
                return false;

            if (!ValidarCondicionesIniciales())
                return false;

            return true;
        }

        private bool FormularioValidoOptimo()
        {
            if (!ValidarCondicionesIniciales())
                return false;

            if (!ValidarIntervalo())
                return false;

            return true;
        }

        private bool ValidarConstantes()
        {
            var mensaje = @"Debe ingresar al menos una constante";

            if (string.IsNullOrEmpty(txt_c1.Text) &&
                string.IsNullOrEmpty(txt_c2.Text) &&
                string.IsNullOrEmpty(txt_c3.Text))
            {
                MensajeError(mensaje, txt_c1);
                return false;
            }

            mensaje = @"Ingrese un número válido para c1";
            double c1;

            if (!string.IsNullOrEmpty(txt_c1.Text) &&
                !double.TryParse(txt_c1.Text, out c1))
            {
                MensajeError(mensaje, txt_c1);
                return false;
            }

            mensaje = @"Ingrese un número válido para c2";
            double c2;

            if (!string.IsNullOrEmpty(txt_c2.Text) &&
                !double.TryParse(txt_c2.Text, out c2))
            {
                MensajeError(mensaje, txt_c2);
                return false;
            }

            mensaje = @"Ingrese un número válido para c3";
            double c3;

            if (!string.IsNullOrEmpty(txt_c3.Text) &&
                !double.TryParse(txt_c3.Text, out c3))
            {
                MensajeError(mensaje, txt_c3);
                return false;
            }

            return true;
        }

        private bool ValidarCondicionesIniciales()
        {
            var mensaje = @"Ingrese un número válido para y(0)";
            double y0;

            if (!double.TryParse(txt_y_0.Text, out y0))
            {
                MensajeError(mensaje, txt_y_0);
                return false;
            }

            mensaje = @"Ingrese un número válido para y'(0)";
            double yPrima0;

            if (!double.TryParse(txt_y_prima_0.Text, out yPrima0))
            {
                MensajeError(mensaje, txt_y_prima_0);
                return false;
            }

            return true;
        }

        private bool ValidarIntervalo()
        {
            var mensaje = @"Ingrese un número válido para el mínimo";
            double min;

            if (!double.TryParse(txt_min.Text, out min))
            {
                MensajeError(mensaje, txt_min);
                return false;
            }

            mensaje = @"Ingrese un número válido para el máximo";
            double max;

            if (!double.TryParse(txt_max.Text, out max))
            {
                MensajeError(mensaje, txt_max);
                return false;
            }

            mensaje = @"El máximo debe ser mayor que el mínimo";

            if (max <= min)
            {
                MensajeError(mensaje, txt_max);
                return false;
            }

            return true;
        }

        private static void MensajeError(string mensaje, Control textBox)
        {
            MessageBox.Show(mensaje, @"Error");
            textBox.Focus();
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            _cancelar = true;
        }
    }
}
