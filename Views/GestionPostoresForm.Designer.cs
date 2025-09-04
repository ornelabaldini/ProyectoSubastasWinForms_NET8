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
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            dataGridViewPostores = new DataGridView();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostores).BeginInit();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Location = new Point(12, 12);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(100, 31);
            txtDni.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(120, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(250, 12);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(120, 31);
            txtApellido.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(576, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 43);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(676, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 43);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridViewPostores
            // 
            dataGridViewPostores.ColumnHeadersHeight = 34;
            dataGridViewPostores.Location = new Point(22, 79);
            dataGridViewPostores.Name = "dataGridViewPostores";
            dataGridViewPostores.ReadOnly = true;
            dataGridViewPostores.RowHeadersWidth = 62;
            dataGridViewPostores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPostores.Size = new Size(523, 200);
            dataGridViewPostores.TabIndex = 5;
            dataGridViewPostores.CellClick += dataGridViewPostores_CellClick;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(376, 12);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 3;
            // 
            // GestionPostoresForm
            // 
            ClientSize = new Size(771, 347);
            Controls.Add(txtEmail);
            Controls.Add(txtDni);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridViewPostores);
            Name = "GestionPostoresForm";
            Text = "Gestionar Postores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtEmail;
    }
}
