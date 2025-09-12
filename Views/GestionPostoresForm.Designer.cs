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
            txtDni.BackColor = SystemColors.InactiveBorder;
            txtDni.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDni.Location = new Point(12, 12);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(159, 40);
            txtDni.TabIndex = 0;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(12, 75);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(159, 44);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(12, 140);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(159, 49);
            txtApellido.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(210, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 43);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(210, 96);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 43);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridViewPostores
            // 
            dataGridViewPostores.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewPostores.ColumnHeadersHeight = 34;
            dataGridViewPostores.Location = new Point(363, 12);
            dataGridViewPostores.Name = "dataGridViewPostores";
            dataGridViewPostores.ReadOnly = true;
            dataGridViewPostores.RowHeadersWidth = 62;
            dataGridViewPostores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPostores.Size = new Size(512, 212);
            dataGridViewPostores.TabIndex = 5;
            dataGridViewPostores.CellClick += dataGridViewPostores_CellClick;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(12, 216);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(159, 49);
            txtEmail.TabIndex = 3;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 217, 0);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Location = new Point(173, 451);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(545, 54);
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
