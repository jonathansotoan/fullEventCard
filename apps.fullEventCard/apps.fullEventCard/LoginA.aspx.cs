using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using apps.FullEventCard.Negocio;


namespace apps.fullEventCard
{
    public partial class LoginA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioHelper helper = new UsuarioHelper();
            var validacion = helper.Login(tbUsuario.Text, tbPassword.Text);

            if (validacion.Rows.Count > 0)
            {
                Session["Nombre"] = validacion.Rows[0]["Nombres"].ToString();
                Session["id"] = validacion.Rows[0]["Correo"].ToString();


                if (Request.QueryString["movil"] != null)
                {
                    Response.Redirect("QrMovil.aspx");
                }
                else
                {
                    Response.Redirect("listaEventos.aspx");
                }

            }
            else
            {

            }
        }
    }
}