using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;

namespace Datos.Seguridad
{
    public class UsuarioCD
    {
        public static Usuario IniciarSesion(string user, string pwd)
        {
            BDMarketDataContext DB = null;
            try
            {
                using (DB = new BDMarketDataContext())
                {
                    SP_IniciarSesionResult aux = DB.SP_IniciarSesion(user, pwd).ToList()[0];
                    return new Usuario(
                        aux.IdeUsuario,
                        aux.EstadoUsuario,
                        aux.IdePerfil.GetValueOrDefault(),
                        aux.NombreUsuario,
                        aux.Clave);
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar Producto.", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
