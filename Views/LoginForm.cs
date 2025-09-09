using ProyectoSubastasWinForms_NET8.Controllers;
using ProyectoSubastasWinForms_NET8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSubastasWinForms_NET8.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Quitar el foco inicial del TextBox para que se vea el PlaceholderText
            Button invisibleButton = new Button();
            invisibleButton.Size = new Size(0, 0);
            invisibleButton.Location = new Point(-100, -100); // fuera de la vista
            this.Controls.Add(invisibleButton);
            this.ActiveControl = invisibleButton;

            // Suscribir controles al evento KeyDown
            txtDni.KeyDown += Control_KeyDown;
            txtNombre.KeyDown += Control_KeyDown;
            txtApellido.KeyDown += Control_KeyDown;

            // Anclar al centro horizontalmente
            lblBienvenido.Anchor = AnchorStyles.Top;

            // Hacer que los TextBox se expandan horizontalmente
            txtDni.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // El botón también se adapta
            btnContinuar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Los LinkLabel se adaptan horizontalmente
            linkLabelIniciarSesion.Anchor = AnchorStyles.Top;
            linkLabelRegistrarse.Anchor = AnchorStyles.Top; 
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("DNI inválido.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Debe ingresar nombre y apellido.");
                return;
            }

            Postor subastador = new Postor(dni, nombre, apellido, "");
            var subastaController = new SubastaController();

            var subastaForm = new SubastaForm(subastaController, new List<Postor>(), subastador);
            subastaForm.Show();

            this.Hide();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Funcionalidad de registro próximamente disponible 😉", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabelIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Ya estás en el formulario de inicio de sesión", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

