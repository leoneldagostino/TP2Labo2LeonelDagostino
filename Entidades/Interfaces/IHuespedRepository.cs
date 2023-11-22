using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelos;

namespace Entidades.Interfaces
{
    public interface IHuespedRepository : IRepository<Huesped>
    {
        public Huesped BuscarPorDniHuesped(int dni);

       
    }
}
