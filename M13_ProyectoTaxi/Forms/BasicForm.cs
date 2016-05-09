using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M13_ProyectoTaxi.Forms
{
    public class BasicForm : Form
    {
        public BasicForm() : base()
        {
            this.FormClosed += new FormClosedEventHandler(checkApplicationClose);
        }

        public void checkApplicationClose(object sender, FormClosedEventArgs args)
        {
            bool close = true;

            FormCollection formList = Application.OpenForms;
            foreach(Form f in formList)
            {
                if(f.Visible == true)
                {
                    close = false;
                }
            }

            if(close == true)
            {
                Application.Exit();
            }
        }

    }
}
