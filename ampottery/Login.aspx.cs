using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;
using accesoDatos;

namespace ampottery
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            usuarioNegocio negocio = new usuarioNegocio();

            try
            {
                usuario = new Usuario(txtUsuario.Text, txtPass.Text, false);
                if (negocio.Loguear(usuario))
                {
                    Session.Add("usuario", usuario);
                    if (((dominio.Usuario)Session["usuario"]).TipoUsuario == dominio.TipoUsuario.ADMIN)
                    {
                        Response.Redirect("LoginAdmin.aspx");
                    }
                    else
                    {
                        Response.Redirect("LoginUser.aspx");
                    }
                }
                else
                {
                    Session.Add("error", "Usuario o contraseña incorretos");
                    Response.Redirect("LoginError.aspx", false); 
                }


            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
            }
        }
    }
}