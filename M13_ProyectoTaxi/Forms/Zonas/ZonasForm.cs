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

namespace M13_ProyectoTaxi.Forms.Zonas
{
    public partial class ZonasForm : CrudForm
    {
        public ZonasForm()
        {
            InitializeComponent();
        }

        protected override void refreshData()
        {
            this.dgvInfo.DataSource = ServicioZona.obtenerListaZonas();
        }

        protected override void btnAddElement_Click(object sender, EventArgs e)
        {

        }

        protected override void btnUpdElement_Click(object sender, EventArgs e)
        {

        }

        protected override void btnDelElement_Click(object sender, EventArgs e)
        {
            string err = "";
            foreach (DataGridViewRow row in dgvInfo.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!ServicioZona.borrarZona((int)cell.Value))
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

    }
}
