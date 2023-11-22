using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetodosDeExtension
{
    public static class MisMetodosDeExtension
    {
        /// <summary>
        /// Obtiene el nombre completo del huésped concatenando el nombre y el apellido.
        /// </summary>
        /// <param name="huesped">Instancia de la clase Huesped.</param>
        /// <returns>Nombre completo del huésped.</returns>
        public static string NombreCompleto(this Huesped huesped)
        {
            return $"{huesped.Nombre} {huesped.Apellido}";
        }
        /// <summary>
        /// Obtiene el nombre completo del empleado concatenando el nombre y el apellido.
        /// </summary>
        /// <param name="empleado">Instancia de la clase Empleado.</param>
        /// <returns>Nombre completo del empleado.</returns>
        public static string NombreCompleto(this Empleado empleado)
        {
            return $"{empleado.Nombre} {empleado.Apellido}";
        }

    }
}
