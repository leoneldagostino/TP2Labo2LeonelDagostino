using Entidades.Excepciones;
using Entidades.Modelos;
using Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {

            InitializeComponent();
        }

        private void CargarDatos()
        {
            HuespedRepostory huespedRepo = new HuespedRepostory();
            HabitacionRepository habRepo = new HabitacionRepository();

            List<Habitacion> habitacionesHotel = (List<Habitacion>)habRepo.ObtenerTodos();
            foreach (var habitacion in habitacionesHotel)
            {
                string nombreHuesped = string.Empty;
                string apellidoHuesped = string.Empty;
                if (habitacion.HuespedId != 0)
                {
                    int dniHueped = habitacion.HuespedId;
                    Huesped huespedEncontrado = huespedRepo.BuscarPorDniHuesped(dniHueped);
                    nombreHuesped = huespedEncontrado.Nombre;
                    apellidoHuesped = huespedEncontrado.Apellido;

                }
                bool estaLibre = !habitacion.EstaOcupada && !habitacion.EstaReservada;

                dgvRegistro.Rows.Add(
                    habitacion.NroHabitacion,
                    habitacion.HuespedId,
                    nombreHuesped,
                    apellidoHuesped,
                    estaLibre ? "Disponible" : "No disponible"
                    );
            }
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón para buscar un huésped por DNI.
        /// </summary>
        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            try
            {
                HuespedRepostory huespedRepo = new HuespedRepostory();
                HabitacionRepository habRepo = new HabitacionRepository();
                if (!int.TryParse(txtBuscarPorDni.Text, out int dni))
                {
                    throw new NumeroInvalidoException("No estas ingresando un numero valido");
                }
                Huesped huespedEncontrado = huespedRepo.BuscarPorDniHuesped(dni);
                if (huespedEncontrado != null)
                {
                    Habitacion habitacionDeHuesped = habRepo.ObtenerPorDniHuespd(dni);

                    dgvRegistro.Rows.Clear();

                    if (huespedEncontrado != null)
                    {
                        dgvRegistro.Rows.Add(
                            habitacionDeHuesped.NroHabitacion,
                            habitacionDeHuesped.HuespedId,
                            huespedEncontrado.Nombre,
                            huespedEncontrado.Apellido,
                            "-"
                            );
                    }
                    else
                    {
                        MessageBox.Show("No se entontro ninguna habitaciona asociada con ese DNI", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro ningun huesped con ese DNI", "No se encontro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NumeroInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error numero introducido invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Método para manejar el evento de haber encontrado un huésped.
        /// </summary>
        /// <param name="huespedEncontrado">Huésped encontrado.</param>
        private void btnMostrarDisponibles_Click(object sender, EventArgs e)
        {
            HuespedRepostory huespedRepo = new HuespedRepostory();
            HabitacionRepository habRepo = new HabitacionRepository();

            List<Habitacion> habitacionesHotel = (List<Habitacion>)habRepo.ObtenerTodos();
            dgvRegistro.Rows.Clear();
            foreach (var habitacion in habitacionesHotel)
            {
                string nombreHuesped = string.Empty;
                string apellidoHuesped = string.Empty;
                bool estaLibre = !habitacion.EstaOcupada && !habitacion.EstaReservada;
                if (estaLibre)
                {
                    if (habitacion.HuespedId == 0)
                    {
                   

                        dgvRegistro.Rows.Add(
                            habitacion.NroHabitacion,
                            string.Empty,
                            nombreHuesped,
                            apellidoHuesped,
                            estaLibre ? "Disponible" : "No disponible"
                            );
                    }

                }
                    

            }
        }
    }
}
