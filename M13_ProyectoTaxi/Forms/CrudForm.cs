using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M13_ProyectoTaxi.Forms
{
    public abstract partial class CrudForm : BasicForm
    {
        public CrudForm()
        {
            InitializeComponent();
            refreshData();
        }

        protected abstract void refreshData();

        protected abstract void btnAddElement_Click(object sender, EventArgs e);

        protected abstract void btnUpdElement_Click(object sender, EventArgs e);

        protected abstract void btnDelElement_Click(object sender, EventArgs e);
    }
}
