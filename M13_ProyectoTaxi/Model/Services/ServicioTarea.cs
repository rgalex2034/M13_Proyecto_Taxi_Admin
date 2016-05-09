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
    }
}
