using FontAwesome.Sharp;
namespace View
{
    public partial class FrmView : Form
    {
        private IconButton btnActual;
        private Panel btnBordeIzq;
        private Form activoFormulario;
        public FrmView()
        {
            InitializeComponent();
            btnBordeIzq = new Panel();
            btnBordeIzq.Size = new Size(15, 60);
            panelMenu.Controls.Add(btnBordeIzq);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        /// <summary>
        /// Resalta el boton seleccionado con un color especifico.
        /// </summary>
        private void botonActivo(object sender, Color color)
        {
            if (sender != null)
            {
                OcultarBoton();
                btnActual = (IconButton)sender;
                btnActual.BackColor = Color.FromArgb(37, 36, 81);
                btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;

                btnBordeIzq.BackColor = color;
                btnBordeIzq.Location = new Point(0, btnActual.Location.Y);
                btnBordeIzq.Visible = true;
                btnBordeIzq.BringToFront();

                iconBtnActual.IconChar = btnActual.IconChar;
                iconBtnActual.IconColor = color;

            }
        }
        /// <summary>
        /// Restaura los estilos predeterminados del botón actualmente activo al ocultarlo.
        /// </summary>
        private void OcultarBoton()
        {
            if (btnActual != null)
            {
                btnActual.BackColor = Color.DarkSlateBlue;
                btnActual.ForeColor = Color.Gainsboro;
                btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnActual.IconColor = Color.Gainsboro;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        /// <summary>
        /// Metodo para abrir un formulario dado en el panel principal.
        /// </summary>
        /// <param name="formulario">Formulario a abrir.</param>
        public void AbrirFormulario(Form formulario)
        {
            if (activoFormulario != null)
            {
                activoFormulario.Close();
            }
            activoFormulario = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formulario);
            panelPrincipal.Tag = formulario;

            formulario.BringToFront();
            formulario.Show();
            lblTopInicio.Text = formulario.Text;


        }
        /// <summary>
        /// Abre el formulario FrmAsignarHuesped al hacer clic en el boton correspondiente.
        /// </summary>
        internal void btnAsignarCliente_Click(object sender, EventArgs e)
        {
            botonActivo(sender, Color.RoyalBlue);
            AbrirFormulario(new FrmAsignarHuesped());
        }

        /// <summary>
        /// Abre el formulario FrmRecepcion al hacer clic en el boton correspondiente.
        /// </summary>
        internal void btnRecepcion_Click(object sender, EventArgs e)
        {
            botonActivo(sender, Color.RoyalBlue);
            AbrirFormulario(new FrmRecepcion());
        }
        /// <summary>
        /// Abre el formulario FrmRegistro al hacer clic en el boton correspondiente.
        /// </summary>
        internal void btnRegistro_Click(object sender, EventArgs e)
        {
            botonActivo(sender, Color.RoyalBlue);
            AbrirFormulario(new FrmRegistro());
        }
        /// <summary>
        /// Abre el formulario FrmSalidaHuesped al hacer clic en el boton correspondiente.
        /// </summary>
        internal void btnSalida_Click(object sender, EventArgs e)
        {
            botonActivo(sender, Color.RoyalBlue);
            AbrirFormulario(new FrmSalidaHuesped());
        }
        /// <summary>
        /// Abre el formulario FrmLogin al hacer clic en el boton correspondiente.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {

            botonActivo(sender, Color.RoyalBlue);
            AbrirFormulario(new FrmLogin());
        }
        /// <summary>
        /// Cierra el formulario activo y reinicia el formulario principal (FrmHome).
        /// </summary>
        private void iconBtnActual_Click(object sender, EventArgs e)
        {
            activoFormulario.Close();
            Reiniciar();
        }
        /// <summary>
        /// Reinicia el formulario principal (FrmHome) y restablece los estilos y valores iniciales.
        /// </summary>
        private void Reiniciar()
        {
            AbrirFormulario(new FrmHome());
            OcultarBoton();
            btnBordeIzq.Visible = false;
            iconBtnActual.IconChar = IconChar.Home;
            iconBtnActual.IconColor = Color.AliceBlue;
            lblTopInicio.Text = "Inicio";
        }

        /// <summary>
        /// Cierra la aplicacion.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Minimiza la ventana actual.
        /// </summary>
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Método que se ejecuta al cargar el formulario principal (FrmView).
        /// Abre el formulario de inicio (FrmHome) por defecto.
        /// </summary>
        private void FrmView_Load(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmHome());
        }
    }
}