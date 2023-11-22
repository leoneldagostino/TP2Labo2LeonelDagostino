using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Repositorio
{
    public class EmpleadoRepository : IEmpleadoRepository<Empleado>
    {
        private static string stringConnection;

        static EmpleadoRepository()
        {
            stringConnection = "Server=.;Database=dbHotel;Trusted_Connection=True;";
        }

        /// <summary>
        /// Valida el usuario y la contraseña del empleado.
        /// </summary>
        /// <param name="usuario">Nombre de usuario del empleado.</param>
        /// <param name="contraseña">Contraseña del empleado.</param>
        /// <returns>Devuelve true si el usuario y la contraseña son validos, sino lanza una excepción.</returns>
        public bool validarUsuarioContraseña(string usuario, string contraseña)
        {
            List<Empleado> listaEmpleados = ObtenerEmpleado();

            foreach (Empleado empleado in listaEmpleados) 
            {
                if(usuario == empleado.Usuario)
                {
                    if(contraseña == empleado.Contraseña)
                    {
                        return true;
                    }
                    else
                    {
                        throw new ContraseñaInvalidaException("La contraseña es incorrecta");
                    }
                }
            }
            throw new UsuarioInvalidoException("El usuario es incorrecto");
                
                
            
            
        }

        /// <summary>
        /// Encuentra un empleado a partir de su nombre de usuario.
        /// </summary>
        /// <param name="usuario">Nombre de usuario del empleado a buscar.</param>
        /// <returns>Devuelve el empleado si se encuentra, sino lanza una excepción.</returns>

        public Empleado obtenerEmpleadoPorUsuario(string usuario)
        {
            List<Empleado> listaEmpleados = ObtenerEmpleado();

            foreach (Empleado empleado in listaEmpleados)
            {
                if (usuario == empleado.Usuario)
                {
                    return empleado;
                }
                
            }
            throw new ElementoNoEncontradoException("No se encontro el usuario");
                    
        }
        /// <summary>
        /// Trae una lista de empleados desde la base de datos.
        /// </summary>
        /// <returns>Devuelve una lista de objetos Empleado con los datos obtenidos de la base de datos.</returns>
        public List<Empleado> ObtenerEmpleado()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(EmpleadoRepository.stringConnection))
                {
                    List<Empleado> empleados = new List<Empleado>();
                    string query = "SELECT * FROM Empleado";
                    SqlCommand comando = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Empleado empleado = new Empleado();
                            empleado.Nombre = reader.GetString(1);
                            empleado.Apellido = reader.GetString(2);
                            empleado.Puesto = reader.GetString(3);
                            empleado.Usuario= reader.GetString(4);
                            empleado.Contraseña= reader.GetString(5);

                            empleados.Add(empleado);
                        }
                        return empleados;
                    }
                    else
                    {
                        throw new BaseDeDatosException("No se encuentran datos en la base de datos");
                    }
                }
            }
            catch
            {
                throw new BaseDeDatosException("Error en la conexion en la base de datos");
            }
        }
    }
}
