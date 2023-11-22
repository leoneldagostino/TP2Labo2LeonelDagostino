using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IRepository<T>
    {
        T ObtenerPorId(int id);
        List<T> ObtenerTodos();
        void Agregar(T registro);
        void Actualizar(T registro);
        void Eliminar(int id);
        
    }
}
