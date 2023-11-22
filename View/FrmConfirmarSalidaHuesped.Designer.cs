namespace View
{
    partial class FrmConfirmarSalidaHuesped
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombreCliente = new Label();
            lblApellidoCliente = new Label();
            lblDni = new Label();
            lblNroHabitacion = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtNroHabitacion = new TextBox();
            btnConfirmarSalida = new Button();
            lblTelefonoCliente = new Label();
            txtTelefono = new TextBox();
            lblFechaEntrada = new Label();
            lblFechaSalida = new Label();
            lblTipoHabitacion = new Label();
            txtFechaEntrada = new TextBox();
            txtFechaSalida = new TextBox();
            txtTipoHabitacion = new TextBox();
            btnCancelarSalida = new Button();
            SuspendLayout();
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(53, 37);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(54, 15);
            lblNombreCliente.TabIndex = 0;
            lblNombreCliente.Text = "Nombre ";
            // 
            // lblApellidoCliente
            // 
            lblApellidoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblApellidoCliente.AutoSize = true;
            lblApellidoCliente.Location = new Point(248, 33);
            lblApellidoCliente.Name = "lblApellidoCliente";
            lblApellidoCliente.Size = new Size(51, 15);
            lblApellidoCliente.TabIndex = 1;
            lblApellidoCliente.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Location = new Point(425, 37);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(25, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "Dni";
            // 
            // lblNroHabitacion
            // 
            lblNroHabitacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNroHabitacion.AutoSize = true;
            lblNroHabitacion.Location = new Point(55, 164);
            lblNroHabitacion.Name = "lblNroHabitacion";
            lblNroHabitacion.Size = new Size(104, 15);
            lblNroHabitacion.TabIndex = 3;
            lblNroHabitacion.Text = "Nro de Habitacion";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(55, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(75, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(248, 66);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(75, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDni.Location = new Point(425, 66);
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(75, 23);
            txtDni.TabIndex = 6;
            // 
            // txtNroHabitacion
            // 
            txtNroHabitacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNroHabitacion.Location = new Point(53, 194);
            txtNroHabitacion.Name = "txtNroHabitacion";
            txtNroHabitacion.ReadOnly = true;
            txtNroHabitacion.Size = new Size(75, 23);
            txtNroHabitacion.TabIndex = 7;
            // 
            // btnConfirmarSalida
            // 
            btnConfirmarSalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirmarSalida.Location = new Point(574, 349);
            btnConfirmarSalida.Name = "btnConfirmarSalida";
            btnConfirmarSalida.Size = new Size(150, 35);
            btnConfirmarSalida.TabIndex = 8;
            btnConfirmarSalida.Text = "Confirmar Salida";
            btnConfirmarSalida.UseVisualStyleBackColor = true;
            btnConfirmarSalida.Click += btnConfirmarSalida_Click;
            // 
            // lblTelefonoCliente
            // 
            lblTelefonoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefonoCliente.AutoSize = true;
            lblTelefonoCliente.Location = new Point(610, 37);
            lblTelefonoCliente.Name = "lblTelefonoCliente";
            lblTelefonoCliente.Size = new Size(52, 15);
            lblTelefonoCliente.TabIndex = 9;
            lblTelefonoCliente.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(608, 66);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(75, 23);
            txtTelefono.TabIndex = 10;
            // 
            // lblFechaEntrada
            // 
            lblFechaEntrada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFechaEntrada.AutoSize = true;
            lblFechaEntrada.Location = new Point(248, 164);
            lblFechaEntrada.Name = "lblFechaEntrada";
            lblFechaEntrada.Size = new Size(81, 15);
            lblFechaEntrada.TabIndex = 11;
            lblFechaEntrada.Text = "Fecha Entrada";
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(425, 164);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(72, 15);
            lblFechaSalida.TabIndex = 12;
            lblFechaSalida.Text = "Fecha Salida";
            // 
            // lblTipoHabitacion
            // 
            lblTipoHabitacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTipoHabitacion.AutoSize = true;
            lblTipoHabitacion.Location = new Point(610, 164);
            lblTipoHabitacion.Name = "lblTipoHabitacion";
            lblTipoHabitacion.Size = new Size(108, 15);
            lblTipoHabitacion.TabIndex = 13;
            lblTipoHabitacion.Text = "Tipo De Habitacion";
            // 
            // txtFechaEntrada
            // 
            txtFechaEntrada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFechaEntrada.Location = new Point(248, 194);
            txtFechaEntrada.Name = "txtFechaEntrada";
            txtFechaEntrada.ReadOnly = true;
            txtFechaEntrada.Size = new Size(75, 23);
            txtFechaEntrada.TabIndex = 14;
            // 
            // txtFechaSalida
            // 
            txtFechaSalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFechaSalida.Location = new Point(425, 194);
            txtFechaSalida.Name = "txtFechaSalida";
            txtFechaSalida.ReadOnly = true;
            txtFechaSalida.Size = new Size(75, 23);
            txtFechaSalida.TabIndex = 15;
            // 
            // txtTipoHabitacion
            // 
            txtTipoHabitacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTipoHabitacion.Location = new Point(608, 194);
            txtTipoHabitacion.Name = "txtTipoHabitacion";
            txtTipoHabitacion.ReadOnly = true;
            txtTipoHabitacion.Size = new Size(75, 23);
            txtTipoHabitacion.TabIndex = 16;
            // 
            // btnCancelarSalida
            // 
            btnCancelarSalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelarSalida.Location = new Point(55, 349);
            btnCancelarSalida.Name = "btnCancelarSalida";
            btnCancelarSalida.Size = new Size(150, 35);
            btnCancelarSalida.TabIndex = 17;
            btnCancelarSalida.Text = "Cancelar";
            btnCancelarSalida.UseVisualStyleBackColor = true;
            btnCancelarSalida.Click += btnCancelarSalida_Click;
            // 
            // FrmConfirmarSalidaHuesped
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarSalida);
            Controls.Add(txtTipoHabitacion);
            Controls.Add(txtFechaSalida);
            Controls.Add(txtFechaEntrada);
            Controls.Add(lblTipoHabitacion);
            Controls.Add(lblFechaSalida);
            Controls.Add(lblFechaEntrada);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefonoCliente);
            Controls.Add(btnConfirmarSalida);
            Controls.Add(txtNroHabitacion);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNroHabitacion);
            Controls.Add(lblDni);
            Controls.Add(lblApellidoCliente);
            Controls.Add(lblNombreCliente);
            Name = "FrmConfirmarSalidaHuesped";
            Text = "Confirmar Salida Huesped";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCliente;
        private Label lblApellidoCliente;
        private Label lblDni;
        private Label lblNroHabitacion;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtNroHabitacion;
        private Button btnConfirmarSalida;
        private Label lblTelefonoCliente;
        private TextBox txtTelefono;
        private Label lblFechaEntrada;
        private Label lblFechaSalida;
        private Label lblTipoHabitacion;
        private TextBox txtFechaEntrada;
        private TextBox txtFechaSalida;
        private TextBox txtTipoHabitacion;
        private Button btnCancelarSalida;
    }
}