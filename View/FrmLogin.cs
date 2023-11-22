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
    public partial class FrmLogin : Form
    {
        private EmpleadoRepository empleadoRepo;
        public FrmLogin()
        {
            InitializeComponent();
            empleadoRepo = new EmpleadoRepository();
        }

        /// <summary>
        /// Metodo que se activa al hacer clic en el boton "Ingresar" del formulario de inicio de sesion.
        /// Verifica las credenciales del empleado al iniciar sesión y muestra un mensaje de bienvenida si son validas.
        /// </summary>
        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioLogin.Text;
            string contraseña = txtContraseña.Text;

            try
            {
                
                await Task.Run(() =>
                {
                    if(empleadoRepo.validarUsuarioContraseña(usuario, contraseña))
                    {
                        Empleado empleadoEncontrado = empleadoRepo.obtenerEmpleadoPorUsuario(usuario);
                        MessageBox.Show($"Bienvenido \n" +
                            $"{MisMetodosDeExtension.NombreCompleto(empleadoEncontrado)}");
                    }
                    else
                    {
                        throw new Exception();
                    }

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
