using System.Collections.Generic;

namespace Datos.AccesoDatos
{
    internal interface IAccesoDatos<T>
    {
        bool Insertar(T entidad);
        T Obtener(int id);
        bool Actualizar(T entidad);
        bool Eliminar(int id);
        List<T> Listar();
    }
}
