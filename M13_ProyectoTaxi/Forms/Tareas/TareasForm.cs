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
    public partial class TareasForm : CrudForm
    {
        public TareasForm()
        {
            InitializeComponent();
        }

        protected override void refreshData()
        {
            dgvInfo.DataSource = ServicioTarea.obtenerListaTareas();
        }

        protected override void btnAddElement_Click(object sender, EventArgs e)
        {
            TareaEditForm newTareaForm = new TareaEditForm();
            newTareaForm.FormClosed += NewTareaClosed;
            newTareaForm.ShowDialog();
        }

        private void NewTareaClosed(object sender, FormClosedEventArgs e)
        {
            this.refreshData();
        }

        protected override void btnDelElement_Click(object sender, EventArgs e)
        {
            string err = "";
            foreach (DataGridViewRow row in dgvInfo.SelectedRows)
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

            refreshData();

        }

        protected override void btnUpdElement_Click(object sender, EventArgs e)
        {
            if (dgvInfo.SelectedRows.Count == 1)
            {
                int idTarea = -1;
                foreach(DataGridViewRow row in dgvInfo.SelectedRows)
                {
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        idTarea = (int)cell.Value;
                        break;
                    }
                }
                Tarea t = ServicioTarea.obtenerTarea(idTarea);

                TareaEditForm updForm = new TareaEditForm(t);
                updForm.FormClosed += NewTareaClosed;
                updForm.ShowDialog();

            }
        }
    }
}
