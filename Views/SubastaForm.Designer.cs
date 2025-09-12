using System.Windows.Forms;

namespace ProyectoSubastasWinForms_NET8.Views
{
    partial class SubastaForm
    {
        private TextBox txtSubastador;
        private TextBox txtArticulo;
        private NumericUpDown numericPujaInicial;
        private NumericUpDown numericPujaAumento;
        private NumericUpDown numericDuracion;
        private DateTimePicker dateTimePickerFecha;
        private Button btnNuevaSubasta;
        private Button btnGestionPostores;
        private Button btnRegistrarPuja;
        private ListBox Subastas;
        private ComboBox comboPostores;
        private NumericUpDown numericMonto;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubastaForm));
            txtSubastador = new TextBox();
            txtArticulo = new TextBox();
            numericPujaInicial = new NumericUpDown();
            numericPujaAumento = new NumericUpDown();
            numericDuracion = new NumericUpDown();
            dateTimePickerFecha = new DateTimePicker();
            btnNuevaSubasta = new Button();
            btnGestionPostores = new Button();
            btnRegistrarPuja = new Button();
            Subastas = new ListBox();
            comboPostores = new ComboBox();
            numericMonto = new NumericUpDown();
            lblGanadorActual = new Label();
            lblPujaInicial = new Label();
            lblPujaAumento = new Label();
            lblDuracion = new Label();
            lblMonto = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            txtDescripción = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericPujaInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPujaAumento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMonto).BeginInit();
            SuspendLayout();
            // 
            // txtSubastador
            // 
            txtSubastador.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSubastador.Location = new Point(12, 12);
            txtSubastador.Name = "txtSubastador";
            txtSubastador.PlaceholderText = "Nombre del subastador";
            txtSubastador.Size = new Size(449, 29);
            txtSubastador.TabIndex = 0;
            txtSubastador.TextChanged += txtSubastador_TextChanged;
            // 
            // txtArticulo
            // 
            txtArticulo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtArticulo.Location = new Point(482, 12);
            txtArticulo.Multiline = true;
            txtArticulo.Name = "txtArticulo";
            txtArticulo.PlaceholderText = "Artículo";
            txtArticulo.Size = new Size(344, 58);
            txtArticulo.TabIndex = 1;
            // 
            // numericPujaInicial
            // 
            numericPujaInicial.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericPujaInicial.Location = new Point(273, 61);
            numericPujaInicial.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericPujaInicial.Name = "numericPujaInicial";
            numericPujaInicial.Size = new Size(120, 29);
            numericPujaInicial.TabIndex = 2;
            numericPujaInicial.ValueChanged += numericPujaInicial_ValueChanged;
            // 
            // numericPujaAumento
            // 
            numericPujaAumento.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericPujaAumento.Location = new Point(273, 98);
            numericPujaAumento.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPujaAumento.Name = "numericPujaAumento";
            numericPujaAumento.Size = new Size(120, 29);
            numericPujaAumento.TabIndex = 3;
            numericPujaAumento.ValueChanged += numericPujaAumento_ValueChanged;
            // 
            // numericDuracion
            // 
            numericDuracion.AccessibleDescription = "";
            numericDuracion.AccessibleName = "Duracion";
            numericDuracion.BackColor = Color.White;
            numericDuracion.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericDuracion.ForeColor = Color.Black;
            numericDuracion.Location = new Point(273, 130);
            numericDuracion.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            numericDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDuracion.Name = "numericDuracion";
            numericDuracion.Size = new Size(155, 29);
            numericDuracion.TabIndex = 4;
            numericDuracion.TextAlign = HorizontalAlignment.Center;
            numericDuracion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericDuracion.ValueChanged += numericDuracion_ValueChanged;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.CalendarForeColor = SystemColors.ActiveBorder;
            dateTimePickerFecha.CalendarMonthBackground = Color.Transparent;
            dateTimePickerFecha.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerFecha.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerFecha.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecha.Location = new Point(24, 168);
            dateTimePickerFecha.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            dateTimePickerFecha.MinDate = new DateTime(2025, 9, 8, 0, 0, 0, 0);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(395, 29);
            dateTimePickerFecha.TabIndex = 5;
            dateTimePickerFecha.TabStop = false;
            // 
            // btnNuevaSubasta
            // 
            btnNuevaSubasta.BackColor = Color.FromArgb(255, 217, 0);
            btnNuevaSubasta.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            btnNuevaSubasta.Location = new Point(482, 100);
            btnNuevaSubasta.Name = "btnNuevaSubasta";
            btnNuevaSubasta.Size = new Size(314, 83);
            btnNuevaSubasta.TabIndex = 6;
            btnNuevaSubasta.Text = "Nueva Subasta";
            btnNuevaSubasta.UseVisualStyleBackColor = false;
            btnNuevaSubasta.Click += btnNuevaSubasta_Click;
            // 
            // btnGestionPostores
            // 
            btnGestionPostores.BackColor = Color.FromArgb(255, 217, 0);
            btnGestionPostores.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnGestionPostores.Location = new Point(832, 265);
            btnGestionPostores.Name = "btnGestionPostores";
            btnGestionPostores.Size = new Size(157, 64);
            btnGestionPostores.TabIndex = 8;
            btnGestionPostores.Text = "Postores:";
            btnGestionPostores.UseVisualStyleBackColor = false;
            btnGestionPostores.Click += btnGestionPostores_Click;
            // 
            // btnRegistrarPuja
            // 
            btnRegistrarPuja.BackColor = Color.FromArgb(255, 217, 0);
            btnRegistrarPuja.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnRegistrarPuja.Location = new Point(887, 407);
            btnRegistrarPuja.Name = "btnRegistrarPuja";
            btnRegistrarPuja.Size = new Size(238, 66);
            btnRegistrarPuja.TabIndex = 11;
            btnRegistrarPuja.Text = "Registrar Puja";
            btnRegistrarPuja.UseVisualStyleBackColor = false;
            btnRegistrarPuja.Click += btnRegistrarPuja_Click;
            // 
            // Subastas
            // 
            Subastas.BackColor = SystemColors.GradientInactiveCaption;
            Subastas.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subastas.HorizontalScrollbar = true;
            Subastas.ItemHeight = 29;
            Subastas.Location = new Point(12, 265);
            Subastas.Name = "Subastas";
            Subastas.Size = new Size(814, 294);
            Subastas.TabIndex = 7;
            Subastas.SelectedIndexChanged += listBoxSubastas_SelectedIndexChanged;
            // 
            // comboPostores
            // 
            comboPostores.AccessibleDescription = "";
            comboPostores.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboPostores.Location = new Point(1005, 285);
            comboPostores.Name = "comboPostores";
            comboPostores.Size = new Size(176, 30);
            comboPostores.TabIndex = 9;
            // 
            // numericMonto
            // 
            numericMonto.DecimalPlaces = 2;
            numericMonto.Location = new Point(1005, 341);
            numericMonto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericMonto.Name = "numericMonto";
            numericMonto.Size = new Size(120, 31);
            numericMonto.TabIndex = 10;
            // 
            // lblGanadorActual
            // 
            lblGanadorActual.AccessibleName = "";
            lblGanadorActual.AutoSize = true;
            lblGanadorActual.BackColor = Color.FromArgb(255, 217, 0);
            lblGanadorActual.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanadorActual.Location = new Point(12, 214);
            lblGanadorActual.Name = "lblGanadorActual";
            lblGanadorActual.Size = new Size(293, 34);
            lblGanadorActual.TabIndex = 13;
            lblGanadorActual.Text = "🏆Ganador Actual:  ";
            lblGanadorActual.Click += lblGanadorActual_Click_1;
            // 
            // lblPujaInicial
            // 
            lblPujaInicial.AutoSize = true;
            lblPujaInicial.BackColor = Color.Transparent;
            lblPujaInicial.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblPujaInicial.Location = new Point(24, 61);
            lblPujaInicial.Name = "lblPujaInicial";
            lblPujaInicial.Size = new Size(149, 29);
            lblPujaInicial.TabIndex = 14;
            lblPujaInicial.Text = "Puja Inicial";
            lblPujaInicial.Click += label1_Click;
            // 
            // lblPujaAumento
            // 
            lblPujaAumento.AutoSize = true;
            lblPujaAumento.BackColor = Color.Transparent;
            lblPujaAumento.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblPujaAumento.Location = new Point(24, 94);
            lblPujaAumento.Name = "lblPujaAumento";
            lblPujaAumento.Size = new Size(182, 29);
            lblPujaAumento.TabIndex = 15;
            lblPujaAumento.Text = "Puja Aumento";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.BackColor = Color.Transparent;
            lblDuracion.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblDuracion.Location = new Point(24, 130);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(246, 29);
            lblDuracion.TabIndex = 16;
            lblDuracion.Text = "Duracion (minutos)";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.FromArgb(255, 217, 0);
            lblMonto.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            lblMonto.Location = new Point(862, 345);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(104, 34);
            lblMonto.TabIndex = 17;
            lblMonto.Text = "Monto";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // txtDescripción
            // 
            txtDescripción.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripción.Location = new Point(852, 12);
            txtDescripción.Multiline = true;
            txtDescripción.Name = "txtDescripción";
            txtDescripción.PlaceholderText = "Descripción";
            txtDescripción.ScrollBars = ScrollBars.Vertical;
            txtDescripción.Size = new Size(312, 190);
            txtDescripción.TabIndex = 2;
            txtDescripción.TextChanged += txtDescripcion_TextChanged;
            // 
            // SubastaForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1193, 620);
            Controls.Add(txtDescripción);
            Controls.Add(lblMonto);
            Controls.Add(lblDuracion);
            Controls.Add(lblPujaAumento);
            Controls.Add(lblPujaInicial);
            Controls.Add(lblGanadorActual);
            Controls.Add(txtSubastador);
            Controls.Add(txtArticulo);
            Controls.Add(numericPujaInicial);
            Controls.Add(numericPujaAumento);
            Controls.Add(numericDuracion);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(btnNuevaSubasta);
            Controls.Add(Subastas);
            Controls.Add(btnGestionPostores);
            Controls.Add(comboPostores);
            Controls.Add(numericMonto);
            Controls.Add(btnRegistrarPuja);
            DoubleBuffered = true;
            Name = "SubastaForm";
            Text = "Gestión de Subastas";
            ((System.ComponentModel.ISupportInitialize)numericPujaInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPujaAumento).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblGanadorActual;
        private Label lblPujaInicial;
        private Label lblPujaAumento;
        private Label lblDuracion;
        private Label lblMonto;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        private TextBox txtDescripción;
    }
}
