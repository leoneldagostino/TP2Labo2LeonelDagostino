using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Repositorio
{

    public delegate void HuespedEncontradoEventHandler(Huesped huespedEncontrado);
    public delegate void HuespedRegistradoEventHandler(Huesped huespedRegistrado);
    public delegate void HuespedAsignadoEventHandler(Huesped huespedAsignado);
    public class HuespedRepostory : IRepository<Huesped>,IHuespedRepository
    {
        public event HuespedEncontradoEventHandler HuespedEncontrado;
        public event HuespedRegistradoEventHandler HuespedRegistrado;
        public event HuespedAsignadoEventHandler HuespedAsignado;

        private static string stringConnection;

        static HuespedRepostory()
        { 
            stringConnection = "Server=.;Database=dbHotel;Trusted_Connection=True;";
        }
        /// <summary>
        /// Busca un Huesped por su numero de DNI.
        /// </summary>
        /// <param name="dni">Numero de DNI del huesped a buscar.</param>
        /// <returns>Devuelve el Huesped si se encuentra, sino lanza una excepcion.</returns>

        public Huesped BuscarPorDniHuesped(int dni)
        {
            
            List<Huesped> huespedes = ObtenerTodos();

            foreach (Huesped huesped in huespedes)
            {
                if (huesped.Dni == dni)
                {
                    OnHuespedEncontrado(huesped);
                    return huesped;
                }
            }
            throw new ElementoNoEncontradoException("El Huesped no se encuentra, Ingrese un dni valido");
        }
        public Huesped ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla Huesped en la base de datos.
        /// </summary>
        /// <returns>
        /// Una lista de tipo Huesped que representa todos los registros obtenidos de la base de datos.
        /// </returns>
        /// <exception cref="BaseDeDatosException">
        /// Se lanza si no se encuentran datos en la base de datos o si hay un error en la conexion.
        /// </exception>
        public List<Huesped> ObtenerTodos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HuespedRepostory.stringConnection))
                {
                    List<Huesped> huespedes = new List<Huesped>();
                    string query = "SELECT * FROM Huesped";
                    SqlCommand comando = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Huesped huesped = new Huesped();
                            huesped.Dni = reader.GetInt32(0);
                            huesped.Nombre = reader.GetString(1);
                            huesped.Apellido = reader.GetString(2);
                            huesped.Telefono = reader.GetInt32(3);
                            if (!reader.IsDBNull(4))
                            {
                                huesped.FechaIngreso = reader.GetString(4);
                            }
                            else
                            {
                                huesped.FechaIngreso = "-";
                            }

                            if (!reader.IsDBNull(5))
                            {
                                huesped.FechaEgreso = reader.GetString(5);
                            }
                            else
                            {
                                huesped.FechaEgreso = "-";
                            }

                            huespedes.Add(huesped);
                        }
                        return huespedes;
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
        /// <summary>
        /// Agrega un nuevo Huesped a la base de datos.
        /// </summary>
        /// <param name="Huesped">Huesped a agregar.</param>
        public void Agregar(Huesped Huesped)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HuespedRepostory.stringConnection))
                {
                    string query = "INSERT INTO huesped (nombres,apellidos,dniHuesped,telefono)" +
                        "values (@nombre,@apellido,@dni,@telefono);";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", Huesped.Nombre);
                    command.Parameters.AddWithValue("@apellido", Huesped.Apellido);
                    command.Parameters.AddWithValue("@dni", Huesped.Dni);
                    command.Parameters.AddWithValue("@telefono", Huesped.Telefono);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                }
                OnHuespedRegistrado(Huesped);
            }
            catch
            {
                throw new DatoInvalidoException("Error en ingresar un dato a la base de dato");
            }
            
        }

        /// <summary>
        /// Actualiza los datos de un Huesped en la base de datos.
        /// </summary>
        /// <param name="Huesped">Huesped con los datos actualizados.</param>
        public void Actualizar(Huesped Huesped)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "UPDATE Huesped SET FechaIngreso=@fechaIngreso,FechaEngreso=@fechaEgreso WHERE dniHuesped=@id";
                    SqlCommand comando = new SqlCommand(query, connection);
                    comando.Parameters.AddWithValue("@fechaIngreso", Huesped.FechaIngreso);
                    comando.Parameters.AddWithValue("@fechaEgreso",Huesped.FechaEgreso);
                    comando.Parameters.AddWithValue("@id",Huesped.Dni);
                }

                OnHuespedAsignado(Huesped);
            }
            catch 
            { 
                throw new BaseDeDatosException("Esta ocurriendo un error en la base de datos");
            }
            
        }
        /// <summary>
        /// Elimina un Huesped de la base de datos por su identificador.
        /// </summary>
        /// <param name="id">Identificador del Huesped a eliminar.</param>
        public void Eliminar(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HuespedRepostory.stringConnection))
                {
                    string query = "DELETE FROM Huesped WHERE dniHuesped=@dni";
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
        protected virtual void OnHuespedEncontrado(Huesped huesped)
        {
            HuespedEncontrado?.Invoke(huesped);
        }
        protected virtual void OnHuespedRegistrado(Huesped huesped)
        {
            HuespedRegistrado?.Invoke(huesped);
        }
        protected virtual void OnHuespedAsignado(Huesped huesped)
        {
            HuespedAsignado?.Invoke(huesped);
        }
        


    }
}
