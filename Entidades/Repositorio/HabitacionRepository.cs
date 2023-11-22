using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Repositorio
{
    public class HabitacionRepository : IRepository<Habitacion>
    {
        private static string stringConnection;

        static HabitacionRepository()
        {
            stringConnection = "Server=.;Database=dbHotel;Trusted_Connection=True;";
        }

        /// <summary>
        /// Obtiene la información de una habitación en base a un DNI de huesped.
        /// </summary>
        /// <param name="dni">DNI del huesped asociado a la habitacion.</param>
        /// <returns>La Habitacion correspondiente al DNI del huesped.</returns>
        /// <exception cref="ElementoNoEncontradoException">
        /// Se lanza si no se encuentra la habitación para el DNI.
        /// </exception>
        public Habitacion ObtenerPorDniHuespd(int dni)
        {
            List<Habitacion> habitaciones = (List<Habitacion>)ObtenerTodos();
            foreach (Habitacion habitacion in habitaciones)
            {
                if (habitacion.HuespedId == dni)
                {
                    return habitacion;
                }
            }
            throw new ElementoNoEncontradoException("No se encontro la habitacion, el dni no se encuentra registrado");
        }
        public Habitacion ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Obtiene todas las habitaciones disponibles en la base de datos.
        /// </summary>
        /// <returns>Una colección de tipo Habitacion con todas las habitaciones obtenidas.</returns>
        /// <exception cref="BaseDeDatosException">
        /// Se lanza si no se encuentran datos en la base de datos o si hay un error en la conexión.
        /// </exception>
        public IEnumerable<Habitacion> ObtenerTodos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HabitacionRepository.stringConnection))
                {
                    List<Habitacion> Habitaciones = new List<Habitacion>();
                    string query = "SELECT * FROM Habitacion";
                    SqlCommand comando = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Habitacion Habitacion = new Habitacion();
                            Habitacion.NroHabitacion = reader.GetInt32(0);
                            if (reader.IsDBNull(1))
                            {
                                Habitacion.HuespedId = 0;
                            }
                            else
                            {
                                Habitacion.HuespedId = reader.GetInt32(1);
                            }
                            Habitacion.EstaOcupada = (reader.GetInt32(2) != 0);
                            Habitacion.EstaReservada = (reader.GetInt32(3) != 0);
                            if (reader.IsDBNull(4))
                            {
                                Habitacion.TipoHabitacion = string.Empty;
                            }
                            else
                            {
                                Habitacion.TipoHabitacion = reader.GetString(4);
                            }

                            Habitaciones.Add(Habitacion);

                        }
                        return Habitaciones;
                    }
                    else
                    {
                        throw new BaseDeDatosException("No se encontraron datos en la base de datos");
                    }
                }
            }
            catch 
            {
                throw new BaseDeDatosException("Error en la conexion en la base de datos");
            }
        }
        public void Agregar(Habitacion habitacion)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Actualiza la informacion de una habitacion en la base de datos.
        /// </summary>
        /// <param name="DniHuesped">El Dni del huesped.</param>
        /// <param name="tipoHabitacion">Que tipo de habitacion.</param>
        /// <param name="reservar">El huesped hace reserva.</param>
        /// <exception cref="BaseDeDatosException">Se lanza si hay un error al actualizar en la base de datos.</exception>

        public void Actualizar(int DniHuesped, string tipoHabitacion, bool reservar)
        {
            List<Habitacion> habitaciones = (List<Habitacion>)ObtenerTodos();

            foreach (Habitacion habitacion in habitaciones)
            {
                bool estaLibre = habitacion.EstaOcupada == false && habitacion.EstaReservada == false;
                if (estaLibre)
                {
                    using (SqlConnection connection = new SqlConnection(HabitacionRepository.stringConnection))
                    {
                        if (reservar)
                        {
                            string query = "UPDATE habitacion SET id_huesped = @DniHuesped, descripcion = @Descripcion, reservada = @reservo WHERE id_Habitacion = @IdHabitacion";
                            SqlCommand command = new SqlCommand(query, connection);

                            command.Parameters.AddWithValue("@DniHuesped", DniHuesped);
                            command.Parameters.AddWithValue("@Descripcion", tipoHabitacion);
                            command.Parameters.AddWithValue("@IdHabitacion", habitacion.NroHabitacion);
                            command.Parameters.AddWithValue("@reservo", 1);

                            connection.Open();
                            command.ExecuteNonQuery();
                            return;
                        }
                        else
                        {
                            string query = "UPDATE habitacion SET id_huesped = @DniHuesped, descripcion = @Descripcion, ocupada = @ocupado WHERE id_Habitacion = @IdHabitacion"; 
                            SqlCommand command = new SqlCommand (query, connection);

                            command.Parameters.AddWithValue("@DniHuesped", DniHuesped);
                            command.Parameters.AddWithValue("@Descripcion", tipoHabitacion);
                            command.Parameters.AddWithValue("@IdHabitacion", habitacion.NroHabitacion);
                            command.Parameters.AddWithValue("@ocupado", 1);

                            connection.Open();
                            command.ExecuteNonQuery();
                            return;
                        }
                    }
                }
                
            }
            throw new CapacidadCompletaException("No hay ninguna habitacion disponible");
        }
        /// <summary>
        /// Elimina una habitacion de la base de datos según su identificador.
        /// </summary>
        /// <param name="id">Identificador de la habitacion a eliminar.</param>
        /// <exception cref="DatoInvalidoException">
        /// Se lanza si hay un error al intentar eliminar el dato de la base de datos.
        /// </exception>
        public void Eliminar(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HabitacionRepository.stringConnection))
                {
                    string query = "DELETE id_huesped FROM Habitacion WHERE id_huesped=@dni";
                    SqlCommand comando = new SqlCommand(query, connection);
                    comando.Parameters.AddWithValue("@dni", id);

                    connection.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new DatoInvalidoException("Error al ingresar el dato");
            }
        }

        List<Habitacion> IRepository<Habitacion>.ObtenerTodos()
        {
            throw new NotImplementedException ();
        }
        /// <summary>
        /// Actualiza la informacion de una habitacion en la base de datos.
        /// </summary>
        /// <param name="habitacion">Objeto Habitacion con la informacion actualizada.</param>
        /// <exception cref="BaseDeDatosException">Se lanza si hay un error al actualizar en la base de datos.</exception>

        public void Actualizar(Habitacion habitacion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HabitacionRepository.stringConnection))
                {
                    string query = "UPDATE Habitacion SET id_huesped=@dni,reservada=@reserva,ocupada=@ocupada,descripcion=@descripcion WHERE id_habitacion=@id";
                    SqlCommand comando = new SqlCommand(query, connection);
                    comando.Parameters.AddWithValue("@id",habitacion.NroHabitacion);
                    comando.Parameters.AddWithValue("@dni",0);
                    comando.Parameters.AddWithValue("@reserva",0);
                    comando.Parameters.AddWithValue("@ocupada",0);
                    comando.Parameters.AddWithValue("@descripcion","");

                    connection.Open();
                    comando.ExecuteNonQuery();

                }
            }
            catch
            {
                throw new BaseDeDatosException("Error al ingresar en la base de datos");
            }
        }
    }
}
