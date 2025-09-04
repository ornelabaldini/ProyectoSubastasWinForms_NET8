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
        private ListBox listBoxSubastas;
        private ComboBox comboPostores;
        private NumericUpDown numericMonto;
        private Label lblPujaActual;

        private void InitializeComponent()
        {
            txtSubastador = new TextBox();
            txtArticulo = new TextBox();
            numericPujaInicial = new NumericUpDown();
            numericPujaAumento = new NumericUpDown();
            numericDuracion = new NumericUpDown();
            dateTimePickerFecha = new DateTimePicker();
            btnNuevaSubasta = new Button();
            btnGestionPostores = new Button();
            btnRegistrarPuja = new Button();
            listBoxSubastas = new ListBox();
            comboPostores = new ComboBox();
            numericMonto = new NumericUpDown();
            lblPujaActual = new Label();
            lblGanadorActual = new Label();
            lblPujaInicial = new Label();
            lblPujaAumento = new Label();
            lblDuracion = new Label();
            lblMonto = new Label();
            ((System.ComponentModel.ISupportInitialize)numericPujaInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPujaAumento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMonto).BeginInit();
            SuspendLayout();
            // 
            // txtSubastador
            // 
            txtSubastador.Location = new Point(12, 12);
            txtSubastador.Name = "txtSubastador";
            txtSubastador.PlaceholderText = "Nombre del subastador";
            txtSubastador.Size = new Size(449, 31);
            txtSubastador.TabIndex = 0;
            txtSubastador.TextChanged += txtSubastador_TextChanged;
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(568, 12);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.PlaceholderText = "Artículo";
            txtArticulo.Size = new Size(323, 31);
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
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(223, 31);
            dateTimePickerFecha.TabIndex = 5;
            // 
            // btnNuevaSubasta
            // 
            btnNuevaSubasta.Location = new Point(12, 177);
            btnNuevaSubasta.Name = "btnNuevaSubasta";
            btnNuevaSubasta.Size = new Size(398, 34);
            btnNuevaSubasta.TabIndex = 6;
            btnNuevaSubasta.Text = "Nueva Subasta";
            btnNuevaSubasta.Click += btnNuevaSubasta_Click;
            // 
            // btnGestionPostores
            // 
            btnGestionPostores.Location = new Point(378, 294);
            btnGestionPostores.Name = "btnGestionPostores";
            btnGestionPostores.Size = new Size(157, 35);
            btnGestionPostores.TabIndex = 8;
            btnGestionPostores.Text = "Postores";
            btnGestionPostores.Click += btnGestionPostores_Click;
            // 
            // btnRegistrarPuja
            // 
            btnRegistrarPuja.Location = new Point(378, 467);
            btnRegistrarPuja.Name = "btnRegistrarPuja";
            btnRegistrarPuja.Size = new Size(157, 37);
            btnRegistrarPuja.TabIndex = 11;
            btnRegistrarPuja.Text = "Registrar Puja";
            btnRegistrarPuja.Click += btnRegistrarPuja_Click;
            // 
            // listBoxSubastas
            // 
            listBoxSubastas.ItemHeight = 25;
            listBoxSubastas.Location = new Point(12, 294);
            listBoxSubastas.Name = "listBoxSubastas";
            listBoxSubastas.Size = new Size(360, 229);
            listBoxSubastas.TabIndex = 7;
            listBoxSubastas.SelectedIndexChanged += listBoxSubastas_SelectedIndexChanged;
            // 
            // comboPostores
            // 
            comboPostores.AccessibleDescription = "";
            comboPostores.Location = new Point(378, 335);
            comboPostores.Name = "comboPostores";
            comboPostores.Size = new Size(157, 33);
            comboPostores.TabIndex = 9;
            // 
            // numericMonto
            // 
            numericMonto.DecimalPlaces = 2;
            numericMonto.Location = new Point(378, 413);
            numericMonto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericMonto.Name = "numericMonto";
            numericMonto.Size = new Size(120, 31);
            numericMonto.TabIndex = 10;
            // 
            // lblPujaActual
            // 
            lblPujaActual.AutoSize = true;
            lblPujaActual.Location = new Point(20, 548);
            lblPujaActual.Name = "lblPujaActual";
            lblPujaActual.Size = new Size(112, 25);
            lblPujaActual.TabIndex = 12;
            lblPujaActual.Text = "Puja actual: -";
            // 
            // lblGanadorActual
            // 
            lblGanadorActual.AutoSize = true;
            lblGanadorActual.Location = new Point(1025, 32);
            lblGanadorActual.Name = "lblGanadorActual";
            lblGanadorActual.Size = new Size(134, 25);
            lblGanadorActual.TabIndex = 13;
            lblGanadorActual.Text = "Ganador Actual";
            // 
            // lblPujaInicial
            // 
            lblPujaInicial.AutoSize = true;
            lblPujaInicial.Location = new Point(3, 63);
            lblPujaInicial.Name = "lblPujaInicial";
            lblPujaInicial.Size = new Size(94, 25);
            lblPujaInicial.TabIndex = 14;
            lblPujaInicial.Text = "Puja Inicial";
            lblPujaInicial.Click += label1_Click;
            // 
            // lblPujaAumento
            // 
            lblPujaAumento.AutoSize = true;
            lblPujaAumento.Location = new Point(143, 63);
            lblPujaAumento.Name = "lblPujaAumento";
            lblPujaAumento.Size = new Size(124, 25);
            lblPujaAumento.TabIndex = 15;
            lblPujaAumento.Text = "Puja Aumento";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(290, 63);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(163, 25);
            lblDuracion.TabIndex = 16;
            lblDuracion.Text = "Duracion (minutos)";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(378, 385);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(66, 25);
            lblMonto.TabIndex = 17;
            lblMonto.Text = "Monto";
            // 
            // SubastaForm
            // 
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
            Controls.Add(listBoxSubastas);
            Controls.Add(btnGestionPostores);
            Controls.Add(comboPostores);
            Controls.Add(numericMonto);
            Controls.Add(btnRegistrarPuja);
            Controls.Add(lblPujaActual);
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
    }
}
