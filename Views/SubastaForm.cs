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

        public SubastaForm(SubastaController ctrl, List<Postor> listaPostores)
        {
            controller = ctrl;
            postores = listaPostores;
            InitializeComponent();
            CargarSubastas();
        }

        private void CargarSubastas()
        {
            listBoxSubastas.Items.Clear();
            foreach (var s in controller.ObtenerSubastas())
            {
                listBoxSubastas.Items.Add(s);
            }
        }

        private void btnNuevaSubasta_Click(object sender, EventArgs e)
        {
            Subasta s = new Subasta
            {
                NombreSubastador = txtSubastador.Text,
                Articulo = txtArticulo.Text,
                Pujainicial = numericPujaInicial.Value,
                PujadeAumento = numericPujaAumento.Value,
                Fecha = dateTimePickerFecha.Value,
                Duracion = TimeSpan.FromMinutes((double)numericDuracion.Value)
            };
            controller.AgregarSubasta(s);
            CargarSubastas();
        }

        private void listBoxSubastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSubastas.SelectedItem is Subasta s)
            {
                comboPostores.Items.Clear();
                foreach (var p in s.Postores)
                    comboPostores.Items.Add(p);
            }
        }

        private void btnGestionPostores_Click(object sender, EventArgs e)
        {
            if (listBoxSubastas.SelectedItem is Subasta s)
            {
                new GestionPostoresForm(s).ShowDialog();
                listBoxSubastas_SelectedIndexChanged(null, null);
            }
        }

        private void btnRegistrarPuja_Click(object sender, EventArgs e)
        {
            if (listBoxSubastas.SelectedItem is Subasta s &&
                comboPostores.SelectedItem is Postor p)
            {
                controller.RegistrarPuja(s, p, numericMonto.Value);
            }
        }
    }
}
