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

            //Mover foco con enter
            txtDni.KeyDown += Control_KeyDown;
            txtNombre.KeyDown += Control_KeyDown;
            txtApellido.KeyDown += Control_KeyDown;
            txtEmail.KeyDown += Control_KeyDown;

            CargarPostores();
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
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Debe ingresar nombre, apellido e email");
                return;
            }

            Postor p = new Postor(dni, nombre, apellido, email);
            subasta.Postores.Add(p);
            CargarPostores();

            // Limpiar campos
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPostores.CurrentRow != null &&
                dataGridViewPostores.CurrentRow.DataBoundItem is Postor p)
            {
                subasta.Postores.Remove(p);
                CargarPostores();
            }
            else
            {
                MessageBox.Show("Seleccione un postor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewPostores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewPostores.Rows.Count)
            {
                return; 
            }

            var postor = dataGridViewPostores.Rows[e.RowIndex].DataBoundItem as Postor;
            if (postor != null)
            {
                txtDni.Text = postor.Dni.ToString();
                txtNombre.Text = postor.Nombre;
                txtApellido.Text = postor.Apellido;
                txtEmail.Text = postor.Email;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
