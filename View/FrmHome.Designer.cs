namespace View
{
    partial class FrmHome
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
            btnAsignarHuespedHome = new FontAwesome.Sharp.IconButton();
            btnRecepcionHome = new FontAwesome.Sharp.IconButton();
            btnRegistroHome = new FontAwesome.Sharp.IconButton();
            btnRegistrarSalidaHome = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btnAsignarHuespedHome
            // 
            btnAsignarHuespedHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAsignarHuespedHome.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            btnAsignarHuespedHome.IconColor = Color.Black;
            btnAsignarHuespedHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAsignarHuespedHome.IconSize = 100;
            btnAsignarHuespedHome.Location = new Point(139, 45);
            btnAsignarHuespedHome.Name = "btnAsignarHuespedHome";
            btnAsignarHuespedHome.Size = new Size(165, 120);
            btnAsignarHuespedHome.TabIndex = 0;
            btnAsignarHuespedHome.Text = "Asignar Huesped";
            btnAsignarHuespedHome.TextAlign = ContentAlignment.BottomCenter;
            btnAsignarHuespedHome.UseVisualStyleBackColor = true;
            btnAsignarHuespedHome.Click += btnAsignarHuespedHome_Click;
            // 
            // btnRecepcionHome
            // 
            btnRecepcionHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRecepcionHome.IconChar = FontAwesome.Sharp.IconChar.CartFlatbedSuitcase;
            btnRecepcionHome.IconColor = Color.Black;
            btnRecepcionHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRecepcionHome.IconSize = 100;
            btnRecepcionHome.Location = new Point(495, 45);
            btnRecepcionHome.Name = "btnRecepcionHome";
            btnRecepcionHome.Size = new Size(165, 120);
            btnRecepcionHome.TabIndex = 1;
            btnRecepcionHome.Text = "Recepcion";
            btnRecepcionHome.TextAlign = ContentAlignment.BottomCenter;
            btnRecepcionHome.UseVisualStyleBackColor = true;
            btnRecepcionHome.Click += btnRecepcionHome_Click;
            // 
            // btnRegistroHome
            // 
            btnRegistroHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistroHome.IconChar = FontAwesome.Sharp.IconChar.Server;
            btnRegistroHome.IconColor = Color.Black;
            btnRegistroHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistroHome.IconSize = 100;
            btnRegistroHome.Location = new Point(139, 284);
            btnRegistroHome.Name = "btnRegistroHome";
            btnRegistroHome.Size = new Size(165, 120);
            btnRegistroHome.TabIndex = 2;
            btnRegistroHome.Text = "Registro";
            btnRegistroHome.TextAlign = ContentAlignment.BottomCenter;
            btnRegistroHome.UseVisualStyleBackColor = true;
            btnRegistroHome.Click += btnRegistroHome_Click;
            // 
            // btnRegistrarSalidaHome
            // 
            btnRegistrarSalidaHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrarSalidaHome.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnRegistrarSalidaHome.IconColor = Color.Black;
            btnRegistrarSalidaHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarSalidaHome.IconSize = 100;
            btnRegistrarSalidaHome.Location = new Point(495, 284);
            btnRegistrarSalidaHome.Name = "btnRegistrarSalidaHome";
            btnRegistrarSalidaHome.Size = new Size(165, 120);
            btnRegistrarSalidaHome.TabIndex = 3;
            btnRegistrarSalidaHome.Text = "Registrar Salida";
            btnRegistrarSalidaHome.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrarSalidaHome.UseVisualStyleBackColor = true;
            btnRegistrarSalidaHome.Click += btnRegistrarSalidaHome_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarSalidaHome);
            Controls.Add(btnRegistroHome);
            Controls.Add(btnRecepcionHome);
            Controls.Add(btnAsignarHuespedHome);
            Name = "FrmHome";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAsignarHuespedHome;
        private FontAwesome.Sharp.IconButton btnRecepcionHome;
        private FontAwesome.Sharp.IconButton btnRegistroHome;
        private FontAwesome.Sharp.IconButton btnRegistrarSalidaHome;
    }
}