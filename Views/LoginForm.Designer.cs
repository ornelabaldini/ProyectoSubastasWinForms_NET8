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
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Location = new Point(239, 38);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(278, 25);
            lblBienvenido.TabIndex = 1;
            lblBienvenido.Text = "Bienvenid@ al gestor de subastas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(281, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(281, 146);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 3;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(296, 253);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(112, 54);
            btnContinuar.TabIndex = 5;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(281, 199);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(150, 31);
            txtDni.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDni);
            Controls.Add(btnContinuar);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblBienvenido);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnContinuar;
        private TextBox txtDni;
    }
}