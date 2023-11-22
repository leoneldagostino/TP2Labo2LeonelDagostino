namespace Entidades.Modelos
{
    public class Huesped 
    {
        private int dni;
        private string nombre;
        private string apellido;
        private int telefono;
        private string fechaIngreso;
        private string fechaEgreso;

     

        public string FechaIngreso { get; set ; }
        public string FechaEgreso { get ; set ; }
        public int Dni { get; set ; }
        public string Nombre { get; set ; }
        public string Apellido { get; set ; }
        public int Telefono { get; set; }
    }


}