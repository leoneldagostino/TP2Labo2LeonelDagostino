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
    public partial class FrmSalidaHuesped : Form
    {
        private HuespedRepostory huespedRepo;

        public FrmSalidaHuesped()
        {
            InitializeComponent();
            huespedRepo = new HuespedRepostory();
            huespedRepo.HuespedEncontrado += ManejarHuespedEncontrado;
        }
        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón para buscar un huésped por DNI.
        /// </summary>
        private void btnBuscarHuesped_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtDni.Text, out int dniABuscar))
                {
                    Huesped huesped = huespedRepo.BuscarPorDniHuesped(dniABuscar);
                }
                else
                {
                    throw new DatoInvalidoException("Ingreso un dato invalido, debe ingresar solo el dni.");
                }
            }
            catch(DatoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Dato ingresado invalido.",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ElementoNoEncontradoException ex)
            {
                MessageBox.Show(ex.Message, "Huesped no encontrado",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Método para manejar el evento de haber encontrado un huésped.
        /// </summary>
        /// <param name="huespedEncontrado">Huésped encontrado.</param>
        private void ManejarHuespedEncontrado(Huesped huespedEncontrado)
        {
            MessageBox.Show("Se encontro el huesped", "Huesped encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form formPrincipal = this.ParentForm;
            if (formPrincipal is FrmView frmView)
            {
                frmView.AbrirFormulario(new FrmConfirmarSalidaHuesped(huespedEncontrado));
                this.Close();
            }
        }
    }
}
