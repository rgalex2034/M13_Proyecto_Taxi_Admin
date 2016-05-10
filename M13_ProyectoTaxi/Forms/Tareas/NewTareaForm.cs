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
using M13_ProyectoTaxi.Model.EntityFramework;

namespace M13_ProyectoTaxi.Forms.Tareas
{
    public partial class NewTareaForm : BasicForm
    {

        private Tarea tarea;

        public NewTareaForm()
        {
            InitializeComponent();
            cmbxZona.DataSource = ServicioZona.obtenerListaNombres();
            tarea = null;
        }
        public NewTareaForm(Tarea t)
        {
            InitializeComponent();
            cmbxZona.DataSource = ServicioZona.obtenerListaNombres();
            this.tarea = t;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tarea == null)
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
            else {
                Tarea t = new Tarea();
                t.direccion = txbDireccion.Text;
                t.nombre = txbNombre.Text;
                t.telefono = txbTelefono.Text;
                Zona z = ServicioZona.obtenerZonaPorNombre(cmbxZona.SelectedValue.ToString());
                t.FK_ZonaId = z.id;

                if(ServicioTarea.actualizarTarea(tarea.id, t))
                {
                    MessageBox.Show("Tarea modificada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha surgido algún error...");
                }
            }


        }

        private void NewTareaForm_Load(object sender, EventArgs e)
        {
            if (tarea != null)
            {
                this.txbDireccion.Text = tarea.direccion;
                this.txbNombre.Text = tarea.nombre;
                this.txbTelefono.Text = tarea.telefono;
                if (tarea.FK_ZonaId != null)
                {
                    Zona zonaDeTarea = ServicioZona.obtenerZona((int)tarea.FK_ZonaId);
                    foreach (var itemZona in cmbxZona.Items) {
                        if (itemZona.ToString().Equals(zonaDeTarea.nombre))
                        {
                            cmbxZona.SelectedItem = itemZona;
                            break;
                        }
                    }
                }

                this.btnAceptar.Text = "Actualizar";

            }
        }

    }
}
