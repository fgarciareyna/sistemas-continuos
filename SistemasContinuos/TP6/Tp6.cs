using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

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

        private delegate void PuntoDelegate(Point punto);

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

        private bool Estable(double y, double yPrima)
        {
            return Math.Abs(y) < 0.005 && Math.Abs(yPrima) < 0.01;
        }

        private void btn_optimo_Click(object sender, EventArgs e)
        {
            if (!FormularioValidoOptimo())
                return;

            _cancelar = false;
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
