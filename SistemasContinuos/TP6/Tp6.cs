using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetodosNumericos;
using MetodosNumericos.MetodosNumericos;

namespace TP6
{
    public partial class Tp6 : Form
    {
        private const int Decimales = 2;

        private readonly CultureInfo _culture;

        private Thread _calcularThread;
        private Thread _optimoThread;

        private delegate void LimpiarDelegate(Chart grafico);
        private delegate void PuntoDelegate(Chart grafico, DataPoint punto, int serie);
        private delegate void ResultadoDelegate(TextBox txt, string resultado);
        private delegate void HabilitarDelegate(Control control, bool habilitar);

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

            btn_detener.Enabled = true;
            
            _calcularThread = new Thread(Calcular)
            {
                CurrentCulture = _culture,
                CurrentUICulture = _culture
            };
            _calcularThread.Start();
        }

        private void Calcular()
        {
            _cancelar = false;

            var limpiarInstancia = new LimpiarDelegate(LimpiarGrafico);
            var puntoInstancia = new PuntoDelegate(AgregarPunto);
            var resultadoInstancia = new ResultadoDelegate(MostrarResultado);
            var habilitarInstancia = new HabilitarDelegate(Habilitar);

            Invoke(limpiarInstancia, graph_y_vs_t);
            Invoke(limpiarInstancia, graph_yPrima_vs_y);

            IFuncion funcion1;
            IFuncion funcion2;
            IFuncion funcion3;

            IMetodoNumerico metodo1;
            IMetodoNumerico metodo2;
            IMetodoNumerico metodo3;

            if (string.IsNullOrEmpty(txt_c1.Text))
            {
                Invoke(resultadoInstancia, txt_tiempo_c1, string.Empty);
                Invoke(resultadoInstancia, txt_paso_c1, string.Empty);
                funcion1 = new FuncionEstable();
            }
            else
            {
                var c1 = decimal.Parse(txt_c1.Text);
                funcion1 = new FuncionTp6(c1);
            }

            if (string.IsNullOrEmpty(txt_c2.Text))
            {
                Invoke(resultadoInstancia, txt_tiempo_c2, string.Empty);
                Invoke(resultadoInstancia, txt_paso_c2, string.Empty);
                funcion2 = new FuncionEstable();
            }
            else
            {
                var c2 = decimal.Parse(txt_c2.Text);
                funcion2 = new FuncionTp6(c2);
            }

            if (string.IsNullOrEmpty(txt_c3.Text))
            {
                Invoke(resultadoInstancia, txt_tiempo_c3, string.Empty);
                Invoke(resultadoInstancia, txt_paso_c3, string.Empty);
                funcion3 = new FuncionEstable();
            }
            else
            {
                var c3 = decimal.Parse(txt_c3.Text);
                funcion3 = new FuncionTp6(c3);
            }

            var y0 = decimal.Parse(txt_y_0.Text);
            var yPrima0 = decimal.Parse(txt_y_prima_0.Text);
            var h = decimal.Parse(txt_h.Text);
            
            decimal t1 = 0;
            decimal t2 = 0;
            decimal t3 = 0;
            var paso = 0;
            var pasos = decimal.Parse(txt_pasos.Text);

            if (rb_euler.Checked)
            {
                metodo1 = new Euler(h, funcion1, y0, yPrima0);
                metodo2 = new Euler(h, funcion2, y0, yPrima0);
                metodo3 = new Euler(h, funcion3, y0, yPrima0);
            }
            else if (rb_euler_mejorado.Checked)
            {
                metodo1 = new EulerMejorado(h, funcion1, y0, yPrima0);
                metodo2 = new EulerMejorado(h, funcion2, y0, yPrima0);
                metodo3 = new EulerMejorado(h, funcion3, y0, yPrima0);
            }
            else
            {
                metodo1 = new RungeKutta(h, funcion1, y0, yPrima0);
                metodo2 = new RungeKutta(h, funcion2, y0, yPrima0);
                metodo3 = new RungeKutta(h, funcion3, y0, yPrima0);
            }

            if (!string.IsNullOrEmpty(txt_c1.Text))
            {
                var puntoY = new DataPoint((double)t1, (double)metodo1.Y());
                var puntoYprima = new DataPoint((double)metodo1.Y(), (double)metodo1.Yprima());

                Invoke(puntoInstancia, graph_y_vs_t, puntoY, 0);
                Invoke(puntoInstancia, graph_yPrima_vs_y, puntoYprima, 0);
            }

            if (!string.IsNullOrEmpty(txt_c2.Text))
            {
                var puntoY = new DataPoint((double)t2, (double)metodo2.Y());
                var puntoYprima = new DataPoint((double)metodo2.Y(), (double)metodo2.Yprima());

                Invoke(puntoInstancia, graph_y_vs_t, puntoY, 1);
                Invoke(puntoInstancia, graph_yPrima_vs_y, puntoYprima, 1);
            }

            if (!string.IsNullOrEmpty(txt_c3.Text))
            {
                var puntoY = new DataPoint((double)t3, (double)metodo3.Y());
                var puntoYprima = new DataPoint((double)metodo3.Y(), (double)metodo3.Yprima());

                Invoke(puntoInstancia, graph_y_vs_t, puntoY, 2);
                Invoke(puntoInstancia, graph_yPrima_vs_y, puntoYprima, 2);
            }

            while (paso <= pasos && 
                (!funcion1.Estable(metodo1.Y(), metodo1.Yprima()) ||
                !funcion2.Estable(metodo2.Y(), metodo2.Yprima()) ||
                !funcion3.Estable(metodo3.Y(), metodo3.Yprima())))
            {
                if (_cancelar)
                    break;

                paso++;

                if (!funcion1.Estable(metodo1.Y(), metodo1.Yprima()))
                {
                    t1 += h;

                    metodo1.CalcularSiguiente();

                    var puntoY = new DataPoint((double)t1, (double)metodo1.Y());
                    var puntoYprima = new DataPoint((double)metodo1.Y(), (double)metodo1.Yprima());

                    Invoke(puntoInstancia, graph_y_vs_t, puntoY, 0);
                    Invoke(puntoInstancia, graph_yPrima_vs_y, puntoYprima, 0);

                    Invoke(resultadoInstancia, txt_paso_c1, paso.ToString());
                }

                if (!funcion2.Estable(metodo2.Y(), metodo2.Yprima()))
                {
                    t2 += h;

                    metodo2.CalcularSiguiente();

                    var puntoY = new DataPoint((double)t2, (double)metodo2.Y());
                    var puntoYprima = new DataPoint((double)metodo2.Y(), (double)metodo2.Yprima());

                    Invoke(puntoInstancia, graph_y_vs_t, puntoY, 1);
                    Invoke(puntoInstancia, graph_yPrima_vs_y, puntoYprima, 1);

                    Invoke(resultadoInstancia, txt_paso_c2, paso.ToString());
                }

                if (!funcion3.Estable(metodo3.Y(), metodo3.Yprima()))
                {
                    t3 += h;

                    metodo3.CalcularSiguiente();

                    var puntoY = new DataPoint((double)t3, (double)metodo3.Y());
                    var puntoYprima = new DataPoint((double)metodo3.Y(), (double)metodo3.Yprima());

                    Invoke(puntoInstancia, graph_y_vs_t, puntoY, 2);
                    Invoke(puntoInstancia, graph_yPrima_vs_y, puntoYprima, 2);

                    Invoke(resultadoInstancia, txt_paso_c3, paso.ToString());
                }
            }

            Invoke(resultadoInstancia, txt_tiempo_c1, decimal.Round(t1, Decimales).ToString());
            Invoke(resultadoInstancia, txt_tiempo_c2, decimal.Round(t2, Decimales).ToString());
            Invoke(resultadoInstancia, txt_tiempo_c3, decimal.Round(t3, Decimales).ToString());

            Invoke(habilitarInstancia, btn_comparar, true);
        }

        private void btn_optimo_Click(object sender, EventArgs e)
        {
            if (!FormularioValidoOptimo())
                return;
            
            btn_detener.Enabled = true;

            _optimoThread = new Thread(ObtenerOptimo)
            {
                CurrentCulture = _culture,
                CurrentUICulture = _culture
            };
            _optimoThread.Start();
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
            var paso = decimal.Parse(txt_paso.Text);

            var valores = new List<decimal>();
            for (var i = min; i < max + paso; i+= paso)
            {
                valores.Add(i);
            }

            DataPoint menor = null;

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

                if (menor == null || menor.YValues[0] > punto.YValues[0])
                    menor = punto;

                Invoke(puntoInstancia, graph_optimo, punto, 0);
            }

            // ReSharper disable once PossibleNullReferenceException
            var tiempoMinimo = decimal.Round((decimal)menor.YValues[0], Decimales);
            var cOptimo = decimal.Round((decimal)menor.XValue, Decimales);

            Invoke(resultadoInstancia, txt_tiempo_optimo, tiempoMinimo.ToString());
            Invoke(resultadoInstancia, txt_c_optimo, cOptimo.ToString());

            var mensaje = $"El valor óptimo de c es {cOptimo} con un tiempo de establecimiento de {tiempoMinimo}";
            const string titulo = "Resultado";

            MessageBox.Show(mensaje, titulo);
        }

        private static void LimpiarGrafico(Chart grafico)
        {
            foreach (var serie in grafico.Series)
            {
                serie.Points.Clear();
            }

            grafico.Visible = true;
        }

        private static void AgregarPunto(Chart grafico, DataPoint punto, int serie)
        {
            grafico.Series[serie].Points.Add(punto);
        }

        private static void MostrarResultado(TextBox txt, string resultado)
        {
            txt.Text = resultado;
        }

        private static void Habilitar(Control control, bool habilitar)
        {
            control.Enabled = habilitar;
        }

        private void btn_comparar_Click(object sender, EventArgs e)
        {
            var constantes = new List<DataPoint>();

            if (!string.IsNullOrEmpty(txt_c1.Text))
            {
                var c1 = new DataPoint(double.Parse(txt_c1.Text), double.Parse(txt_tiempo_c1.Text));
                constantes.Add(c1);
            }

            if (!string.IsNullOrEmpty(txt_c2.Text))
            {
                var c2 = new DataPoint(double.Parse(txt_c2.Text), double.Parse(txt_tiempo_c2.Text));
                constantes.Add(c2);
            }

            if (!string.IsNullOrEmpty(txt_c3.Text))
            {
                var c3 = new DataPoint(double.Parse(txt_c3.Text), double.Parse(txt_tiempo_c3.Text));
                constantes.Add(c3);
            }

            var t = constantes.Min(cons => cons.YValues[0]);
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            var c = constantes.First(cons => cons.YValues[0] == t).XValue;

            var mensaje = $"El mejor tiempo es {t}, con c = {c}";
            const string titulo = "Resultado";

            MessageBox.Show(mensaje, titulo);
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
            const string mensaje = "Debe ingresar al menos una constante";

            if (string.IsNullOrEmpty(txt_c1.Text) &&
                string.IsNullOrEmpty(txt_c2.Text) &&
                string.IsNullOrEmpty(txt_c3.Text))
            {
                MensajeError(mensaje, txt_c1);
                return false;
            }

            if (!ValidarConstante("c1", txt_c1))
                return false;

            if (!ValidarConstante("c2", txt_c2))
                return false;

            if (!ValidarConstante("c3", txt_c3))
                return false;

            return true;
        }

        private static bool ValidarConstante(string constante, Control txt)
        {
            var mensaje = $"el valor de {constante} debe estar entre 0.1 y 10";
            double c;

            if (!string.IsNullOrEmpty(txt.Text) &&
                (!double.TryParse(txt.Text, out c)
                || c < 0.1 || c > 10))
            {
                MensajeError(mensaje, txt);
                return false;
            }

            return true;
        }

        private bool ValidarCondicionesIniciales()
        {
            var mensaje = "Ingrese un número válido para y(0)";
            double y0;

            if (!double.TryParse(txt_y_0.Text, out y0))
            {
                MensajeError(mensaje, txt_y_0);
                return false;
            }

            mensaje = "Ingrese un número válido para y'(0)";
            double yPrima0;

            if (!double.TryParse(txt_y_prima_0.Text, out yPrima0))
            {
                MensajeError(mensaje, txt_y_prima_0);
                return false;
            }

            mensaje = "El valor de h debe estar entre 0.0001 y 1";
            double h;

            if (!double.TryParse(txt_h.Text, out h) || h < 0.0001 || h > 1)
            {
                MensajeError(mensaje, txt_h);
                return false;
            }

            return true;
        }

        private bool ValidarIntervalo()
        {
            var mensaje = "Ingrese un número válido para el mínimo";
            double min;

            if (!double.TryParse(txt_min.Text, out min))
            {
                MensajeError(mensaje, txt_min);
                return false;
            }

            mensaje = "Ingrese un número válido para el máximo";
            double max;

            if (!double.TryParse(txt_max.Text, out max))
            {
                MensajeError(mensaje, txt_max);
                return false;
            }

            mensaje = "El máximo debe ser mayor que el mínimo";

            if (max <= min)
            {
                MensajeError(mensaje, txt_max);
                return false;
            }

            mensaje = "El valor del paso debe ser positivo y menor que el máximo";
            double paso;

            if (!double.TryParse(txt_paso.Text, out paso) || paso >= max)
            {
                MensajeError(mensaje, txt_paso);
                return false;
            }

            return true;
        }

        private static void MensajeError(string mensaje, Control textBox)
        {
            const string titulo = "Error";
            MessageBox.Show(mensaje, titulo);
            textBox.Focus();
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            _cancelar = true;
        }

        private void Tp6_FormClosing(object sender, CancelEventArgs e)
        {
            if (Activo(_calcularThread) || Activo(_optimoThread))
            {
                _cancelar = true;
                e.Cancel = true;
            }
        }

        private static bool Activo(Thread thread)
        {
            if (thread == null
                || thread.ThreadState.Equals(ThreadState.Unstarted)
                || thread.ThreadState.Equals(ThreadState.Stopped))
                return false;

            return true;
        }

        private void lk_euler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string mensaje = "y(n+1)= y(n) + h*f(x(n), y(n))";
            const string titulo = "Euler";

            MessageBox.Show(mensaje, titulo);
        }

        private void lk_euler_mejorado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sb = new StringBuilder();
            sb.Append("y(n+1)= y(n) + h*(k1 + k2)/2");
            sb.AppendLine();
            sb.Append("k1 = f(x(n), y(n))");
            sb.AppendLine();
            sb.Append("k2 = f(x(n+h), y(n) + h*k1");

            var mensaje = sb.ToString();
            const string titulo = "Euler Mejorado";

            MessageBox.Show(mensaje, titulo);
        }

        private void lbl_runge_kutta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sb = new StringBuilder();
            sb.Append("y(n+1)= y(n) + h*(k1 + 2*k2 + 2*k3 + k4)/6");
            sb.AppendLine();
            sb.Append("k1 = f(x(n), y(n))");
            sb.AppendLine();
            sb.Append("k2 = f(x(n+h/2), y(n) + h/2*k1");
            sb.AppendLine();
            sb.Append("k3 = f(x(n+h/2), y(n) + h/2*k2");
            sb.AppendLine();
            sb.Append("k4 = f(x(n+h), y(n) + h*k3");

            var mensaje = sb.ToString();
            const string titulo = "Runge Kutta";

            MessageBox.Show(mensaje, titulo);
        }
    }
}
