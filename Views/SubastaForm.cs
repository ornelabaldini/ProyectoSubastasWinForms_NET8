using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
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

            // Suscribir controles al evento KeyDown    
            txtArticulo.KeyDown += Control_KeyDown;
            txtSubastador.KeyDown += Control_KeyDown;
            numericPujaInicial.KeyDown += Control_KeyDown;
            numericPujaAumento.KeyDown += Control_KeyDown;
            numericDuracion.KeyDown += Control_KeyDown;


            CargarSubastas();
            CargarSubastadorSiExiste();
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Mover el foco al siguiente control
                this.SelectNextControl(
                    (Control)sender, // Control actual
                    true,            // buscar hacia adelante
                    true,            // saltar controles no tabulables
                    true,            // saltar controles hijos
                    true             // saltar controles invisibles
                );
            }
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
            var subastas = controller.ObtenerSubastas();
            Subastas.DataSource = null;
            Subastas.DataSource = subastas;

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

            s.Iniciar();

            controller.AgregarSubasta(s);

            CargarSubastas();

            txtArticulo.Clear();
        }
        private void listBoxSubastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPostores.Items.Clear();
            lblGanadorActual.Text = "Ganador actual: -";

            if (Subastas.SelectedItem is Subasta s)
            {
                if (s.Postores != null)
                {
                    foreach (var p in s.Postores)
                        comboPostores.Items.Add(p);
                }

                //Si hay postores, seleccionamos el primero por defecto
                if (comboPostores.Items.Count > 0)
                {
                    comboPostores.SelectedIndex = 0;
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
            if (Subastas.SelectedItem is Subasta s)
            {
                var gestionForm = new GestionPostoresForm(s);
                gestionForm.ShowDialog(); // ventana modal

                //Refrescar lista y mantener la subasta seleccionada
                RecargarListaSubastas(s);
            }
            else
            {
                MessageBox.Show("Seleccione una subasta primero.");
            }
        }
        private void RecargarListaSubastas(Subasta seleccionada)
        {
            if (Subastas == null) return;

            // Actualizar la lista usando DataSource para evitar problemas con Items
            var subastas = controller.ObtenerSubastas();

            Subastas.DataSource = null;        // Reiniciar DataSource
            Subastas.DataSource = subastas;    // Asignar lista actualizada

            // Mantener la selección de la subasta pasada como parámetro
            if (seleccionada != null)
            {
                // Buscar el objeto en la lista con el mismo Id
                var itemSeleccionado = subastas.FirstOrDefault(s => s.Id == seleccionada.Id);

                if (itemSeleccionado != null)
                {
                    Subastas.SelectedItem = itemSeleccionado;
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timer1.Stop();
            base.OnFormClosing(e);
        }

        private void btnRegistrarPuja_Click(object sender, EventArgs e)
        {
            if (Subastas.SelectedItem is Subasta s &&
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
        private void lblGanadorActual_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Guardar la subasta seleccionada actualmente
            var seleccionada = Subastas.SelectedItem as Subasta;

            // Recorrer todas las subastas
            foreach (var s in controller.ObtenerSubastas())
            {
                // Guardar estado anterior
                var estadoAnterior = s.Estado;

                // Actualizar estado según el tiempo actual
                s.ActualizarEstado(DateTime.Now);

                // Si acaba de finalizar ahora, mostrar cartel
                if (estadoAnterior == SubastaEstado.EnCurso && s.Estado == SubastaEstado.Finalizada)
                {
                    var pujaGanadora = s.OfertaGanadora;

                    if (pujaGanadora != null)
                    {
                        string nombreGanador = pujaGanadora.Postor?.Nombre ?? "Desconocido";
                        decimal monto = pujaGanadora.Monto;

                        string montoFormateado = monto.ToString("#,0.00")
                                                      .Replace(",", "@")
                                                      .Replace(".", ",")
                                                      .Replace("@", ".");

                        string mensaje = $"🏁 ¡Subasta finalizada!\n\n🏆 Ganador: {nombreGanador}\n💰 Monto: ${montoFormateado}";
                        MessageBox.Show(mensaje, "Resultado de la Subasta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"🛑 La subasta de '{s.Articulo}' ha finalizado sin pujas.", "Subasta finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            // Recargar la lista y restaurar selección
            RecargarListaSubastas(seleccionada);
        }

        private void lblGanadorActual_Click_1(object sender, EventArgs e)
        {

        }
        private void lblPujaActual_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
