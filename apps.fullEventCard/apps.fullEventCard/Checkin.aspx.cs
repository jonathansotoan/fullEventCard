using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace apps.fullEventCard
{
    public partial class Checkin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["iduser"] != null)
            {
                string iduser = Request.QueryString["iduser"].ToString().ToLower();

                lblBienvenida.Text = "<h2>UPPS!! No estás registrado a este evento</h2>";

                if (iduser == "hardvin@gmail.com")
                {
                    lblBienvenida.Text = "<h2>Bienvenido Marvin</h2>";
                }
                if (iduser == "juan@yahoo.com")
                {
                    lblBienvenida.Text = "<h2>Bienvenido Juan Correa</h2>";
                }
                if (iduser == "juan@gmail.com")
                {
                    lblBienvenida.Text = "<h2>Juan, No estás inscrito a este evento!!</h2>";
                }
            }
        }
    }
}