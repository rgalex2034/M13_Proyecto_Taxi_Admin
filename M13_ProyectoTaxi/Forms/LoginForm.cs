using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M13_ProyectoTaxi.Model.EntityFramework;
using M13_ProyectoTaxi.Model.Services;
using M13_ProyectoTaxi.Forms.Tareas;
using M13_ProyectoTaxi.Forms.Zonas;

namespace M13_ProyectoTaxi.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string pass = txbPass.Text;
            string dni = txbDni.Text;

            Usuario u = ServicioUsuario.iniciarSesion(dni, pass);

            if (u != null)
            {
                TareasForm tareasForm = new TareasForm();
                tareasForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error en el usuario o contraseña");
            }
        }
    }
}
