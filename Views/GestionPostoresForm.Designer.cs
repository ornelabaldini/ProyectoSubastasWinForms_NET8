namespace ProyectoSubastasWinForms_NET8.Views
{
    partial class GestionPostoresForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridView dataGridViewPostores;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDni = new TextBox();
            this.txtNombre = new TextBox();
            this.txtApellido = new TextBox();
            this.btnAgregar = new Button();
            this.btnEliminar = new Button();
            this.dataGridViewPostores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostores)).BeginInit();
            this.SuspendLayout();

            // txtDni
            this.txtDni.Location = new System.Drawing.Point(12, 12);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "DNI";
            this.txtDni.Size = new System.Drawing.Size(100, 23);

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(120, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 23);

            // txtApellido
            this.txtApellido.Location = new System.Drawing.Point(250, 12);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 23);

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(380, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);

            // btnEliminar
            this.btnEliminar.Location = new System.Drawing.Point(460, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);

            // dataGridViewPostores
            this.dataGridViewPostores.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewPostores.Name = "dataGridViewPostores";
            this.dataGridViewPostores.Size = new System.Drawing.Size(523, 200);
            this.dataGridViewPostores.ReadOnly = true;
            this.dataGridViewPostores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // GestionPostoresForm
            this.ClientSize = new System.Drawing.Size(550, 270);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridViewPostores);
            this.Name = "GestionPostoresForm";
            this.Text = "Gestionar Postores";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
