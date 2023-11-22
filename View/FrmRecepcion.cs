using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.MetodosDeExtension;
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
    public partial class FrmRecepcion : Form
    {
        private HuespedRepostory huespedRepo;
        public FrmRecepcion()
        {
            InitializeComponent();
            huespedRepo = new HuespedRepostory();
            huespedRepo.HuespedRegistrado += ManejarHuespedRegistrado;
        }
        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón para registrar un huésped.
        /// </summary>
        private async void btnRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    Huesped huesped = new Huesped();

                    huesped.Dni = ValidarEntero(txtDocumento.Text, "dni");
                    huesped.Nombre = ValidarTexto(txtNombres.Text, "nombre");
                    huesped.Apellido = ValidarTexto(txtApellidos.Text, "apellido");
                    huesped.Telefono = ValidarEntero(txtTelefono.Text, "telefono");

                    huespedRepo.Agregar(huesped);

                });
                LimpiarCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Ocurrio un error de validacion",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        /// <summary>
        /// Método para limpiar los campos del formulario.
        /// </summary>       
        private void LimpiarCampos()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LimpiarCampos));
                return;
            }
            txtApellidos.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtCorreo.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApellidos.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtCorreo.Text = string.Empty;
        }
        /// <summary>
        /// Valida si el valor ingresado puede convertirse en un entero y devuelve el resultado.
        /// </summary>
        /// <param name="valor">Valor a validar.</param>
        /// <param name="nombreDato">Nombre del dato a validar.</param>
        /// <returns>El valor entero validado.</returns>
        /// <exception cref="DniInvalidoException">Se lanza si el valor para el DNI no es válido.</exception>
        /// <exception cref="NumeroInvalidoException">Se lanza si el valor para un número no es válido.</exception>

        private int ValidarEntero(string valor, string nombreDato)
        {
            if (!int.TryParse(valor, out int resultado))
            {
                if (nombreDato == "dni")
                {
                    throw new DniInvalidoException($"El valor ingresado para el {nombreDato} no es válido.");
                }
                else
                {
                    throw new NumeroInvalidoException($"El valor ingresado para el {nombreDato} no es válido.");
                }
            }
            return resultado;
        }
        /// <summary>
        /// Valida si el valor ingresado es un texto válido y lo devuelve.
        /// </summary>
        /// <param name="valor">Valor a validar.</param>
        /// <param name="nombreDato">Nombre del dato a validar.</param>
        /// <returns>El texto validado.</returns>
        /// <exception cref="DatoInvalidoException">Se lanza si el valor ingresado no es válido o es nulo/espacio en blanco.</exception>
        private string ValidarTexto(string valor, string nombreDato)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new DatoInvalidoException($"Debe ingresar un valor válido para {nombreDato}.");
            }
            return valor;
        }
        /// <summary>
        /// Método para manejar el evento de haber registrado un nuevo huésped.
        /// </summary>
        /// <param name="huespedRegistrado">Huésped registrado.</param>
        private void ManejarHuespedRegistrado(Huesped huespedRegistrado)
        {
            MessageBox.Show("Se registro con exito un nuevo huesped:\n" +
                MisMetodosDeExtension.NombreCompleto(huespedRegistrado), "Huesped registada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
