using System;
using System.Windows.Forms;
using ProyectoSubastasWinForms_NET8.Models;

namespace ProyectoSubastasWinForms_NET8.Views
{
    public partial class GestionPostoresForm : Form
    {
        private Subasta subasta;

        public GestionPostoresForm(Subasta s)
        {
            subasta = s;
            InitializeComponent();
            CargarPostores();
        }

        private void CargarPostores()
        {
            dataGridViewPostores.DataSource = null;
            dataGridViewPostores.DataSource = subasta.Postores;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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

            // Crear postor con los tres parámetros
            Postor p = new Postor(dni, nombre, apellido);
            subasta.Postores.Add(p);
            CargarPostores();

            // Limpiar campos
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPostores.CurrentRow?.DataBoundItem is Postor p)
            {
                subasta.Postores.Remove(p);
                CargarPostores();
            }
        }
    }
}
