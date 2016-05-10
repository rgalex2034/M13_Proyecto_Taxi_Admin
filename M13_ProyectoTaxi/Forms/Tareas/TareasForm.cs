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
    public partial class TareasForm : BasicForm
    {
        public TareasForm()
        {
            InitializeComponent();
            refreshTareas();
        }

        private void refreshTareas()
        {
            dgvTarea.DataSource = ServicioTarea.obtenerListaTareas();
        }

        private void btnAddTarea_Click(object sender, EventArgs e)
        {
            NewTareaForm newTareaForm = new NewTareaForm();
            newTareaForm.FormClosed += NewTareaClosed;
            newTareaForm.ShowDialog();
        }

        private void NewTareaClosed(object sender, FormClosedEventArgs e)
        {
            this.refreshTareas();
        }

        private void btnDelTarea_Click(object sender, EventArgs e)
        {
            string err = "";
            foreach (DataGridViewRow row in dgvTarea.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!ServicioTarea.borrarTarea((int)cell.Value))
                    {
                        err += cell.Value + ", ";
                    }
                    break;
                }
            }

            if (!err.Equals(""))
            {
                MessageBox.Show("Error borando tareas:\nIDs: " + err);
            }

            refreshTareas();

        }
    }
}
