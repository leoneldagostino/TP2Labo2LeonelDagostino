namespace View
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            panelMenu = new Panel();
            btnLogin = new FontAwesome.Sharp.IconButton();
            btnSalida = new FontAwesome.Sharp.IconButton();
            btnRegistro = new FontAwesome.Sharp.IconButton();
            btnRecepcion = new FontAwesome.Sharp.IconButton();
            btnAsignarHuesped = new FontAwesome.Sharp.IconButton();
            panelArriba = new Panel();
            panel2 = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            lblTopInicio = new Label();
            iconBtnActual = new FontAwesome.Sharp.IconPictureBox();
            panelSombra = new Panel();
            panelPrincipal = new Panel();
            panel1 = new Panel();
            panelMenu.SuspendLayout();
            panelArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconBtnActual).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkSlateBlue;
            panelMenu.Controls.Add(btnLogin);
            panelMenu.Controls.Add(btnSalida);
            panelMenu.Controls.Add(btnRegistro);
            panelMenu.Controls.Add(btnRecepcion);
            panelMenu.Controls.Add(btnAsignarHuesped);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(244, 581);
            panelMenu.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Top;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.Gainsboro;
            btnLogin.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnLogin.IconColor = Color.Gainsboro;
            btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(0, 240);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(10, 0, 20, 0);
            btnLogin.Size = new Size(244, 70);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.TextAlign = ContentAlignment.MiddleLeft;
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSalida
            // 
            btnSalida.Dock = DockStyle.Top;
            btnSalida.FlatAppearance.BorderSize = 0;
            btnSalida.FlatStyle = FlatStyle.Flat;
            btnSalida.ForeColor = Color.Gainsboro;
            btnSalida.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnSalida.IconColor = Color.Gainsboro;
            btnSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalida.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalida.Location = new Point(0, 180);
            btnSalida.Name = "btnSalida";
            btnSalida.Padding = new Padding(10, 0, 20, 0);
            btnSalida.Size = new Size(244, 60);
            btnSalida.TabIndex = 3;
            btnSalida.Text = "Salida";
            btnSalida.TextAlign = ContentAlignment.MiddleLeft;
            btnSalida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Dock = DockStyle.Top;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.ForeColor = Color.Gainsboro;
            btnRegistro.IconChar = FontAwesome.Sharp.IconChar.Server;
            btnRegistro.IconColor = Color.Gainsboro;
            btnRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistro.Location = new Point(0, 120);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Padding = new Padding(10, 0, 20, 0);
            btnRegistro.Size = new Size(244, 60);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registro";
            btnRegistro.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnRecepcion
            // 
            btnRecepcion.Dock = DockStyle.Top;
            btnRecepcion.FlatAppearance.BorderSize = 0;
            btnRecepcion.FlatStyle = FlatStyle.Flat;
            btnRecepcion.ForeColor = Color.Gainsboro;
            btnRecepcion.IconChar = FontAwesome.Sharp.IconChar.CartFlatbedSuitcase;
            btnRecepcion.IconColor = Color.Gainsboro;
            btnRecepcion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRecepcion.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecepcion.Location = new Point(0, 60);
            btnRecepcion.Name = "btnRecepcion";
            btnRecepcion.Padding = new Padding(10, 0, 20, 0);
            btnRecepcion.Size = new Size(244, 60);
            btnRecepcion.TabIndex = 1;
            btnRecepcion.Text = "Recepcion";
            btnRecepcion.TextAlign = ContentAlignment.MiddleLeft;
            btnRecepcion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecepcion.UseVisualStyleBackColor = true;
            btnRecepcion.Click += btnRecepcion_Click;
            // 
            // btnAsignarHuesped
            // 
            btnAsignarHuesped.Dock = DockStyle.Top;
            btnAsignarHuesped.FlatAppearance.BorderSize = 0;
            btnAsignarHuesped.FlatStyle = FlatStyle.Flat;
            btnAsignarHuesped.ForeColor = Color.Gainsboro;
            btnAsignarHuesped.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            btnAsignarHuesped.IconColor = Color.Gainsboro;
            btnAsignarHuesped.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAsignarHuesped.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsignarHuesped.Location = new Point(0, 0);
            btnAsignarHuesped.Name = "btnAsignarHuesped";
            btnAsignarHuesped.Padding = new Padding(10, 0, 20, 0);
            btnAsignarHuesped.Size = new Size(244, 60);
            btnAsignarHuesped.TabIndex = 0;
            btnAsignarHuesped.Text = "Asignar huesped";
            btnAsignarHuesped.TextAlign = ContentAlignment.MiddleLeft;
            btnAsignarHuesped.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsignarHuesped.UseVisualStyleBackColor = true;
            btnAsignarHuesped.Click += btnAsignarCliente_Click;
            // 
            // panelArriba
            // 
            panelArriba.BackColor = Color.DarkSlateBlue;
            panelArriba.Controls.Add(panel2);
            panelArriba.Controls.Add(btnCerrar);
            panelArriba.Controls.Add(btnMinimizar);
            panelArriba.Controls.Add(lblTopInicio);
            panelArriba.Controls.Add(iconBtnActual);
            panelArriba.Dock = DockStyle.Top;
            panelArriba.Location = new Point(244, 0);
            panelArriba.Name = "panelArriba";
            panelArriba.Size = new Size(872, 60);
            panelArriba.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 60);
            panel2.TabIndex = 4;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.DarkSlateBlue;
            btnCerrar.ForeColor = SystemColors.ControlText;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnCerrar.IconColor = SystemColors.ControlText;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 25;
            btnCerrar.Location = new Point(835, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 3;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.DarkSlateBlue;
            btnMinimizar.ForeColor = SystemColors.ControlText;
            btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnMinimizar.IconColor = SystemColors.ControlText;
            btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizar.IconSize = 25;
            btnMinimizar.Location = new Point(777, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblTopInicio
            // 
            lblTopInicio.AutoSize = true;
            lblTopInicio.ForeColor = Color.Gainsboro;
            lblTopInicio.Location = new Point(75, 21);
            lblTopInicio.Name = "lblTopInicio";
            lblTopInicio.Size = new Size(36, 15);
            lblTopInicio.TabIndex = 1;
            lblTopInicio.Text = "Inicio";
            // 
            // iconBtnActual
            // 
            iconBtnActual.BackColor = Color.DarkSlateBlue;
            iconBtnActual.ForeColor = Color.Gainsboro;
            iconBtnActual.IconChar = FontAwesome.Sharp.IconChar.House;
            iconBtnActual.IconColor = Color.Gainsboro;
            iconBtnActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnActual.Location = new Point(30, 12);
            iconBtnActual.Name = "iconBtnActual";
            iconBtnActual.Size = new Size(32, 32);
            iconBtnActual.TabIndex = 0;
            iconBtnActual.TabStop = false;
            iconBtnActual.Click += iconBtnActual_Click;
            // 
            // panelSombra
            // 
            panelSombra.BackColor = Color.SlateBlue;
            panelSombra.Dock = DockStyle.Top;
            panelSombra.Location = new Point(244, 60);
            panelSombra.Name = "panelSombra";
            panelSombra.Size = new Size(872, 5);
            panelSombra.TabIndex = 2;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.DarkSlateBlue;
            panelPrincipal.Controls.Add(panel1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(244, 65);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(872, 516);
            panelPrincipal.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 516);
            panel1.TabIndex = 0;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1116, 581);
            Controls.Add(panelPrincipal);
            Controls.Add(panelSombra);
            Controls.Add(panelArriba);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm";
            Load += FrmView_Load;
            panelMenu.ResumeLayout(false);
            panelArriba.ResumeLayout(false);
            panelArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconBtnActual).EndInit();
            panelPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnAsignarHuesped;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconButton btnSalida;
        private FontAwesome.Sharp.IconButton btnRegistro;
        private FontAwesome.Sharp.IconButton btnRecepcion;
        private Panel panelArriba;
        private FontAwesome.Sharp.IconPictureBox iconBtnActual;
        private Label lblTopInicio;
        private Panel panelSombra;
        private Panel panelPrincipal;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private Panel panel2;
        private Panel panel1;
    }
}