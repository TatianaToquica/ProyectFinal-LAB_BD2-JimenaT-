using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectFinal_BancoSucursal.Datos;

namespace ProyectFinal_BancoSucursal.Logica
{
    class Sucursal
    {
        
        //creo un objeto de datos
        DatosSql dt = new DatosSql();

        public string EliminarSucursalBanco(int cod)
        {
            string respuesta = "";
            respuesta = dt.EliminarSucursal(cod);
            return respuesta;
        }
        public string RegistrarSucursalBanco(int cod, string nombre, string ubicacion, int nEmp, int anios, int nitBanco)
        {
            string respuesta = "";
            respuesta = dt.RegistrarSucursal(cod,nombre,ubicacion,nEmp,anios,nitBanco);
            return respuesta;
        }
        public DataSet ConsultarSucursalesBanco(int nit)
        {
            DataSet conjuntoSucursales = new DataSet();
            conjuntoSucursales = dt.ConsultarSucursales(nit);
            return conjuntoSucursales;
        }
    }
}
