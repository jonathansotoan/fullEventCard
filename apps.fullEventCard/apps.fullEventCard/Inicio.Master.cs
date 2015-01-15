using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace apps.fullEventCard
{
    public partial class Inicio : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Nombre"] != null)
            {
                lblNombre.Text = Session["Nombre"].ToString();
            }
        }
    }
}