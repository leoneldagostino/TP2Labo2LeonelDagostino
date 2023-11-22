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
    public partial class FrmHome : Form
    {
        

        public FrmHome()
        {
            InitializeComponent();


        }
        /// <summary>
        /// Metodo que se activa al hacer clic en el botón "Asignar Huesped" del formulario principal.
        /// Abre la funcionalidad para asignar un nuevo huesped.
        /// </summary>
        private void btnAsignarHuespedHome_Click(object sender, EventArgs e)
        {
            Form formPrincipal = this.ParentForm;
            if (formPrincipal is FrmView frmView)
            {
                frmView.btnAsignarCliente_Click(sender,  e);
            }
        }
        /// <summary>
        /// Metodo que se activa al hacer clic en el botón "Recepción" del formulario principal.
        /// Abre la funcionalidad para realizar operaciones en la recepción.
        /// </summary>
        private void btnRecepcionHome_Click(object sender, EventArgs e)
        {
            Form formPrincipal = this.ParentForm;
            if (formPrincipal is FrmView frmView)
            {
                frmView.btnRecepcion_Click(sender, e);
            }
        }
        /// <summary>
        /// Metodo que se activa al hacer clic en el botón "Registro" del formulario principal.
        /// Abre la funcionalidad para registrar información de los huespedes.
        /// </summary>
        private void btnRegistroHome_Click(object sender, EventArgs e)
        {
            Form formPrincipal = this.ParentForm;
            if (formPrincipal is FrmView frmView)
            {
                frmView.btnRegistro_Click(sender, e);
            }
        }
        /// <summary>
        /// Metodo que se activa al hacer clic en el botón "Registrar Salida" del formulario principal.
        /// Abre la funcionalidad para registrar la salida de un huesped.
        /// </summary>
        private void btnRegistrarSalidaHome_Click(object sender, EventArgs e)
        {
            Form formPrincipal = this.ParentForm;
            if (formPrincipal is FrmView frmView)
            {
                frmView.btnSalida_Click(sender, e);
            }
        }

    }
}
