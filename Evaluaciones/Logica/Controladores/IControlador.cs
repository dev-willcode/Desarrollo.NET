using System.Collections.Generic;

namespace Logica.Controladores
{
    internal interface IControlador<T>
    {
        bool Insertar(T entidad);
        T Obtener(int id);
        bool Actualizar(T entidad);
        bool Eliminar(int id);
        List<T> Listar();
    }
}
