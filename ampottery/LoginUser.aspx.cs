using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ampottery
{
    public partial class LoginUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null || (((dominio.Usuario)Session["usuario"]).TipoUsuario != dominio.TipoUsuario.NORMAL))
            {
                Session.Add("error", "Debes loguearte para ingresar");
                Response.Redirect("LoginError.aspx", false);
            }
        }
    }
}