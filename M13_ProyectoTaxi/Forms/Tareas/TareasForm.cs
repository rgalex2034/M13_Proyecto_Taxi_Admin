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

    }
}
