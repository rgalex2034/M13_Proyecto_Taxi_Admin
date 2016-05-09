using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M13_ProyectoTaxi.Model.EntityFramework;
using M13_ProyectoTaxi.Model.DAO;

namespace M13_ProyectoTaxi.Model.Services
{
    class ServicioUsuario
    {
        /**
        * Metodo para iniciar sesion. Retorna usuario si es correcto.
        */
        public static Usuario iniciarSesion(string dni, string pass)
        {
            UsuarioDAO u = new UsuarioDAO();
            Usuario usuario=u.obtenerUsuarioPorDni(dni);
            if (usuario != null)
            {
                if (usuario.password == pass)
                {
                    return usuario;
                }
                else return null;
            }
            return null;
        }
    }
}
