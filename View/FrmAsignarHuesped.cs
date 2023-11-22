using Entidades.Excepciones;
using Entidades.Interfaces;
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
    public partial class FrmAsignarHuesped : Form
    {
        private HuespedRepostory repoHuesped;
        public FrmAsignarHuesped()
        {
            InitializeComponent();
            repoHuesped = new HuespedRepostory();
            repoHuesped.HuespedAsignado += ManejarHuespedRegistrado;
        }
        /// <summary>
        /// Metodo asincronico para registrar un huésped.
        /// </summary
        private async void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {

                    Huesped huesped = repoHuesped.BuscarPorDniHuesped(int.Parse(txtDniHuesped.Text));
                    if (huesped != null)
                    {
                        HabitacionRepository habRepository = new HabitacionRepository();

                        if (cmbTipoHabitacion.SelectedItem.ToString() == "")
                        {
                            throw new DatoInvalidoException("El tipo no fue ingresado");
                        }

                        int validacionFechas = DateTime.Compare(dtmFechaEntrada.Value, dtmFechaSalida.Value);
                        if (validacionFechas >= 0)
                        {
                            throw new FechaSalidaInvalidaException("Esta ingresando una fecha de salida posterior a la fecha de entrada");
                        }
                        else
                        {
                            huesped.FechaIngreso = dtmFechaEntrada.Text;
                            huesped.FechaEgreso = dtmFechaSalida.Text;
                            repoHuesped.Actualizar(huesped);
                        }
                        bool esReserva = cmbTipoRegistro.SelectedItem.ToString() == "Reservar";

                        habRepository.Actualizar(huesped.Dni, cmbTipoHabitacion.Text, esReserva);
                    }
                });
            }
            catch (FechaSalidaInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "Error al ingresar la fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DatoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error al ingresar un dato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ElementoNoEncontradoException ex)
            {
                MessageBox.Show(ex.Message, "Error al buscar huesped", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CapacidadCompletaException ex)
            {
                MessageBox.Show(ex.Message, "Asignar huesped", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Metodo para cancelar la operación y volver al formulario principal.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form formPrincipal = this.ParentForm;
            if (formPrincipal is FrmView frmView)
            {
                this.Close();
                frmView.AbrirFormulario(new FrmHome());
            }
        }
        /// <summary>
        /// Metodo para manejar el evento de registro exitoso de un huésped.
        /// </summary>
        private void ManejarHuespedRegistrado(Huesped huespedRegistrado)
        {
            MessageBox.Show("Se registro con exito el huesped", "Huesped Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
