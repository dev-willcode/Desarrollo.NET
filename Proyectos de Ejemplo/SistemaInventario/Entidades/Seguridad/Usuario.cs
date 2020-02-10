using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Seguridad
{
    public class Usuario
    {
        public Usuario(int ideUsuario, string estadoUsuario, int idePerfil, string nombreUsuario, string clave)
        {
            IdeUsuario = ideUsuario;
            EstadoUsuario = estadoUsuario;
            IdePerfil = idePerfil;
            NombreUsuario = nombreUsuario;
            Clave = clave;
        }

        public int IdeUsuario { get; set; }
        public string EstadoUsuario { get; set; }
        public int IdePerfil { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
    }
}
