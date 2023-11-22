using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Empleado 
    {
        private string nombre;
        private string apellido;
        private string puesto;
        private string usuario;
        private string contraseña;

        
       
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto { get; set; }



    }

}
