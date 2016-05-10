using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M13_ProyectoTaxi.Model.DAO;
using M13_ProyectoTaxi.Model.EntityFramework;

namespace M13_ProyectoTaxi.Model.Services
{
    class ServicioZona
    {
        public static List<Zona> obtenerListaZonas()
        {
            ZonaDAO dao = new ZonaDAO();
            return dao.obtenerListaZonas();
        }

        public static List<string> obtenerListaNombres()
        {
            ZonaDAO dao = new ZonaDAO();
            List<Zona> listaZonas = dao.obtenerListaZonas();

            List<string> listaNombres = new List<string>();
            foreach(Zona z in listaZonas)
            {
                listaNombres.Add(z.nombre);
            }

            return listaNombres;
        }

        public static Zona obtenerZonaPorNombre(string nombre)
        {
            ZonaDAO dao = new ZonaDAO();
            Zona zona = dao.obtenerZonaPorNombre(nombre);
            return zona;
        }

    }
}
