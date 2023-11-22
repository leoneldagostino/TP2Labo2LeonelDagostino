using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CapacidadCompletaException : Exception
    {
        public CapacidadCompletaException(string? message) : base(message)
        {
        }
    }
}
