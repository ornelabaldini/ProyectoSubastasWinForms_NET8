using ProyectoSubastasWinForms_NET8.Controllers;
using ProyectoSubastasWinForms_NET8.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoSubastasWinForms_NET8.Views
{
    public partial class MainForm : Form
    {
        private readonly PostorController postorController;
        private readonly List<Postor> postores;

        public MainForm()
        {
            InitializeComponent();
            postorController = new PostorController();
            postores = postorController.ObtenerPostores();

            ActualizarGrid();
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
            string email = txtEmail.Text.Trim();

            bool ok = postorController.AgregarPostor(dni, nombre, apellido, email);
            if (!ok)
            {
                MessageBox.Show("Ya existe un postor con ese DNI.");
            }

            ActualizarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("DNI inválido.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string email = txtEmail.Text.Trim();

            bool ok = postorController.ModificarPostor(dni, nombre, apellido, email);
            if (!ok)
            {
                MessageBox.Show("Postor no encontrado.");
            }

            ActualizarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("DNI inválido.");
                return;
            }

            bool ok = postorController.EliminarPostor(dni);
            if (!ok)
            {
                MessageBox.Show("Postor no encontrado.");
            }

            ActualizarGrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                txtDni.Text = dataGridView1.CurrentRow.Cells["Dni"].Value?.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value?.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value?.ToString();
            }
            else
            {
                txtDni.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
            }
        }

        private void ActualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = postores;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirSubasta_Click(object sender, EventArgs e)
        {
            var subastaController = new SubastaController();
            var subastaForm = new SubastaForm(subastaController, postores);
            subastaForm.Show();
        }
    }
}
