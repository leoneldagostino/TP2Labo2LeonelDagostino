namespace View
{
    partial class FrmLogin
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
            lblUsuario = new Label();
            txtUsuarioLogin = new TextBox();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = SystemColors.Control;
            lblUsuario.Location = new Point(248, 108);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuarioLogin.Location = new Point(369, 100);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.PlaceholderText = "Ingresar usuario";
            txtUsuarioLogin.Size = new Size(163, 23);
            txtUsuarioLogin.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContraseña.Location = new Point(369, 176);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Ingresar contraseña";
            txtContraseña.Size = new Size(163, 23);
            txtContraseña.TabIndex = 3;
            // 
            // lblContraseña
            // 
            lblContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = SystemColors.Control;
            lblContraseña.Location = new Point(248, 179);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIngresar.Location = new Point(248, 244);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(284, 41);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(lblUsuario);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuarioLogin;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private Button btnIngresar;
    }
}