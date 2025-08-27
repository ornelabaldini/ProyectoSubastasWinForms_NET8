using ProyectoSubastasWinForms_NET8.Controllers;
using ProyectoSubastasWinForms_NET8.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoSubastasWinForms_NET8.Views
{
    public partial class MainForm : Form
    {
        private readonly PostorController controller;
        public MainForm()
        {
            InitializeComponent();

            controller = new PostorController();
            //CargarEjemplos();
            ActualizarGrid();
        }

        private void CargarEjemplos()
        {
            controller.AgregarPostor(12345678, "Ana", "Pérez");
            controller.AgregarPostor(23456789, "Luis", "Gómez");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtDni.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            bool ok = controller.AgregarPostor(dni, nombre, apellido);
            if (!ok) MessageBox.Show("Ya existe un cliente con ese DNI.");
            ActualizarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtDni.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            bool ok = controller.ModificarPostor(dni, nombre, apellido);
            if (!ok) MessageBox.Show("Postor no encontrado.");
            ActualizarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtDni.Text);
            bool ok = controller.EliminarPostor(dni);
            if (!ok) MessageBox.Show("Postor no encontrado.");
            ActualizarGrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            Postor p = dataGridView1.CurrentRow.DataBoundItem as Postor;
            if (p == null) return;
            txtDni.Text = p.Dni.ToString();
            txtNombre.Text = p.Nombre;
            txtApellido.Text = p.Apellido;
        }

        private void ActualizarGrid()
        {
            List<Postor> postores = controller.ObtenerPostores();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = postores;
        }
    }
}

