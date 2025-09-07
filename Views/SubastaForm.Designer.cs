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
        private Label lblPujaActual;

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
            lblPujaActual = new Label();
            lblGanadorActual = new Label();
            lblPujaInicial = new Label();
            lblPujaAumento = new Label();
            lblDuracion = new Label();
            lblMonto = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
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
            numericPujaInicial.DecimalPlaces = 2;
            numericPujaInicial.Location = new Point(3, 103);
            numericPujaInicial.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericPujaInicial.Name = "numericPujaInicial";
            numericPujaInicial.Size = new Size(120, 31);
            numericPujaInicial.TabIndex = 2;
            numericPujaInicial.ValueChanged += numericPujaInicial_ValueChanged;
            // 
            // numericPujaAumento
            // 
            numericPujaAumento.DecimalPlaces = 2;
            numericPujaAumento.Location = new Point(143, 103);
            numericPujaAumento.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPujaAumento.Name = "numericPujaAumento";
            numericPujaAumento.Size = new Size(120, 31);
            numericPujaAumento.TabIndex = 3;
            numericPujaAumento.ValueChanged += numericPujaAumento_ValueChanged;
            // 
            // numericDuracion
            // 
            numericDuracion.AccessibleDescription = "";
            numericDuracion.AccessibleName = "Duracion";
            numericDuracion.ForeColor = SystemColors.ActiveCaptionText;
            numericDuracion.Location = new Point(290, 103);
            numericDuracion.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            numericDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDuracion.Name = "numericDuracion";
            numericDuracion.Size = new Size(155, 31);
            numericDuracion.TabIndex = 4;
            numericDuracion.TextAlign = HorizontalAlignment.Center;
            numericDuracion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericDuracion.ValueChanged += numericDuracion_ValueChanged;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerFecha.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecha.Location = new Point(568, 100);
            dateTimePickerFecha.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            dateTimePickerFecha.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(223, 31);
            dateTimePickerFecha.TabIndex = 5;
            dateTimePickerFecha.TabStop = false;
            // 
            // btnNuevaSubasta
            // 
            btnNuevaSubasta.BackColor = Color.FromArgb(255, 217, 0);
            btnNuevaSubasta.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaSubasta.Location = new Point(47, 158);
            btnNuevaSubasta.Name = "btnNuevaSubasta";
            btnNuevaSubasta.Size = new Size(398, 83);
            btnNuevaSubasta.TabIndex = 6;
            btnNuevaSubasta.Text = "Nueva Subasta";
            btnNuevaSubasta.UseVisualStyleBackColor = false;
            btnNuevaSubasta.Click += btnNuevaSubasta_Click;
            // 
            // btnGestionPostores
            // 
            btnGestionPostores.BackColor = Color.FromArgb(255, 217, 0);
            btnGestionPostores.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionPostores.Location = new Point(932, 294);
            btnGestionPostores.Name = "btnGestionPostores";
            btnGestionPostores.Size = new Size(157, 35);
            btnGestionPostores.TabIndex = 8;
            btnGestionPostores.Text = "Postores";
            btnGestionPostores.UseVisualStyleBackColor = false;
            btnGestionPostores.Click += btnGestionPostores_Click;
            // 
            // btnRegistrarPuja
            // 
            btnRegistrarPuja.BackColor = Color.FromArgb(255, 217, 0);
            btnRegistrarPuja.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarPuja.Location = new Point(943, 481);
            btnRegistrarPuja.Name = "btnRegistrarPuja";
            btnRegistrarPuja.Size = new Size(157, 66);
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
            // lblPujaActual
            // 
            lblPujaActual.AutoSize = true;
            lblPujaActual.BackColor = Color.FromArgb(255, 217, 0);
            lblPujaActual.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPujaActual.Location = new Point(967, 109);
            lblPujaActual.Name = "lblPujaActual";
            lblPujaActual.Size = new Size(133, 22);
            lblPujaActual.TabIndex = 12;
            lblPujaActual.Text = "Puja actual: -";
            // 
            // lblGanadorActual
            // 
            lblGanadorActual.AutoSize = true;
            lblGanadorActual.BackColor = Color.FromArgb(255, 217, 0);
            lblGanadorActual.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanadorActual.Location = new Point(932, 12);
            lblGanadorActual.Name = "lblGanadorActual";
            lblGanadorActual.Size = new Size(232, 34);
            lblGanadorActual.TabIndex = 13;
            lblGanadorActual.Text = "Ganador Actual";
            // 
            // lblPujaInicial
            // 
            lblPujaInicial.AutoSize = true;
            lblPujaInicial.BackColor = Color.FromArgb(255, 217, 0);
            lblPujaInicial.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPujaInicial.Location = new Point(3, 63);
            lblPujaInicial.Name = "lblPujaInicial";
            lblPujaInicial.Size = new Size(114, 22);
            lblPujaInicial.TabIndex = 14;
            lblPujaInicial.Text = "Puja Inicial";
            lblPujaInicial.Click += label1_Click;
            // 
            // lblPujaAumento
            // 
            lblPujaAumento.AutoSize = true;
            lblPujaAumento.BackColor = Color.FromArgb(255, 217, 0);
            lblPujaAumento.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPujaAumento.Location = new Point(143, 63);
            lblPujaAumento.Name = "lblPujaAumento";
            lblPujaAumento.Size = new Size(139, 22);
            lblPujaAumento.TabIndex = 15;
            lblPujaAumento.Text = "Puja Aumento";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.BackColor = Color.FromArgb(255, 217, 0);
            lblDuracion.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuracion.Location = new Point(290, 63);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(187, 22);
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
            // SubastaForm
            // 
            BackgroundImage = Properties.Resources.Subasta;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1193, 620);
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
            Controls.Add(lblPujaActual);
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
    }
}
