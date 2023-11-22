using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Habitacion
    {
        private int nroHabitacion;
        private int huespedId;
        private bool estaOcupada;
        private bool estaReservada;
        private string tipoHabitacion;

        public int NroHabitacion { get; set; }
        public int HuespedId { get; set; }
        public bool EstaOcupada { get; set ; }
        public bool EstaReservada { get ; set; }
        public string TipoHabitacion { get ; set ; }
    }
}
