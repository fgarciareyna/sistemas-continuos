namespace TP6
{
    partial class Tp6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gb_metodos = new System.Windows.Forms.GroupBox();
            this.lbl_runge_kutta = new System.Windows.Forms.LinkLabel();
            this.lk_euler_mejorado = new System.Windows.Forms.LinkLabel();
            this.lk_euler = new System.Windows.Forms.LinkLabel();
            this.rb_runge_kutta = new System.Windows.Forms.RadioButton();
            this.rb_euler_mejorado = new System.Windows.Forms.RadioButton();
            this.rb_euler = new System.Windows.Forms.RadioButton();
            this.gb_constantes = new System.Windows.Forms.GroupBox();
            this.txt_c3 = new System.Windows.Forms.TextBox();
            this.txt_c2 = new System.Windows.Forms.TextBox();
            this.txt_c1 = new System.Windows.Forms.TextBox();
            this.lbl_c3 = new System.Windows.Forms.Label();
            this.lbl_c2 = new System.Windows.Forms.Label();
            this.lbl_c1 = new System.Windows.Forms.Label();
            this.gb_condiciones_iniciales = new System.Windows.Forms.GroupBox();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.lbl_h = new System.Windows.Forms.Label();
            this.txt_y_prima_0 = new System.Windows.Forms.TextBox();
            this.txt_y_0 = new System.Windows.Forms.TextBox();
            this.lbl_y_prima_0 = new System.Windows.Forms.Label();
            this.lbl_y_0 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.gb_intervalo = new System.Windows.Forms.GroupBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.lbl_max = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.btn_optimo = new System.Windows.Forms.Button();
            this.btn_detener = new System.Windows.Forms.Button();
            this.gb_resultados = new System.Windows.Forms.GroupBox();
            this.btn_comparar = new System.Windows.Forms.Button();
            this.txt_c_optimo = new System.Windows.Forms.TextBox();
            this.txt_tiempo_optimo = new System.Windows.Forms.TextBox();
            this.lbl_tiempo_optimo = new System.Windows.Forms.Label();
            this.lbl_c_optimo = new System.Windows.Forms.Label();
            this.txt_tiempo_c1 = new System.Windows.Forms.TextBox();
            this.txt_tiempo_c2 = new System.Windows.Forms.TextBox();
            this.txt_tiempo_c3 = new System.Windows.Forms.TextBox();
            this.lbl_tiempo_c3 = new System.Windows.Forms.Label();
            this.lbl_tiempo_c2 = new System.Windows.Forms.Label();
            this.lbl_tiempo_c1 = new System.Windows.Forms.Label();
            this.graph_optimo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graph_y_vs_t = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graph_yPrima_vs_y = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gb_metodos.SuspendLayout();
            this.gb_constantes.SuspendLayout();
            this.gb_condiciones_iniciales.SuspendLayout();
            this.gb_intervalo.SuspendLayout();
            this.gb_resultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_optimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_y_vs_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_yPrima_vs_y)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_metodos
            // 
            this.gb_metodos.Controls.Add(this.lbl_runge_kutta);
            this.gb_metodos.Controls.Add(this.lk_euler_mejorado);
            this.gb_metodos.Controls.Add(this.lk_euler);
            this.gb_metodos.Controls.Add(this.rb_runge_kutta);
            this.gb_metodos.Controls.Add(this.rb_euler_mejorado);
            this.gb_metodos.Controls.Add(this.rb_euler);
            this.gb_metodos.Location = new System.Drawing.Point(12, 118);
            this.gb_metodos.Name = "gb_metodos";
            this.gb_metodos.Size = new System.Drawing.Size(128, 78);
            this.gb_metodos.TabIndex = 0;
            this.gb_metodos.TabStop = false;
            this.gb_metodos.Text = "Métodos numéricos:";
            // 
            // lbl_runge_kutta
            // 
            this.lbl_runge_kutta.AutoSize = true;
            this.lbl_runge_kutta.Location = new System.Drawing.Point(26, 57);
            this.lbl_runge_kutta.Name = "lbl_runge_kutta";
            this.lbl_runge_kutta.Size = new System.Drawing.Size(67, 13);
            this.lbl_runge_kutta.TabIndex = 5;
            this.lbl_runge_kutta.TabStop = true;
            this.lbl_runge_kutta.Text = "Runge-Kutta";
            // 
            // lk_euler_mejorado
            // 
            this.lk_euler_mejorado.AutoSize = true;
            this.lk_euler_mejorado.Location = new System.Drawing.Point(26, 38);
            this.lk_euler_mejorado.Name = "lk_euler_mejorado";
            this.lk_euler_mejorado.Size = new System.Drawing.Size(77, 13);
            this.lk_euler_mejorado.TabIndex = 4;
            this.lk_euler_mejorado.TabStop = true;
            this.lk_euler_mejorado.Text = "Euler mejorado";
            // 
            // lk_euler
            // 
            this.lk_euler.AutoSize = true;
            this.lk_euler.Location = new System.Drawing.Point(26, 19);
            this.lk_euler.Name = "lk_euler";
            this.lk_euler.Size = new System.Drawing.Size(31, 13);
            this.lk_euler.TabIndex = 3;
            this.lk_euler.TabStop = true;
            this.lk_euler.Text = "Euler";
            // 
            // rb_runge_kutta
            // 
            this.rb_runge_kutta.AutoSize = true;
            this.rb_runge_kutta.Location = new System.Drawing.Point(6, 57);
            this.rb_runge_kutta.Name = "rb_runge_kutta";
            this.rb_runge_kutta.Size = new System.Drawing.Size(14, 13);
            this.rb_runge_kutta.TabIndex = 2;
            this.rb_runge_kutta.TabStop = true;
            this.rb_runge_kutta.UseVisualStyleBackColor = true;
            this.rb_runge_kutta.CheckedChanged += new System.EventHandler(this.rb_runge_kutta_CheckedChanged);
            // 
            // rb_euler_mejorado
            // 
            this.rb_euler_mejorado.AutoSize = true;
            this.rb_euler_mejorado.Location = new System.Drawing.Point(6, 38);
            this.rb_euler_mejorado.Name = "rb_euler_mejorado";
            this.rb_euler_mejorado.Size = new System.Drawing.Size(14, 13);
            this.rb_euler_mejorado.TabIndex = 1;
            this.rb_euler_mejorado.TabStop = true;
            this.rb_euler_mejorado.UseVisualStyleBackColor = true;
            this.rb_euler_mejorado.CheckedChanged += new System.EventHandler(this.rb_euler_mejorado_CheckedChanged);
            // 
            // rb_euler
            // 
            this.rb_euler.AutoSize = true;
            this.rb_euler.Location = new System.Drawing.Point(6, 19);
            this.rb_euler.Name = "rb_euler";
            this.rb_euler.Size = new System.Drawing.Size(14, 13);
            this.rb_euler.TabIndex = 0;
            this.rb_euler.TabStop = true;
            this.rb_euler.UseVisualStyleBackColor = true;
            this.rb_euler.CheckedChanged += new System.EventHandler(this.rb_euler_CheckedChanged);
            // 
            // gb_constantes
            // 
            this.gb_constantes.Controls.Add(this.txt_c3);
            this.gb_constantes.Controls.Add(this.txt_c2);
            this.gb_constantes.Controls.Add(this.txt_c1);
            this.gb_constantes.Controls.Add(this.lbl_c3);
            this.gb_constantes.Controls.Add(this.lbl_c2);
            this.gb_constantes.Controls.Add(this.lbl_c1);
            this.gb_constantes.Location = new System.Drawing.Point(12, 12);
            this.gb_constantes.Name = "gb_constantes";
            this.gb_constantes.Size = new System.Drawing.Size(128, 100);
            this.gb_constantes.TabIndex = 1;
            this.gb_constantes.TabStop = false;
            this.gb_constantes.Text = "Constantes:";
            // 
            // txt_c3
            // 
            this.txt_c3.Location = new System.Drawing.Point(35, 71);
            this.txt_c3.Name = "txt_c3";
            this.txt_c3.Size = new System.Drawing.Size(68, 20);
            this.txt_c3.TabIndex = 5;
            // 
            // txt_c2
            // 
            this.txt_c2.Location = new System.Drawing.Point(35, 45);
            this.txt_c2.Name = "txt_c2";
            this.txt_c2.Size = new System.Drawing.Size(68, 20);
            this.txt_c2.TabIndex = 4;
            // 
            // txt_c1
            // 
            this.txt_c1.Location = new System.Drawing.Point(35, 19);
            this.txt_c1.Name = "txt_c1";
            this.txt_c1.Size = new System.Drawing.Size(68, 20);
            this.txt_c1.TabIndex = 3;
            // 
            // lbl_c3
            // 
            this.lbl_c3.AutoSize = true;
            this.lbl_c3.Location = new System.Drawing.Point(6, 74);
            this.lbl_c3.Name = "lbl_c3";
            this.lbl_c3.Size = new System.Drawing.Size(22, 13);
            this.lbl_c3.TabIndex = 2;
            this.lbl_c3.Text = "c3:";
            // 
            // lbl_c2
            // 
            this.lbl_c2.AutoSize = true;
            this.lbl_c2.Location = new System.Drawing.Point(6, 48);
            this.lbl_c2.Name = "lbl_c2";
            this.lbl_c2.Size = new System.Drawing.Size(22, 13);
            this.lbl_c2.TabIndex = 1;
            this.lbl_c2.Text = "c2:";
            // 
            // lbl_c1
            // 
            this.lbl_c1.AutoSize = true;
            this.lbl_c1.Location = new System.Drawing.Point(6, 22);
            this.lbl_c1.Name = "lbl_c1";
            this.lbl_c1.Size = new System.Drawing.Size(22, 13);
            this.lbl_c1.TabIndex = 0;
            this.lbl_c1.Text = "c1:";
            // 
            // gb_condiciones_iniciales
            // 
            this.gb_condiciones_iniciales.Controls.Add(this.txt_h);
            this.gb_condiciones_iniciales.Controls.Add(this.lbl_h);
            this.gb_condiciones_iniciales.Controls.Add(this.txt_y_prima_0);
            this.gb_condiciones_iniciales.Controls.Add(this.txt_y_0);
            this.gb_condiciones_iniciales.Controls.Add(this.lbl_y_prima_0);
            this.gb_condiciones_iniciales.Controls.Add(this.lbl_y_0);
            this.gb_condiciones_iniciales.Location = new System.Drawing.Point(12, 202);
            this.gb_condiciones_iniciales.Name = "gb_condiciones_iniciales";
            this.gb_condiciones_iniciales.Size = new System.Drawing.Size(128, 100);
            this.gb_condiciones_iniciales.TabIndex = 2;
            this.gb_condiciones_iniciales.TabStop = false;
            this.gb_condiciones_iniciales.Text = "Condiciones iniciales:";
            // 
            // txt_h
            // 
            this.txt_h.Location = new System.Drawing.Point(39, 71);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(64, 20);
            this.txt_h.TabIndex = 6;
            this.txt_h.Text = "0.01";
            // 
            // lbl_h
            // 
            this.lbl_h.AutoSize = true;
            this.lbl_h.Location = new System.Drawing.Point(6, 74);
            this.lbl_h.Name = "lbl_h";
            this.lbl_h.Size = new System.Drawing.Size(16, 13);
            this.lbl_h.TabIndex = 5;
            this.lbl_h.Text = "h:";
            // 
            // txt_y_prima_0
            // 
            this.txt_y_prima_0.Location = new System.Drawing.Point(39, 45);
            this.txt_y_prima_0.Name = "txt_y_prima_0";
            this.txt_y_prima_0.Size = new System.Drawing.Size(64, 20);
            this.txt_y_prima_0.TabIndex = 4;
            this.txt_y_prima_0.Text = "-2.5";
            // 
            // txt_y_0
            // 
            this.txt_y_0.Location = new System.Drawing.Point(39, 19);
            this.txt_y_0.Name = "txt_y_0";
            this.txt_y_0.Size = new System.Drawing.Size(64, 20);
            this.txt_y_0.TabIndex = 3;
            this.txt_y_0.Text = "0";
            // 
            // lbl_y_prima_0
            // 
            this.lbl_y_prima_0.AutoSize = true;
            this.lbl_y_prima_0.Location = new System.Drawing.Point(6, 48);
            this.lbl_y_prima_0.Name = "lbl_y_prima_0";
            this.lbl_y_prima_0.Size = new System.Drawing.Size(29, 13);
            this.lbl_y_prima_0.TabIndex = 2;
            this.lbl_y_prima_0.Text = "y\'(0):";
            // 
            // lbl_y_0
            // 
            this.lbl_y_0.AutoSize = true;
            this.lbl_y_0.Location = new System.Drawing.Point(6, 22);
            this.lbl_y_0.Name = "lbl_y_0";
            this.lbl_y_0.Size = new System.Drawing.Size(27, 13);
            this.lbl_y_0.TabIndex = 1;
            this.lbl_y_0.Text = "y(0):";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Enabled = false;
            this.btn_calcular.Location = new System.Drawing.Point(146, 24);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(97, 23);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // gb_intervalo
            // 
            this.gb_intervalo.Controls.Add(this.txt_max);
            this.gb_intervalo.Controls.Add(this.txt_min);
            this.gb_intervalo.Controls.Add(this.lbl_max);
            this.gb_intervalo.Controls.Add(this.lbl_min);
            this.gb_intervalo.Location = new System.Drawing.Point(12, 308);
            this.gb_intervalo.Name = "gb_intervalo";
            this.gb_intervalo.Size = new System.Drawing.Size(128, 75);
            this.gb_intervalo.TabIndex = 5;
            this.gb_intervalo.TabStop = false;
            this.gb_intervalo.Text = "Intervalo:";
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(39, 45);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(64, 20);
            this.txt_max.TabIndex = 4;
            this.txt_max.Text = "10";
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(39, 19);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(64, 20);
            this.txt_min.TabIndex = 3;
            this.txt_min.Text = "0,1";
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Location = new System.Drawing.Point(6, 48);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(30, 13);
            this.lbl_max.TabIndex = 2;
            this.lbl_max.Text = "Máx:";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(6, 22);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(29, 13);
            this.lbl_min.TabIndex = 1;
            this.lbl_min.Text = "Mín:";
            // 
            // btn_optimo
            // 
            this.btn_optimo.Enabled = false;
            this.btn_optimo.Location = new System.Drawing.Point(146, 55);
            this.btn_optimo.Name = "btn_optimo";
            this.btn_optimo.Size = new System.Drawing.Size(97, 23);
            this.btn_optimo.TabIndex = 6;
            this.btn_optimo.Text = "Óptimo";
            this.btn_optimo.UseVisualStyleBackColor = true;
            this.btn_optimo.Click += new System.EventHandler(this.btn_optimo_Click);
            // 
            // btn_detener
            // 
            this.btn_detener.Enabled = false;
            this.btn_detener.Location = new System.Drawing.Point(146, 84);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(97, 23);
            this.btn_detener.TabIndex = 7;
            this.btn_detener.Text = "Detener";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // gb_resultados
            // 
            this.gb_resultados.Controls.Add(this.btn_comparar);
            this.gb_resultados.Controls.Add(this.txt_c_optimo);
            this.gb_resultados.Controls.Add(this.txt_tiempo_optimo);
            this.gb_resultados.Controls.Add(this.lbl_tiempo_optimo);
            this.gb_resultados.Controls.Add(this.lbl_c_optimo);
            this.gb_resultados.Controls.Add(this.txt_tiempo_c1);
            this.gb_resultados.Controls.Add(this.txt_tiempo_c2);
            this.gb_resultados.Controls.Add(this.txt_tiempo_c3);
            this.gb_resultados.Controls.Add(this.lbl_tiempo_c3);
            this.gb_resultados.Controls.Add(this.lbl_tiempo_c2);
            this.gb_resultados.Controls.Add(this.lbl_tiempo_c1);
            this.gb_resultados.Location = new System.Drawing.Point(249, 12);
            this.gb_resultados.Name = "gb_resultados";
            this.gb_resultados.Size = new System.Drawing.Size(311, 100);
            this.gb_resultados.TabIndex = 6;
            this.gb_resultados.TabStop = false;
            this.gb_resultados.Text = "Resultados:";
            // 
            // btn_comparar
            // 
            this.btn_comparar.Enabled = false;
            this.btn_comparar.Location = new System.Drawing.Point(149, 69);
            this.btn_comparar.Name = "btn_comparar";
            this.btn_comparar.Size = new System.Drawing.Size(150, 23);
            this.btn_comparar.TabIndex = 8;
            this.btn_comparar.Text = "Comparar";
            this.btn_comparar.UseVisualStyleBackColor = true;
            // 
            // txt_c_optimo
            // 
            this.txt_c_optimo.Location = new System.Drawing.Point(231, 19);
            this.txt_c_optimo.Name = "txt_c_optimo";
            this.txt_c_optimo.ReadOnly = true;
            this.txt_c_optimo.Size = new System.Drawing.Size(68, 20);
            this.txt_c_optimo.TabIndex = 9;
            // 
            // txt_tiempo_optimo
            // 
            this.txt_tiempo_optimo.Location = new System.Drawing.Point(231, 45);
            this.txt_tiempo_optimo.Name = "txt_tiempo_optimo";
            this.txt_tiempo_optimo.ReadOnly = true;
            this.txt_tiempo_optimo.Size = new System.Drawing.Size(68, 20);
            this.txt_tiempo_optimo.TabIndex = 8;
            // 
            // lbl_tiempo_optimo
            // 
            this.lbl_tiempo_optimo.AutoSize = true;
            this.lbl_tiempo_optimo.Location = new System.Drawing.Point(146, 48);
            this.lbl_tiempo_optimo.Name = "lbl_tiempo_optimo";
            this.lbl_tiempo_optimo.Size = new System.Drawing.Size(79, 13);
            this.lbl_tiempo_optimo.TabIndex = 7;
            this.lbl_tiempo_optimo.Text = "Tiempo óptimo:";
            // 
            // lbl_c_optimo
            // 
            this.lbl_c_optimo.AutoSize = true;
            this.lbl_c_optimo.Location = new System.Drawing.Point(146, 22);
            this.lbl_c_optimo.Name = "lbl_c_optimo";
            this.lbl_c_optimo.Size = new System.Drawing.Size(68, 13);
            this.lbl_c_optimo.TabIndex = 6;
            this.lbl_c_optimo.Text = "Valor óptimo:";
            // 
            // txt_tiempo_c1
            // 
            this.txt_tiempo_c1.Location = new System.Drawing.Point(72, 19);
            this.txt_tiempo_c1.Name = "txt_tiempo_c1";
            this.txt_tiempo_c1.ReadOnly = true;
            this.txt_tiempo_c1.Size = new System.Drawing.Size(68, 20);
            this.txt_tiempo_c1.TabIndex = 5;
            // 
            // txt_tiempo_c2
            // 
            this.txt_tiempo_c2.Location = new System.Drawing.Point(72, 45);
            this.txt_tiempo_c2.Name = "txt_tiempo_c2";
            this.txt_tiempo_c2.ReadOnly = true;
            this.txt_tiempo_c2.Size = new System.Drawing.Size(68, 20);
            this.txt_tiempo_c2.TabIndex = 4;
            // 
            // txt_tiempo_c3
            // 
            this.txt_tiempo_c3.Location = new System.Drawing.Point(72, 71);
            this.txt_tiempo_c3.Name = "txt_tiempo_c3";
            this.txt_tiempo_c3.ReadOnly = true;
            this.txt_tiempo_c3.Size = new System.Drawing.Size(68, 20);
            this.txt_tiempo_c3.TabIndex = 3;
            // 
            // lbl_tiempo_c3
            // 
            this.lbl_tiempo_c3.AutoSize = true;
            this.lbl_tiempo_c3.Location = new System.Drawing.Point(6, 74);
            this.lbl_tiempo_c3.Name = "lbl_tiempo_c3";
            this.lbl_tiempo_c3.Size = new System.Drawing.Size(60, 13);
            this.lbl_tiempo_c3.TabIndex = 2;
            this.lbl_tiempo_c3.Text = "Tiempo c3:";
            // 
            // lbl_tiempo_c2
            // 
            this.lbl_tiempo_c2.AutoSize = true;
            this.lbl_tiempo_c2.Location = new System.Drawing.Point(6, 48);
            this.lbl_tiempo_c2.Name = "lbl_tiempo_c2";
            this.lbl_tiempo_c2.Size = new System.Drawing.Size(60, 13);
            this.lbl_tiempo_c2.TabIndex = 1;
            this.lbl_tiempo_c2.Text = "Tiempo c2:";
            // 
            // lbl_tiempo_c1
            // 
            this.lbl_tiempo_c1.AutoSize = true;
            this.lbl_tiempo_c1.Location = new System.Drawing.Point(6, 22);
            this.lbl_tiempo_c1.Name = "lbl_tiempo_c1";
            this.lbl_tiempo_c1.Size = new System.Drawing.Size(60, 13);
            this.lbl_tiempo_c1.TabIndex = 0;
            this.lbl_tiempo_c1.Text = "Tiempo c1:";
            // 
            // graph_optimo
            // 
            this.graph_optimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graph_optimo.CausesValidation = false;
            chartArea1.AxisX.Title = "Valor de c";
            chartArea1.AxisY.Title = "Tiempo de establecimiento (s)";
            chartArea1.Name = "optimo";
            this.graph_optimo.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.graph_optimo.Legends.Add(legend1);
            this.graph_optimo.Location = new System.Drawing.Point(146, 118);
            this.graph_optimo.Name = "graph_optimo";
            series1.ChartArea = "optimo";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Cálculo del óptimo";
            this.graph_optimo.Series.Add(series1);
            this.graph_optimo.Size = new System.Drawing.Size(1118, 265);
            this.graph_optimo.TabIndex = 8;
            title1.Name = "Title1";
            title1.Text = "Búsqueda del c óptimo";
            this.graph_optimo.Titles.Add(title1);
            this.graph_optimo.Visible = false;
            // 
            // graph_y_vs_t
            // 
            this.graph_y_vs_t.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graph_y_vs_t.CausesValidation = false;
            chartArea2.AxisX.Title = "Tiempo (s)";
            chartArea2.AxisY.Title = "Tita(t)";
            chartArea2.Name = "optimo";
            this.graph_y_vs_t.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend";
            this.graph_y_vs_t.Legends.Add(legend2);
            this.graph_y_vs_t.Location = new System.Drawing.Point(12, 389);
            this.graph_y_vs_t.Name = "graph_y_vs_t";
            series2.ChartArea = "optimo";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Legend = "Legend";
            series2.LegendText = "c1";
            series2.Name = "c1";
            series3.ChartArea = "optimo";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series3.Legend = "Legend";
            series3.LegendText = "c2";
            series3.Name = "c2";
            series4.ChartArea = "optimo";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series4.Legend = "Legend";
            series4.LegendText = "c3";
            series4.Name = "c3";
            this.graph_y_vs_t.Series.Add(series2);
            this.graph_y_vs_t.Series.Add(series3);
            this.graph_y_vs_t.Series.Add(series4);
            this.graph_y_vs_t.Size = new System.Drawing.Size(622, 377);
            this.graph_y_vs_t.TabIndex = 9;
            title2.Name = "Title1";
            title2.Text = "Tita(t) vs t";
            this.graph_y_vs_t.Titles.Add(title2);
            this.graph_y_vs_t.Visible = false;
            // 
            // graph_yPrima_vs_y
            // 
            this.graph_yPrima_vs_y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.graph_yPrima_vs_y.CausesValidation = false;
            chartArea3.AxisX.Title = "Tita(t)";
            chartArea3.AxisY.Title = "Tita\'(t)";
            chartArea3.Name = "optimo";
            this.graph_yPrima_vs_y.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graph_yPrima_vs_y.Legends.Add(legend3);
            this.graph_yPrima_vs_y.Location = new System.Drawing.Point(642, 389);
            this.graph_yPrima_vs_y.Name = "graph_yPrima_vs_y";
            series5.ChartArea = "optimo";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series5.Legend = "Legend1";
            series5.Name = "c1";
            series6.ChartArea = "optimo";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series6.Legend = "Legend1";
            series6.Name = "c2";
            series7.ChartArea = "optimo";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series7.Legend = "Legend1";
            series7.Name = "c3";
            this.graph_yPrima_vs_y.Series.Add(series5);
            this.graph_yPrima_vs_y.Series.Add(series6);
            this.graph_yPrima_vs_y.Series.Add(series7);
            this.graph_yPrima_vs_y.Size = new System.Drawing.Size(622, 377);
            this.graph_yPrima_vs_y.TabIndex = 10;
            title3.Name = "Title1";
            title3.Text = "Tita\'(t) vs tita(t)";
            this.graph_yPrima_vs_y.Titles.Add(title3);
            this.graph_yPrima_vs_y.Visible = false;
            // 
            // Tp6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 778);
            this.Controls.Add(this.graph_yPrima_vs_y);
            this.Controls.Add(this.graph_y_vs_t);
            this.Controls.Add(this.graph_optimo);
            this.Controls.Add(this.gb_resultados);
            this.Controls.Add(this.btn_detener);
            this.Controls.Add(this.btn_optimo);
            this.Controls.Add(this.gb_intervalo);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.gb_condiciones_iniciales);
            this.Controls.Add(this.gb_constantes);
            this.Controls.Add(this.gb_metodos);
            this.Name = "Tp6";
            this.Text = "De Franceschi Andrea 62127 - García Majorel Álvaro 61856 - García Reyna Facundo 6" +
    "3583 - Oliveda Claudio 49594 - Varela Sofía 65126";
            this.gb_metodos.ResumeLayout(false);
            this.gb_metodos.PerformLayout();
            this.gb_constantes.ResumeLayout(false);
            this.gb_constantes.PerformLayout();
            this.gb_condiciones_iniciales.ResumeLayout(false);
            this.gb_condiciones_iniciales.PerformLayout();
            this.gb_intervalo.ResumeLayout(false);
            this.gb_intervalo.PerformLayout();
            this.gb_resultados.ResumeLayout(false);
            this.gb_resultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_optimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_y_vs_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_yPrima_vs_y)).EndInit();
            this.ResumeLayout(false);
            this.FormClosing += Tp6_FormClosing;

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_metodos;
        private System.Windows.Forms.LinkLabel lbl_runge_kutta;
        private System.Windows.Forms.LinkLabel lk_euler_mejorado;
        private System.Windows.Forms.LinkLabel lk_euler;
        private System.Windows.Forms.RadioButton rb_runge_kutta;
        private System.Windows.Forms.RadioButton rb_euler_mejorado;
        private System.Windows.Forms.RadioButton rb_euler;
        private System.Windows.Forms.GroupBox gb_constantes;
        private System.Windows.Forms.TextBox txt_c3;
        private System.Windows.Forms.TextBox txt_c2;
        private System.Windows.Forms.TextBox txt_c1;
        private System.Windows.Forms.Label lbl_c3;
        private System.Windows.Forms.Label lbl_c2;
        private System.Windows.Forms.Label lbl_c1;
        private System.Windows.Forms.GroupBox gb_condiciones_iniciales;
        private System.Windows.Forms.TextBox txt_y_prima_0;
        private System.Windows.Forms.TextBox txt_y_0;
        private System.Windows.Forms.Label lbl_y_prima_0;
        private System.Windows.Forms.Label lbl_y_0;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.GroupBox gb_intervalo;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Button btn_optimo;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.GroupBox gb_resultados;
        private System.Windows.Forms.Button btn_comparar;
        private System.Windows.Forms.TextBox txt_c_optimo;
        private System.Windows.Forms.TextBox txt_tiempo_optimo;
        private System.Windows.Forms.Label lbl_tiempo_optimo;
        private System.Windows.Forms.Label lbl_c_optimo;
        private System.Windows.Forms.TextBox txt_tiempo_c1;
        private System.Windows.Forms.TextBox txt_tiempo_c2;
        private System.Windows.Forms.TextBox txt_tiempo_c3;
        private System.Windows.Forms.Label lbl_tiempo_c3;
        private System.Windows.Forms.Label lbl_tiempo_c2;
        private System.Windows.Forms.Label lbl_tiempo_c1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph_optimo;
        private System.Windows.Forms.TextBox txt_h;
        private System.Windows.Forms.Label lbl_h;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph_y_vs_t;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph_yPrima_vs_y;
    }
}

