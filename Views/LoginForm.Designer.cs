namespace ProyectoSubastasWinForms_NET8.Views
{
    partial class LoginForm
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
            lblBienvenido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnContinuar = new Button();
            txtDni = new TextBox();
            linkLabelRegistrarse = new LinkLabel();
            linkLabelIniciarSesion = new LinkLabel();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = Color.FromArgb(255, 217, 0);
            lblBienvenido.Font = new Font("Ink Free", 16F, FontStyle.Bold);
            lblBienvenido.Location = new Point(105, 21);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(511, 39);
            lblBienvenido.TabIndex = 1;
            lblBienvenido.Text = "Bienvenid@ al gestor de subastas";
            lblBienvenido.Click += lblBienvenido_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(172, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(363, 29);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(172, 182);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(363, 29);
            txtApellido.TabIndex = 3;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.FromArgb(255, 217, 0);
            btnContinuar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinuar.Location = new Point(212, 360);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(260, 54);
            btnContinuar.TabIndex = 5;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDni.Location = new Point(172, 250);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(363, 29);
            txtDni.TabIndex = 4;
            // 
            // linkLabelRegistrarse
            // 
            linkLabelRegistrarse.AutoSize = true;
            linkLabelRegistrarse.LinkColor = Color.Black;
            linkLabelRegistrarse.Location = new Point(230, 445);
            linkLabelRegistrarse.Name = "linkLabelRegistrarse";
            linkLabelRegistrarse.Size = new Size(243, 25);
            linkLabelRegistrarse.TabIndex = 6;
            linkLabelRegistrarse.TabStop = true;
            linkLabelRegistrarse.Text = "¿No tienes cuenta? Regístrate";
            linkLabelRegistrarse.LinkClicked += linkLabelRegistrarse_LinkClicked;
            // 
            // linkLabelIniciarSesion
            // 
            linkLabelIniciarSesion.AutoSize = true;
            linkLabelIniciarSesion.LinkColor = Color.Black;
            linkLabelIniciarSesion.Location = new Point(230, 486);
            linkLabelIniciarSesion.Name = "linkLabelIniciarSesion";
            linkLabelIniciarSesion.Size = new Size(255, 25);
            linkLabelIniciarSesion.TabIndex = 7;
            linkLabelIniciarSesion.TabStop = true;
            linkLabelIniciarSesion.Text = "¿Ya tenés cuenta? Iniciar sesión";
            linkLabelIniciarSesion.LinkClicked += linkLabelIniciarSesion_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 217, 0);
            BackgroundImage = Properties.Resources.login;
            ClientSize = new Size(815, 538);
            Controls.Add(linkLabelIniciarSesion);
            Controls.Add(linkLabelRegistrarse);
            Controls.Add(txtDni);
            Controls.Add(btnContinuar);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblBienvenido);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnContinuar;
        private TextBox txtDni;
        private LinkLabel linkLabelRegistrarse;
        private LinkLabel linkLabelIniciarSesion;
    }
}