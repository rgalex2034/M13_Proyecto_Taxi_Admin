using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M13_ProyectoTaxi.Model.EntityFramework;

namespace M13_ProyectoTaxi.Model.DAO
{
    class ZonaDAO
    {
        DBBTaxistesEntities db;

        public ZonaDAO()
        {
            db = new DBBTaxistesEntities();
        }

        public List<Zona> obtenerListaZonas()
        {
            List<Zona> listaZonas = (from z in db.Zona
                                     select z).ToList();

            return listaZonas;
        }

        public Zona obtenerZona(int id)
        {
            Zona zona = (from z in db.Zona
                         where z.id == id
                         select z).FirstOrDefault();
            return zona;
        }

        public Zona obtenerZonaPorNombre(string nombre)
        {
            Zona zona = (from z in db.Zona
                         where z.nombre.Equals(nombre)
                         select z).FirstOrDefault();
            return zona;
        }

        public bool eliminarZona(int id)
        {
            Zona zona = (from z in db.Zona
                         where z.id == id
                         select z).FirstOrDefault();

            if (zona != null)
            {
                //Buscamos si hay al menos una tarea con la zona a borrar asignada.
                Tarea tarea = (from t in db.Tarea
                               where t.FK_ZonaId == zona.id
                               select t).FirstOrDefault();
                if (tarea != null)
                {
                    db.Zona.Remove(zona);
                    return true;
                }
                else return false;
            }
            return false;
        }

        public bool eliminarZonaPorNombre(string nombre)
        {
            Zona zona = (from z in db.Zona
                         where z.nombre == nombre
                         select z).FirstOrDefault();
            if (zona != null)
            {
                return eliminarZona(zona.id);
            }
            return false;
        }

    }
}
