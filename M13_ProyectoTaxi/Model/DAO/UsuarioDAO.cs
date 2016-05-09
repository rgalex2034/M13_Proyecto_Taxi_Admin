using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M13_ProyectoTaxi.Model.EntityFramework;

namespace M13_ProyectoTaxi.Model.DAO
{
    class UsuarioDAO
    {
        private DBBTaxistesEntities db;

        public UsuarioDAO()
        {
            this.db = new DBBTaxistesEntities();
        }

        /**
        * Obtener usuario a partir de la id
        */
        public Usuario obtenerUsuario(int id) {
            Usuario u = (from usu in db.Usuario
                        where usu.id == id
                        select usu).FirstOrDefault();

            return u;
        }
        /**
        * Obtener usuario a partir del DNI
        */
        public Usuario obtenerUsuarioPorDni(string dni) {
            Usuario u = (from usu in db.Usuario
                         where usu.dni.Equals(dni)
                         select usu).FirstOrDefault();
            return u;

        }

        

    }
}
