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

        public Tarea obtenerTarea(int id)
        {
            Tarea tarea = (from t in db.Tarea
                          where t.id == id
                          select t).FirstOrDefault();
            return tarea;
        }

        public List<Tarea> obtenerListaTarea()
        {
            List<Tarea> listaTarea = (from t in db.Tarea
                                      select t).ToList();
            return listaTarea;
        }

        public List<Tarea> obtenerListaTarea(int idZona) {
            List<Tarea> listaTarea = (from t in db.Tarea
                                      where idZona == t.FK_ZonaId
                                      select t).ToList();
            return listaTarea;
        }

        public int addTarea(Tarea t)
        {
            db.Tarea.Add(t);
            db.SaveChanges();
            return t.id;
        }

        public bool borrarTarea(int id)
        {
            Tarea tarea = (from t in db.Tarea
                       where t.id == id
                       select t).FirstOrDefault();

            if (tarea != null)
            {
                db.Tarea.Remove(tarea);
                return true;
            }
            return false;

        }

    }
}
