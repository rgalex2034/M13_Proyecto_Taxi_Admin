using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M13_ProyectoTaxi.Model.Services;

namespace M13_ProyectoTaxi.Forms.Tareas
{
    public partial class NewTareaForm : BasicForm
    {
        public NewTareaForm()
        {
            InitializeComponent();
            cmbxZona.DataSource = ServicioZona.obtenerListaNombres();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idTarea = ServicioTarea.addTarea(txbTelefono.Text, txbNombre.Text, txbDireccion.Text, cmbxZona.SelectedValue.ToString());

            if (idTarea > 0)
            {
                MessageBox.Show("Tarea añadida correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha surgido algún error...");
            }

        }
    }
}
