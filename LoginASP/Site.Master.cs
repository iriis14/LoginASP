using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginASP
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Si el usuario ha iniciado sesión, mostrar su nombre en la barra superior
            if (Session["Username"] != null)
            {
                lblMasterGreeting.Text = "Hola, " + Session["Username"];
            }
        }
    }
}