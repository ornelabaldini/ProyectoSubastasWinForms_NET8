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

    }
}
