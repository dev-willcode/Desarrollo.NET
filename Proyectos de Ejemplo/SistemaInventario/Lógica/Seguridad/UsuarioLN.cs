using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using Datos.Seguridad;

namespace Lógica.Seguridad
{
    public class UsuarioLN
    {
        public Usuario IniciarSesion(string user, string pwd)
        {
            try
            {
                return UsuarioCD.IniciarSesion(user,pwd);
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al iniciarSesión.", ex);
            }
        }
    }
}
