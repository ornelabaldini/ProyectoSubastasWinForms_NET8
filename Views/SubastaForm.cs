using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProyectoSubastasWinForms_NET8.Models;
using ProyectoSubastasWinForms_NET8.Controllers;

namespace ProyectoSubastasWinForms_NET8.Views
{
    public partial class SubastaForm : Form
    {
        private SubastaController controller;
        private List<Postor> postores;
        private Postor? subastadorActual;

        public SubastaForm(SubastaController ctrl, List<Postor> listaPostores, Postor? subastador = null)
        {
            controller = ctrl;
            postores = listaPostores;
            subastadorActual = subastador;

            InitializeComponent();
            CargarSubastas();
            CargarSubastadorSiExiste();
        }
        private void CargarSubastadorSiExiste()
        {
            if (subastadorActual != null)
            {
                txtSubastador.Text = $"{subastadorActual.Nombre} {subastadorActual.Apellido}";
                txtSubastador.ReadOnly = true;
                MessageBox.Show($"Subastador recibido: {txtSubastador.Text}");
            }
        }

        private void CargarSubastas()
        {
            listBoxSubastas.Items.Clear();
            foreach (var s in controller.ObtenerSubastas())
            {
                listBoxSubastas.Items.Add(s);
            }
            lblGanadorActual.Text = "Ganador actual: -";
            comboPostores.Items.Clear();
        }
        private void btnNuevaSubasta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubastador.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del subastador antes de crear una subasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtArticulo.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del artículo para la subasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nuevoId = controller.ObtenerNuevoId();

            var s = new Subasta(
                nuevoId,
                txtArticulo.Text.Trim(),
                txtSubastador.Text.Trim(),
                numericPujaInicial.Value,
                numericPujaAumento.Value,
                TimeSpan.FromMinutes((double)numericDuracion.Value)
            );

            controller.AgregarSubasta(s);

            CargarSubastas();

            txtArticulo.Clear();
        }
        private void listBoxSubastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPostores.Items.Clear();
            lblGanadorActual.Text = "Ganador actual: -";

            if (listBoxSubastas.SelectedItem is Subasta s)
            {
                if (s.Postores != null)
                {
                    foreach (var p in s.Postores)
                        comboPostores.Items.Add(p);
                }

                var pujaActual = s.ObtenerPujaActual();
                var ganador = s.ObtenerPostorGanador();

                if (ganador != null)
                {
                    lblGanadorActual.Text = $"Ganador actual: {ganador.Nombre} {ganador.Apellido} - ${pujaActual:0.00}";
                }
            }
        }
        private void btnGestionPostores_Click(object sender, EventArgs e)
        {
            if (listBoxSubastas.SelectedItem is Subasta s)
            {
                new GestionPostoresForm(s).ShowDialog();
                // Después de gestionar postores, refrescamos lista y combo
                listBoxSubastas_SelectedIndexChanged(null, null);
            }
        }
        private void btnRegistrarPuja_Click(object sender, EventArgs e)
        {
            if (listBoxSubastas.SelectedItem is Subasta s &&
                comboPostores.SelectedItem is Postor p)
            {
                try
                {
                    controller.RegistrarPuja(s, p, numericMonto.Value);
                    MessageBox.Show("Puja registrada correctamente.");
                    // Actualizamos la etiqueta ganador después de registrar la puja
                    listBoxSubastas_SelectedIndexChanged(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar puja: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una subasta y un postor válidos.");
            }
        }
        private void numericPujaInicial_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtSubastador_TextChanged(object sender, EventArgs e)
        {

        }
        private void numericPujaAumento_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericDuracion_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
