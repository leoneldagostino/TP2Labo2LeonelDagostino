namespace View
{
    partial class FrmAsignarHuesped
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
            lblCliente = new Label();
            lblTipoRegistro = new Label();
            lblFechaEntrada = new Label();
            lblFechaSalida = new Label();
            cmbTipoRegistro = new ComboBox();
            btnCancelar = new Button();
            btnRegistro = new Button();
            dtmFechaEntrada = new DateTimePicker();
            dtmFechaSalida = new DateTimePicker();
            txtDniHuesped = new TextBox();
            lblTipoHabitacion = new Label();
            cmbTipoHabitacion = new ComboBox();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(52, 51);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(54, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Huesped";
            // 
            // lblTipoRegistro
            // 
            lblTipoRegistro.AutoSize = true;
            lblTipoRegistro.Location = new Point(531, 51);
            lblTipoRegistro.Name = "lblTipoRegistro";
            lblTipoRegistro.Size = new Size(89, 15);
            lblTipoRegistro.TabIndex = 1;
            lblTipoRegistro.Text = "Tipo de registro";
            // 
            // lblFechaEntrada
            // 
            lblFechaEntrada.AutoSize = true;
            lblFechaEntrada.Location = new Point(121, 201);
            lblFechaEntrada.Name = "lblFechaEntrada";
            lblFechaEntrada.Size = new Size(97, 15);
            lblFechaEntrada.TabIndex = 2;
            lblFechaEntrada.Text = "Fecha de entrada";
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(456, 201);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(87, 15);
            lblFechaSalida.TabIndex = 3;
            lblFechaSalida.Text = "Fecha de salida";
            // 
            // cmbTipoRegistro
            // 
            cmbTipoRegistro.FormattingEnabled = true;
            cmbTipoRegistro.Items.AddRange(new object[] { "Ocupar", "Reservar" });
            cmbTipoRegistro.Location = new Point(531, 82);
            cmbTipoRegistro.Name = "cmbTipoRegistro";
            cmbTipoRegistro.Size = new Size(200, 23);
            cmbTipoRegistro.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(52, 388);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(531, 388);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(200, 23);
            btnRegistro.TabIndex = 6;
            btnRegistro.Text = "Agregar registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // dtmFechaEntrada
            // 
            dtmFechaEntrada.Format = DateTimePickerFormat.Short;
            dtmFechaEntrada.Location = new Point(121, 229);
            dtmFechaEntrada.Name = "dtmFechaEntrada";
            dtmFechaEntrada.Size = new Size(225, 23);
            dtmFechaEntrada.TabIndex = 7;
            // 
            // dtmFechaSalida
            // 
            dtmFechaSalida.Format = DateTimePickerFormat.Short;
            dtmFechaSalida.Location = new Point(454, 229);
            dtmFechaSalida.Name = "dtmFechaSalida";
            dtmFechaSalida.Size = new Size(200, 23);
            dtmFechaSalida.TabIndex = 8;
            // 
            // txtDniHuesped
            // 
            txtDniHuesped.Location = new Point(52, 82);
            txtDniHuesped.Name = "txtDniHuesped";
            txtDniHuesped.PlaceholderText = "Ingrese el dni del huesped";
            txtDniHuesped.Size = new Size(200, 23);
            txtDniHuesped.TabIndex = 9;
            // 
            // lblTipoHabitacion
            // 
            lblTipoHabitacion.AutoSize = true;
            lblTipoHabitacion.Location = new Point(293, 51);
            lblTipoHabitacion.Name = "lblTipoHabitacion";
            lblTipoHabitacion.Size = new Size(105, 15);
            lblTipoHabitacion.TabIndex = 10;
            lblTipoHabitacion.Text = "Tipo de habitacion";
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Items.AddRange(new object[] { "Matrimonial", "Individual", "Doble" });
            cmbTipoHabitacion.Location = new Point(293, 82);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(200, 23);
            cmbTipoHabitacion.TabIndex = 11;
            // 
            // FrmAsignarHuesped
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(764, 457);
            Controls.Add(cmbTipoHabitacion);
            Controls.Add(lblTipoHabitacion);
            Controls.Add(txtDniHuesped);
            Controls.Add(dtmFechaSalida);
            Controls.Add(dtmFechaEntrada);
            Controls.Add(btnRegistro);
            Controls.Add(btnCancelar);
            Controls.Add(cmbTipoRegistro);
            Controls.Add(lblFechaSalida);
            Controls.Add(lblFechaEntrada);
            Controls.Add(lblTipoRegistro);
            Controls.Add(lblCliente);
            Name = "FrmAsignarHuesped";
            Text = "Hospedar cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label lblTipoRegistro;
        private Label lblFechaEntrada;
        private Label lblFechaSalida;
        private ComboBox cmbTipoRegistro;
        private Button btnCancelar;
        private Button btnRegistro;
        private DateTimePicker dtmFechaEntrada;
        private DateTimePicker dtmFechaSalida;
        private TextBox txtDniHuesped;
        private Label lblTipoHabitacion;
        private ComboBox cmbTipoHabitacion;
    }
}