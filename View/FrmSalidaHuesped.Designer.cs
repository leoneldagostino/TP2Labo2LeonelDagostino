namespace View
{
    partial class FrmSalidaHuesped
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
            btnBuscarHuesped = new Button();
            lblDni = new Label();
            txtDni = new TextBox();
            SuspendLayout();
            // 
            // btnBuscarHuesped
            // 
            btnBuscarHuesped.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscarHuesped.Location = new Point(198, 245);
            btnBuscarHuesped.Name = "btnBuscarHuesped";
            btnBuscarHuesped.Size = new Size(339, 31);
            btnBuscarHuesped.TabIndex = 0;
            btnBuscarHuesped.Text = "Buscar huesped";
            btnBuscarHuesped.UseVisualStyleBackColor = true;
            btnBuscarHuesped.Click += btnBuscarHuesped_Click;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Location = new Point(198, 136);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(130, 15);
            lblDni.TabIndex = 1;
            lblDni.Text = "Ingresar numero de dni";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDni.Location = new Point(350, 133);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingresar N° de dni del huesped";
            txtDni.Size = new Size(187, 23);
            txtDni.TabIndex = 2;
            // 
            // FrmSalidaHuesped
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(802, 458);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(btnBuscarHuesped);
            Name = "FrmSalidaHuesped";
            Text = "Salida Huesped";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarHuesped;
        private Label lblDni;
        private TextBox txtDni;
    }
}