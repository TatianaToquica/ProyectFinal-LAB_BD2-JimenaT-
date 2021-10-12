using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace ProyectFinal_BancoSucursal.Datos
{
    class DatosSql
    {
        //Establezco la cadena de conexión a oracle.
        OracleConnection ora_conn = new OracleConnection(@"Data Source=localhost; User ID=examen1; Password=oracle");

        public string EliminarSucursal(int cod)
        {
            string resultado = "Fallo eliminar sucursal";
            try
            {
                //abrimos la conexion
                ora_conn.Open();
                /*se crea comando que recibe el nombre del procedimiento almacenado
                * y el nombre de la conexion donde esta dicho procedimiento */
                OracleCommand ora_cmd = new OracleCommand("examen1.EliminarSucursal", ora_conn);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                //indico cuales son los parametros que recibe el procedimiento y de que tipo
                ora_cmd.Parameters.Add("v_idSucursal", OracleDbType.Int16, cod, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_mensaje", OracleDbType.Varchar2, 60).Direction = ParameterDirection.Output;
                //ejecuto el procedimiento almacenado
                ora_cmd.ExecuteNonQuery();
                resultado = ora_cmd.Parameters["v_mensaje"].Value.ToString();
                return resultado;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
                return resultado;
            }
            finally
            {
                if (ora_conn.State == ConnectionState.Open)
                {
                    ora_conn.Close();
                }
            }
        }
        public string RegistrarBanco(int nit, string nombre, string fecha)
        {
            string resultado = "Fallo registar el Banco";
            try
            {
                //abrimos la conexion
                ora_conn.Open();
                /*se crea comando que recibe el nombre del procedimiento almacenado
                * y el nombre de la conexion donde esta dicho procedimiento */
                OracleCommand ora_cmd = new OracleCommand("examen1.IngresarBanco", ora_conn);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                //indico cuales son los parametros que recibe el procedimiento y de que tipo
                ora_cmd.Parameters.Add("v_idBanco", OracleDbType.Int16, nit, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_nomBanco", OracleDbType.Varchar2, 30, nombre, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_fechaBanco", OracleDbType.Date, fecha, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_mensaje", OracleDbType.Varchar2, 60).Direction = ParameterDirection.Output;
                //ejecuto el procedimiento almacenado
                ora_cmd.ExecuteNonQuery();
                resultado = ora_cmd.Parameters["v_mensaje"].Value.ToString();
                return resultado;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
                return resultado;
            }
            finally
            {
                if (ora_conn.State == ConnectionState.Open)
                {
                    ora_conn.Close();
                }
            }
        }
        public string RegistrarSucursal(int cod, string nombre, string ubicacion, int nEmp, int anios, int nitBanco)
        {
            string resultado = "Fallo registar el Sucursal";
            try
            {
                //abrimos la conexion
                ora_conn.Open();
                /*se crea comando que recibe el nombre del procedimiento almacenado
                * y el nombre de la conexion donde esta dicho procedimiento */
                OracleCommand ora_cmd = new OracleCommand("examen1.IngresarSucursal", ora_conn);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                //indico cuales son los parametros que recibe el procedimiento y de que tipo
                ora_cmd.Parameters.Add("v_idSucursal", OracleDbType.Int16, cod, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_nomSucursal", OracleDbType.Varchar2, 50, nombre, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_ubicaSucursal", OracleDbType.Varchar2, 6, ubicacion, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_nEmpSucursal", OracleDbType.Int16, nEmp, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_aniosSucursal", OracleDbType.Int16, anios, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_idBanco", OracleDbType.Int16, nitBanco, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_mensaje", OracleDbType.Varchar2, 60).Direction = ParameterDirection.Output;
                //ejecuto el procedimiento almacenado
                ora_cmd.ExecuteNonQuery();
                resultado = ora_cmd.Parameters["v_mensaje"].Value.ToString();
                return resultado;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
                return resultado;
            }
            finally
            {
                if (ora_conn.State == ConnectionState.Open)
                {
                    ora_conn.Close();
                }
            }
        }
        public  DataSet ConsultarSucursales(int nit)
        {
            string resultado = "Fallo registar el Banco";
            try
            {
                //abrimos la conexion
                ora_conn.Open();
                /*se crea comando que recibe el nombre del procedimiento almacenado
                * y el nombre de la conexion donde esta dicho procedimiento */
                OracleCommand ora_cmd = new OracleCommand("examen1.ConsultarSucursal", ora_conn);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                //indico cuales son los parametros que recibe el procedimiento y de que tipo
                ora_cmd.Parameters.Add("v_idBanco", OracleDbType.Int16, nit, ParameterDirection.Input);
                ora_cmd.Parameters.Add("cur_Sucursales", OracleDbType.RefCursor, ParameterDirection.Output);
                ora_cmd.Parameters.Add("v_mensaje", OracleDbType.Varchar2, 60).Direction = ParameterDirection.Output;
                //un OracleDataAdapter permite llenar un dataset
                OracleDataAdapter da = new OracleDataAdapter(ora_cmd);
                DataSet ds = new DataSet();                
                da.Fill(ds, "Sucursales");
                
                resultado = ora_cmd.Parameters["v_mensaje"].Value.ToString();
                MessageBox.Show(resultado);
                            
                return ds;
            }
            finally
            {
                if (ora_conn.State==ConnectionState.Open)
                {
                    ora_conn.Close();
                }                
            }
        }
    }
}
