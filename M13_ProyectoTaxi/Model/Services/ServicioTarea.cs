using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M13_ProyectoTaxi.Model.EntityFramework;
using M13_ProyectoTaxi.Model.DAO;

namespace M13_ProyectoTaxi.Model.Services
{
    class ServicioTarea
    {
        public static List<Tarea> obtenerListaTareas()
        {
            TareaDAO dao = new TareaDAO();
            return dao.obtenerListaTarea();
        }

        public static int addTarea(Tarea t)
        {
            TareaDAO dao = new TareaDAO();
            dao.addTarea(t);
            return t.id;
        }

        public static int addTarea(string telefono, string nombre, string direccion, string nombreZona)
        {
            ZonaDAO zonaDao = new ZonaDAO();
            TareaDAO tareaDAO = new TareaDAO();

            Zona z = zonaDao.obtenerZonaPorNombre(nombreZona);
            Tarea t = new Tarea();
            t.nombre = nombre;
            t.telefono = telefono;
            t.direccion = direccion;
            t.FK_ZonaId = z.id;

            tareaDAO.addTarea(t);
            return t.id;
        }

        public static bool borrarTarea(int id)
        {
            TareaDAO dao = new TareaDAO();
            return dao.borrarTarea(id);
        }

    }
}
