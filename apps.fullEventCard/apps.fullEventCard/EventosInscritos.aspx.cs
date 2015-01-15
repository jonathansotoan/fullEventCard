using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace apps.fullEventCard
{
    public partial class EventosInscritos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            byte[] ids = new byte[] {1, 4, 6};
            string results = "";

            for (byte j = 0; j < ids.Length; ++j )
                results += "'<div class='col-md-6'>"
                             + "<div class='widget'>"
                                + "<div class='widget-header'>"
                                    + "<h3><i class='fa fa-globe'></i> Evento inscrito</h3>"
                                    + "<em>- A este evento te inscribiste hace 1 d&iacute;a</em>"
                                    + "<div class='btn-group widget-header-toolbar'>"
                                        + "<a href='#' title='Focus' class='btn-borderless btn-focus'><i class='fa fa-eye'></i></a>"
                                        + "<a href='#' title='Expand/Collapse' class='btn-borderless btn-toggle-expand'><i class='fa fa-chevron-up'></i></a>"
                                        + "<a href='#' title='Remove' class='btn-borderless btn-remove'><i class='fa fa-times'></i></a>"
                                    + "</div>"
                                + "</div>"
                                + "<div class='widget-content'>"
                                    + "<img src='Img/Evento" + ids[j] + ".jpg' class='img-responsive' />"
                                    + "<br /><a href='EventosInscritos.aspx'><span class='btn btn-lg btn-primary btn-block' style='background-color: #DC143C; border-color: #DC143C'>Cancelar registro</span></a>"
                                + "</div>"
                            + "</div>"
                        + "</div>";

            lblEventos.Text = results;
        }
    }
}