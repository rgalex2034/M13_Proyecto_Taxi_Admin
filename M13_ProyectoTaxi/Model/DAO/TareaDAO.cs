using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M13_ProyectoTaxi.Model.EntityFramework;

namespace M13_ProyectoTaxi.Model.DAO
{
    class TareaDAO
    {
        private DBBTaxistesEntities db;

        public TareaDAO()
        {
            db = new DBBTaxistesEntities();
        }

        /**
        * Obtiene una tarea de la bd a través de la id
        */
        public Tarea obtenerTarea(int id)
        {
            Tarea tarea = (from t in db.Tarea
                           where t.id == id
                           select t).FirstOrDefault();
            return tarea;
        }

        /**
        * obtiene una lista de todas las tareas
        */
        public List<Tarea> obtenerListaTarea()
        {
            List<Tarea> listaTarea = (from t in db.Tarea
                                      select t).ToList();
            return listaTarea;
        }

        /**
        *  obtiene lista de tareas a través de la id de zona
        */
        public List<Tarea> obtenerListaTarea(int idZona)
        {
            List<Tarea> listaTarea = (from t in db.Tarea
                                      where idZona == t.FK_ZonaId
                                      select t).ToList();
            return listaTarea;
        }

        /**
        * añade la tarea que se le pasa por parametro
        */
        public int addTarea(Tarea t)
        {
            db.Tarea.Add(t);
            db.SaveChanges();
            return t.id;
        }
        /**
        * borra una tarea a través de su id 
        * retorna true si existe la tarea de lo contrario false
        */
        public bool borrarTarea(int id)
        {
            Tarea tarea = (from t in db.Tarea
                           where t.id == id
                           select t).FirstOrDefault();

            if (tarea != null)
            {
                db.Tarea.Remove(tarea);
                db.SaveChanges();
                return true;
            }
            return false;

        }

        /**
        * guardar cambios
        */
        public void guardarCambios() {
            db.SaveChanges();
        }
    }
}
