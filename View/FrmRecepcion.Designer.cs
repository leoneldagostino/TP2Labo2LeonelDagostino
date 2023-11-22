namespace View
{
    partial class FrmRecepcion
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
            lblDocumentoCliente = new Label();
            txtDocumento = new TextBox();
            lblNombre = new Label();
            label2 = new Label();
            lbTelefono = new Label();
            lblCorreo = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnRegistar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblDocumentoCliente
            // 
            lblDocumentoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDocumentoCliente.AutoSize = true;
            lblDocumentoCliente.Location = new Point(49, 42);
            lblDocumentoCliente.Name = "lblDocumentoCliente";
            lblDocumentoCliente.Size = new Size(132, 15);
            lblDocumentoCliente.TabIndex = 0;
            lblDocumentoCliente.Text = "Numero de documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDocumento.Location = new Point(49, 70);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "Ingrese el N° de Documento";
            txtDocumento.Size = new Size(160, 23);
            txtDocumento.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(300, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombres";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(575, 42);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellidos";
            // 
            // lbTelefono
            // 
            lbTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(196, 171);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(90, 15);
            lbTelefono.TabIndex = 4;
            lbTelefono.Text = "Nro de telefono";
            // 
            // lblCorreo
            // 
            lblCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(447, 171);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo electronico";
            // 
            // txtNombres
            // 
            txtNombres.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombres.Location = new Point(300, 70);
            txtNombres.Name = "txtNombres";
            txtNombres.PlaceholderText = "Ingrese nombres";
            txtNombres.Size = new Size(160, 23);
            txtNombres.TabIndex = 7;
            // 
            // txtApellidos
            // 
            txtApellidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtApellidos.Location = new Point(575, 70);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PlaceholderText = "Ingrese apellidos";
            txtApellidos.Size = new Size(160, 23);
            txtApellidos.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(196, 208);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese el N° de telefono";
            txtTelefono.Size = new Size(160, 23);
            txtTelefono.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Location = new Point(447, 208);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese un correo electronico";
            txtCorreo.Size = new Size(160, 23);
            txtCorreo.TabIndex = 10;
            // 
            // btnRegistar
            // 
            btnRegistar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistar.Location = new Point(448, 344);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(296, 49);
            btnRegistar.TabIndex = 12;
            btnRegistar.Text = "Registrar";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.Location = new Point(49, 370);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmRecepcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(784, 425);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(lblCorreo);
            Controls.Add(lbTelefono);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumentoCliente);
            Name = "FrmRecepcion";
            Text = "Recepcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDocumentoCliente;
        private TextBox txtDocumento;
        private Label lblNombre;
        private Label label2;
        private Label lbTelefono;
        private Label lblCorreo;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnRegistar;
        private Button btnCancelar;
    }
}