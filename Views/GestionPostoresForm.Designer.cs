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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPostoresForm));
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            dataGridViewPostores = new DataGridView();
            txtEmail = new TextBox();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostores).BeginInit();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDni.Location = new Point(12, 12);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(100, 29);
            txtDni.TabIndex = 0;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(120, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(120, 29);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(250, 12);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(120, 29);
            txtApellido.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(562, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 43);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(676, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 43);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridViewPostores
            // 
            dataGridViewPostores.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewPostores.ColumnHeadersHeight = 34;
            dataGridViewPostores.Location = new Point(12, 93);
            dataGridViewPostores.Name = "dataGridViewPostores";
            dataGridViewPostores.ReadOnly = true;
            dataGridViewPostores.RowHeadersWidth = 62;
            dataGridViewPostores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPostores.Size = new Size(897, 305);
            dataGridViewPostores.TabIndex = 5;
            dataGridViewPostores.CellClick += dataGridViewPostores_CellClick;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(376, 12);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(150, 29);
            txtEmail.TabIndex = 3;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 217, 0);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Location = new Point(398, 432);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(112, 54);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Listo";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // GestionPostoresForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 563);
            Controls.Add(btnCerrar);
            Controls.Add(txtEmail);
            Controls.Add(txtDni);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridViewPostores);
            DoubleBuffered = true;
            Name = "GestionPostoresForm";
            Text = "Gestionar Postores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtEmail;
        private Button btnCerrar;
    }
}
