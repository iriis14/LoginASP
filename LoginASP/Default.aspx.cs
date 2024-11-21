using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginASP
{
    public partial class _Default : Page
    {
        // La lista de usuarios autorizados
        private Dictionary<string, string> authorizedUsers = new Dictionary<string, string>()
        {
            { "admin", "password123" },
            { "user", "userpass" },
            { "pepito", "pepito1234" }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                lblMessage.Text = "Bienvenido de nuevo, " + Session["Username"];
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
        }

        protected void butEnter_Click(object sender, EventArgs e)
        {
            // Recuperar las credenciales ingresadas
            string username = txtBoxUserName.Text;
            string password = txtBoxPassword.Text;

            // Verificar si el usuario está autorizado
            if (authorizedUsers.ContainsKey(username) && authorizedUsers[username] == password)
            {
                // Guardar su nombre en la sesión
                Session["Username"] = username;

                // Mostrar mensaje en el label local
                lblMessage.Text = "Bienvenido, " + username + "!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                
                // Actualizar el saludo en la MasterPage
                var masterLabel = Master.FindControl("lblMasterGreeting") as Label;
                if (masterLabel != null)
                {
                    masterLabel.Text = "Hola, " + username;
                }
            }
            else
            {
                // Mostrar mensaje de error
                lblMessage.Text = "Usuario o contraseña incorrectos.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}