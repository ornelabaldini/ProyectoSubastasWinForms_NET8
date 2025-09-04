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
            txtSubastador.Size = new Size(210, 31);
            txtSubastador.TabIndex = 0;
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(251, 12);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.PlaceholderText = "Artículo";
            txtArticulo.Size = new Size(100, 31);
            txtArticulo.TabIndex = 1;
            // 
            // numericPujaInicial
            // 
            numericPujaInicial.DecimalPlaces = 2;
            numericPujaInicial.Location = new Point(12, 63);
            numericPujaInicial.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericPujaInicial.Name = "numericPujaInicial";
            numericPujaInicial.Size = new Size(120, 31);
            numericPujaInicial.TabIndex = 2;
            numericPujaInicial.ValueChanged += numericPujaInicial_ValueChanged;
            // 
            // numericPujaAumento
            // 
            numericPujaAumento.DecimalPlaces = 2;
            numericPujaAumento.Location = new Point(151, 63);
            numericPujaAumento.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPujaAumento.Name = "numericPujaAumento";
            numericPujaAumento.Size = new Size(120, 31);
            numericPujaAumento.TabIndex = 3;
            // 
            // numericDuracion
            // 
            numericDuracion.Location = new Point(301, 63);
            numericDuracion.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            numericDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDuracion.Name = "numericDuracion";
            numericDuracion.Size = new Size(120, 31);
            numericDuracion.TabIndex = 4;
            numericDuracion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerFecha.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecha.Location = new Point(12, 103);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(223, 31);
            dateTimePickerFecha.TabIndex = 5;
            // 
            // btnNuevaSubasta
            // 
            btnNuevaSubasta.Location = new Point(251, 100);
            btnNuevaSubasta.Name = "btnNuevaSubasta";
            btnNuevaSubasta.Size = new Size(75, 34);
            btnNuevaSubasta.TabIndex = 6;
            btnNuevaSubasta.Text = "Nueva Subasta";
            btnNuevaSubasta.Click += btnNuevaSubasta_Click;
            // 
            // btnGestionPostores
            // 
            btnGestionPostores.Location = new Point(380, 145);
            btnGestionPostores.Name = "btnGestionPostores";
            btnGestionPostores.Size = new Size(75, 35);
            btnGestionPostores.TabIndex = 8;
            btnGestionPostores.Text = "Postores";
            btnGestionPostores.Click += btnGestionPostores_Click;
            // 
            // btnRegistrarPuja
            // 
            btnRegistrarPuja.Location = new Point(380, 262);
            btnRegistrarPuja.Name = "btnRegistrarPuja";
            btnRegistrarPuja.Size = new Size(157, 37);
            btnRegistrarPuja.TabIndex = 11;
            btnRegistrarPuja.Text = "Registrar Puja";
            btnRegistrarPuja.Click += btnRegistrarPuja_Click;
            // 
            // listBoxSubastas
            // 
            listBoxSubastas.ItemHeight = 25;
            listBoxSubastas.Location = new Point(12, 145);
            listBoxSubastas.Name = "listBoxSubastas";
            listBoxSubastas.Size = new Size(360, 154);
            listBoxSubastas.TabIndex = 7;
            listBoxSubastas.SelectedIndexChanged += listBoxSubastas_SelectedIndexChanged;
            // 
            // comboPostores
            // 
            comboPostores.Location = new Point(380, 186);
            comboPostores.Name = "comboPostores";
            comboPostores.Size = new Size(150, 33);
            comboPostores.TabIndex = 9;
            // 
            // numericMonto
            // 
            numericMonto.DecimalPlaces = 2;
            numericMonto.Location = new Point(380, 225);
            numericMonto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericMonto.Name = "numericMonto";
            numericMonto.Size = new Size(120, 31);
            numericMonto.TabIndex = 10;
            // 
            // lblPujaActual
            // 
            lblPujaActual.AutoSize = true;
            lblPujaActual.Location = new Point(12, 300);
            lblPujaActual.Name = "lblPujaActual";
            lblPujaActual.Size = new Size(112, 25);
            lblPujaActual.TabIndex = 12;
            lblPujaActual.Text = "Puja actual: -";
            // 
            // lblGanadorActual
            // 
            lblGanadorActual.AutoSize = true;
            lblGanadorActual.Location = new Point(538, 42);
            lblGanadorActual.Name = "lblGanadorActual";
            lblGanadorActual.Size = new Size(134, 25);
            lblGanadorActual.TabIndex = 13;
            lblGanadorActual.Text = "Ganador Actual";
            // 
            // SubastaForm
            // 
            ClientSize = new Size(799, 377);
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
    }
}
