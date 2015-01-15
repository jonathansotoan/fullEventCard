using apps.hardvin.buscotas.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apps.FullEventCard.Negocio
{
    public class UsuarioHelper
    {
        public DataTable Login(string user, string password)
        {
            bool response = false;
            Conexion con = new Conexion();
            Guid iduser = Guid.NewGuid();
            SqlParameter[] nombre = new SqlParameter[3];
            nombre[0] = new SqlParameter("@idusuario", user);
            nombre[1] = new SqlParameter("@contra", password);
            nombre[2] = new SqlParameter("@token", iduser.ToString());

            DataTable dt = con.fn_Consultar("zsp_loginusuario", nombre);
            return dt;
        }

        public object Checkin(string user, string token)
        {
            Conexion con = new Conexion();
            SqlParameter[] nombre = new SqlParameter[2];
            nombre[0] = new SqlParameter("@idusuario", user);
            nombre[1] = new SqlParameter("@token", token);

            DataTable dt = con.fn_Consultar("spz_checkinusuario", nombre);

            return dt.Rows;
        }

        public void registrarUsuario(string nombres, string correo,string contra)
        {
            Conexion con = new Conexion();
            SqlParameter[] nombre = new SqlParameter[4];
            nombre[0] = new SqlParameter("@Nombres", nombres);
            nombre[1] = new SqlParameter("@Correo", correo);
            nombre[2] = new SqlParameter("@Token", Guid.NewGuid().ToString());
            nombre[3] = new SqlParameter("@Contra", contra);

            DataTable dt = con.fn_Consultar("zsp_registrousuario", nombre);
        }
    }

}
