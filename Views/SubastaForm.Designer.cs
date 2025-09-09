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
            label1 = new Label();
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
            txtArticulo.Location = new Point(500, 12);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.PlaceholderText = "Artículo";
            txtArticulo.Size = new Size(326, 29);
            txtArticulo.TabIndex = 1;
            // 
            // numericPujaInicial
            // 
            numericPujaInicial.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericPujaInicial.Location = new Point(12, 93);
            numericPujaInicial.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericPujaInicial.Name = "numericPujaInicial";
            numericPujaInicial.Size = new Size(120, 29);
            numericPujaInicial.TabIndex = 2;
            numericPujaInicial.ValueChanged += numericPujaInicial_ValueChanged;
            // 
            // numericPujaAumento
            // 
            numericPujaAumento.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericPujaAumento.Location = new Point(178, 93);
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
            numericDuracion.Location = new Point(343, 93);
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
            dateTimePickerFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerFecha.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerFecha.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecha.Location = new Point(541, 90);
            dateTimePickerFecha.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            dateTimePickerFecha.MinDate = new DateTime(2025, 9, 8, 0, 0, 0, 0);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(223, 29);
            dateTimePickerFecha.TabIndex = 5;
            dateTimePickerFecha.TabStop = false;
            // 
            // btnNuevaSubasta
            // 
            btnNuevaSubasta.BackColor = Color.FromArgb(255, 217, 0);
            btnNuevaSubasta.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            btnNuevaSubasta.Location = new Point(218, 130);
            btnNuevaSubasta.Name = "btnNuevaSubasta";
            btnNuevaSubasta.Size = new Size(268, 48);
            btnNuevaSubasta.TabIndex = 6;
            btnNuevaSubasta.Text = "Nueva Subasta";
            btnNuevaSubasta.UseVisualStyleBackColor = false;
            btnNuevaSubasta.Click += btnNuevaSubasta_Click;
            // 
            // btnGestionPostores
            // 
            btnGestionPostores.BackColor = Color.FromArgb(255, 217, 0);
            btnGestionPostores.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionPostores.Location = new Point(932, 265);
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
            btnRegistrarPuja.Location = new Point(893, 480);
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
            comboPostores.Location = new Point(852, 346);
            comboPostores.Name = "comboPostores";
            comboPostores.Size = new Size(312, 30);
            comboPostores.TabIndex = 9;
            // 
            // numericMonto
            // 
            numericMonto.DecimalPlaces = 2;
            numericMonto.Location = new Point(957, 430);
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
            lblPujaInicial.BackColor = Color.FromArgb(255, 217, 0);
            lblPujaInicial.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblPujaInicial.Location = new Point(12, 63);
            lblPujaInicial.Name = "lblPujaInicial";
            lblPujaInicial.Size = new Size(125, 24);
            lblPujaInicial.TabIndex = 14;
            lblPujaInicial.Text = "Puja Inicial";
            lblPujaInicial.Click += label1_Click;
            // 
            // lblPujaAumento
            // 
            lblPujaAumento.AutoSize = true;
            lblPujaAumento.BackColor = Color.FromArgb(255, 217, 0);
            lblPujaAumento.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblPujaAumento.Location = new Point(163, 63);
            lblPujaAumento.Name = "lblPujaAumento";
            lblPujaAumento.Size = new Size(152, 24);
            lblPujaAumento.TabIndex = 15;
            lblPujaAumento.Text = "Puja Aumento";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.BackColor = Color.FromArgb(255, 217, 0);
            lblDuracion.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblDuracion.Location = new Point(321, 63);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(206, 24);
            lblDuracion.TabIndex = 16;
            lblDuracion.Text = "Duracion (minutos)";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.FromArgb(255, 217, 0);
            lblMonto.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            lblMonto.Location = new Point(967, 390);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(83, 27);
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
            txtDescripción.Size = new Size(312, 140);
            txtDescripción.TabIndex = 2;
            txtDescripción.TextChanged += txtDescripcion_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 217, 0);
            label1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label1.Location = new Point(541, 63);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 19;
            label1.Text = "Fecha";
            // 
            // SubastaForm
            // 
            BackgroundImage = Properties.Resources.Subasta;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1193, 620);
            Controls.Add(label1);
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
        private Label label1;
    }
}
