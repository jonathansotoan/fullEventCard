using apps.FullEventCard.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace apps.fullEventCard
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SigningUp(object sender, EventArgs e)
        {
            UsuarioHelper objushel = new UsuarioHelper();

            objushel.registrarUsuario(txtNombres.Text, txtCorreos.Text, txtContra.Text);
            Session["Nombre"] = txtNombres.Text;
            Session["id"] = txtCorreos.Text;

            Response.Redirect("listaEventos.aspx");
        }
    }
}