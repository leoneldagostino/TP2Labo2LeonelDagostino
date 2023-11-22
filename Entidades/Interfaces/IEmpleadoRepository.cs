using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IEmpleadoRepository<T>
    {
        public bool validarUsuarioContraseña(string usuario, string contraseña);

        public List<T> ObtenerEmpleado();
    }
}
