using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using apps.FullEventCard.Negocio;

namespace apps.fullEventCard
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("loginA.aspx");
        }
        
        protected void btnIniciarSesion_Click1(object sender, EventArgs e)
        {
            UsuarioHelper helper = new UsuarioHelper();
            var validacion = helper.Login(tbUsuario.Text, tbPassword.Text);

            if (validacion.Rows.Count > 0)
            {
                Response.Redirect("listaEventos.aspx");
            }
        }
    }
}