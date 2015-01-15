using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apps.hardvin.buscotas.conexion
{
    using System.Data;
    using System.Data.SqlClient;

    public class Conexion
    {
        private string cadenaconexion = System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ToString();
        //private string Conexion = "Server=grupocrm2013.no-ip.biz;Database=dbcusiana;User Id=sa; password=cerati0911*;";
        #region "Funciones de consulta"
        /// <summary>
        /// Funcion utilizada para realizar las consultar individual
        /// </summary>
        /// <param name="pprocedimiento">Nombre del procedimiento almacenado</param>
        /// <param name="pParametros">Vector con los parametros</param>
        /// <returns>Devuelve una tabla con los datos encontrados</returns>
        /// <remarks></remarks>
        public DataTable fn_Consultar(string pprocedimiento, SqlParameter[] Parametros)
        {
            SqlConnection oConexion = new SqlConnection();
            oConexion.ConnectionString = cadenaconexion;
            oConexion.Open();

            SqlCommand objcmd = new SqlCommand(pprocedimiento, oConexion);
            objcmd.CommandType = CommandType.StoredProcedure;
            //ciclo para manejar parametros
            foreach (object param in Parametros)
            {
                objcmd.Parameters.Add(new SqlParameter().Value = param);
            }
            DataTable DT = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(objcmd);
            DA.Fill(DT);
            oConexion.Close();
            return DT;
        }

        public DataTable fn_Consultar(string pprocedimiento)
        {
            SqlConnection oConexion = new SqlConnection();
            oConexion.ConnectionString = cadenaconexion;
            oConexion.Open();

            SqlCommand objcmd = new SqlCommand(pprocedimiento, oConexion);
            objcmd.CommandType = CommandType.StoredProcedure;
            DataTable DT = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(objcmd);
            DA.Fill(DT);
            oConexion.Close();
            return DT;
        }

        /// <summary>
        /// Funcion utilizada para realizar las consultar individual
        /// </summary>
        /// <param name="pprocedimiento">Nombre del procedimiento almacenado</param>
        /// <param name="pParametros">Vector con los parametros</param>
        /// <returns>Devuelve un Dataset con los datos encontrados</returns>
        /// <remarks></remarks>
        public DataSet fn_ConsultarDs(string pprocedimiento, SqlParameter[] Parametros)
        {
            SqlConnection oConexion = new SqlConnection();
            oConexion.ConnectionString = cadenaconexion;
            oConexion.Open();

            SqlCommand objcmd = new SqlCommand(pprocedimiento, oConexion);
            objcmd.CommandType = CommandType.StoredProcedure;
            //ciclo para manejar parametros
            foreach (object param in Parametros)
            {
                objcmd.Parameters.Add(new SqlParameter().Value = param);
            }
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(objcmd);
            DA.Fill(DS);
            oConexion.Close();
            return DS;
        }

        /// <summary>
        /// Funcion que se encarga de ejecutar un procedimiento almacenado.
        /// </summary>
        /// <param name="pprocedimiento">Procedimiento.</param>
        /// <param name="Parametros">Vector con parametros.</param>
        public void fn_Ejecutar(string pprocedimiento, SqlParameter[] Parametros)
        {
            SqlConnection oConexion = new SqlConnection();
            oConexion.ConnectionString = cadenaconexion;
            oConexion.Open();

            SqlCommand objcmd = new SqlCommand(pprocedimiento, oConexion);
            objcmd.CommandType = CommandType.StoredProcedure;
            //ciclo para manejar parametros
            foreach (object param in Parametros)
            {
                objcmd.Parameters.Add(new SqlParameter().Value = param);
            }
            objcmd.ExecuteNonQuery();
            oConexion.Close();
        }


        /// <summary>
        /// Funcion utilizada para realizar las consultar individual
        /// </summary>
        /// <param name="pprocedimiento">Nombre del procedimiento almacenado</param>
        /// <param name="pParametros">Vector con los parametros</param>
        /// <returns>Devuelve un Dataset con los datos encontrados</returns>
        /// <remarks></remarks>
        public DataSet fn_ConsultarDs(string pprocedimiento)
        {
            SqlConnection oConexion = new SqlConnection();
            oConexion.ConnectionString = cadenaconexion;
            oConexion.Open();

            SqlCommand objcmd = new SqlCommand(pprocedimiento, oConexion);
            objcmd.CommandType = CommandType.StoredProcedure;
            //ciclo para manejar parametros
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(objcmd);
            DA.Fill(DS);
            oConexion.Close();
            return DS;
        }

        /// <summary>
        /// Ejecuta un Procedimiento Almacenado
        /// y devuelve el valor de la primera columna primera fila o 'No encontrado'
        /// </summary>
        /// <param name="procedimiento">Nombre del Procedimiento Almacenado</param>
        /// <param name="parametros">Parametros enviados al Procedimiento Almacenado</param>
        /// <returns>primera columna primera fila o 'No encontrado'</returns>
        public object Escalar(string procedimiento, SqlParameter[] parametros)
        {
            SqlConnection oConexion = new SqlConnection();
            oConexion.ConnectionString = cadenaconexion;
            oConexion.Open();

            SqlCommand objcmd = new SqlCommand(procedimiento, oConexion);
            objcmd.CommandType = CommandType.StoredProcedure;
            //ciclo para manejar parametros
            if (parametros != null)
            {
                foreach (SqlParameter param in parametros)
                {
                    objcmd.Parameters.Add(param);
                }
            }
            object resultado = objcmd.ExecuteScalar();
            oConexion.Close();
            return resultado;
        }

        /// <summary>
        /// Ejecuta un Procedimiento Almacenado
        /// y devuelve el valor de la primera columna primera fila o 'No encontrado'
        /// </summary>
        /// <param name="procedimiento">Nombre del Procedimiento Almacenado</param>
        /// <param name="parametros">Parametros enviados al Procedimiento Almacenado</param>
        /// <returns>primera columna primera fila o 'No encontrado'</returns>
        public object EjecutarSQL(string Consulta)
        {
            SqlConnection oConexion = new SqlConnection();
            oConexion.ConnectionString = cadenaconexion;
            oConexion.Open();

            SqlCommand objcmd = new SqlCommand(Consulta, oConexion);
            objcmd.CommandType = CommandType.Text;
            //ciclo para manejar parametros
            object resultado = objcmd.ExecuteScalar();
            oConexion.Close();
            return resultado;
        }

        public object Escalar(string procedimiento)
        {
            SqlConnection oConexion = new SqlConnection();
            oConexion.ConnectionString = cadenaconexion;
            oConexion.Open();

            SqlCommand objcmd = new SqlCommand(procedimiento, oConexion);
            objcmd.CommandType = CommandType.StoredProcedure;
            //ciclo para manejar parametros
            object resultado = objcmd.ExecuteScalar();
            oConexion.Close();
            return resultado;
        }
        /// <summary>
        /// Ejecuta un Procedimiento Almacenado
        /// y devuelve el valor de la primera columna primera fila o 'No encontrado'
        /// </summary>
        /// <param name="procedimiento">Nombre del Procedimiento Almacenado</param>
        /// <param name="parametros">Parametros enviados al Procedimiento Almacenado</param>
        /// <returns>primera columna primera fila o 'No encontrado'</returns>
        public IDataReader DataReader(string procedimiento, params object[] parametros)
        {
            SqlConnection oConexion = new SqlConnection();
            oConexion.ConnectionString = cadenaconexion;
            oConexion.Open();

            SqlCommand objcmd = new SqlCommand(procedimiento, oConexion);
            objcmd.CommandType = CommandType.StoredProcedure;
            //ciclo para manejar parametros
            if (parametros != null)
            {
                foreach (object param in parametros)
                {
                    objcmd.Parameters.Add(new SqlParameter().Value = param);
                }
            }
            IDataReader resultado = objcmd.ExecuteReader();
            return resultado;
        }
        #endregion
    }
}
