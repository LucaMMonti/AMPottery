using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using accesoDatos;

namespace negocio
{
    public class usuarioNegocio
    {
        public bool Loguear(Usuario usuario)
        {
           AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Id, TipoUser FROM Usuarios Where [User]=@User AND [Contra]=@Password");
                datos.setearParametro("@User", usuario.User);
                datos.setearParametro("@Password", usuario.Password);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.TipoUsuario = (int)(datos.Lector["TipoUser"]) == 2 ? TipoUsuario.ADMIN : TipoUsuario.NORMAL;
                    return true;
                }
                return false;
            }   

            catch (Exception ex) 
            {
                
                throw ex;
                
            }
            finally
            {
                datos.cerrarConexion(); 
            }
        }   
        
            
    }
}
