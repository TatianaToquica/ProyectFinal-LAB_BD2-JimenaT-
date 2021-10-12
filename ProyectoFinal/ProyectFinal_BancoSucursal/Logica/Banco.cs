using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectFinal_BancoSucursal.Datos;

namespace ProyectFinal_BancoSucursal.Logica
{
    class Banco
    {
        //creo un objeto de datos
        DatosSql dt = new DatosSql();

        public string RegistrarBanco(int nit, string nombre, string fecha)
        {
            string respuesta = "";
            respuesta = dt.RegistrarBanco(nit,nombre,fecha);
            return respuesta;
        }
    }
}
