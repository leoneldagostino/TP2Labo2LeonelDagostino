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
    public partial class FrmConfirmarSalidaHuesped : Form
    {
        HuespedRepostory huespedRepository;
        HabitacionRepository habRepo;
        public FrmConfirmarSalidaHuesped(Huesped huesped)
        {
            InitializeComponent();
            huespedRepository = new HuespedRepostory();
            habRepo = new HabitacionRepository();
            Habitacion habitacionDeHuesped = habRepo.ObtenerPorDniHuespd(huesped.Dni);

            txtNombre.Text = huesped.Nombre;
            txtApellido.Text = huesped.Apellido;
            txtDni.Text = huesped.Dni.ToString();
            txtTelefono.Text = huesped.Telefono.ToString();
            txtFechaEntrada.Text = huesped.FechaIngreso;
            txtFechaSalida.Text = huesped.FechaEgreso;
            txtNroHabitacion.Text = habitacionDeHuesped.NroHabitacion.ToString();
            txtTipoHabitacion.Text = habitacionDeHuesped.TipoHabitacion;
        }
        /// <summary>
        /// Metodo asincronico para confirmar la salida de un huesped.
        /// </summary>
        private async void btnConfirmarSalida_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    int nroHabitacion = int.Parse(txtNroHabitacion.Text);
                    int dniHuesped = int.Parse(txtDni.Text);
                    Habitacion habitacionHuesped = habRepo.ObtenerPorDniHuespd(dniHuesped);
                    Huesped huespedABuscar = huespedRepository.BuscarPorDniHuesped(dniHuesped);
                    huespedRepository.Eliminar(huespedABuscar.Dni);
                    habRepo.Actualizar(habitacionHuesped);
                });
                MessageBox.Show("Confirmando salida de huesped","Confirmando",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                VolverFormHome();
            }

        }
        /// <summary>
        /// Metodo para cancelar la salida del huesped y volver al formulario anterior.
        /// </summary>
        private void btnCancelarSalida_Click(object sender, EventArgs e)
        {
            Form formPrincipal = this.ParentForm;
            if (formPrincipal is FrmView frmView)
            {
                frmView.AbrirFormulario(new FrmSalidaHuesped());
                this.Close();
            }
        }
        /// <summary>
        /// Metodo para volver al formulario principal.
        /// </summary>
        private void VolverFormHome()
        {
            Form formPrincipal = this.ParentForm;
            if (formPrincipal is FrmView frmView)
            {
                this.Close();
                frmView.AbrirFormulario(new FrmHome());
            }
        }

    }
}
