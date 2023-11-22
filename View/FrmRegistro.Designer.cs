namespace View
{
    partial class FrmRegistro
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
            dgvRegistro = new DataGridView();
            columnaNroHabitacion = new DataGridViewTextBoxColumn();
            columnaDniHuesped = new DataGridViewTextBoxColumn();
            columnaNombreHuesped = new DataGridViewTextBoxColumn();
            columnaApellidoHuesped = new DataGridViewTextBoxColumn();
            columnaEstadoHabitacion = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtBuscarPorDni = new TextBox();
            btnBuscarDni = new Button();
            btnMostrarDisponibles = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistro
            // 
            dgvRegistro.AllowUserToAddRows = false;
            dgvRegistro.AllowUserToDeleteRows = false;
            dgvRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistro.Columns.AddRange(new DataGridViewColumn[] { columnaNroHabitacion, columnaDniHuesped, columnaNombreHuesped, columnaApellidoHuesped, columnaEstadoHabitacion });
            dgvRegistro.Location = new Point(12, 174);
            dgvRegistro.Name = "dgvRegistro";
            dgvRegistro.ReadOnly = true;
            dgvRegistro.RowTemplate.Height = 25;
            dgvRegistro.Size = new Size(775, 220);
            dgvRegistro.TabIndex = 0;
            // 
            // columnaNroHabitacion
            // 
            columnaNroHabitacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaNroHabitacion.HeaderText = "Nro de Habitacion";
            columnaNroHabitacion.Name = "columnaNroHabitacion";
            columnaNroHabitacion.ReadOnly = true;
            // 
            // columnaDniHuesped
            // 
            columnaDniHuesped.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaDniHuesped.HeaderText = "Dni de Huesped";
            columnaDniHuesped.Name = "columnaDniHuesped";
            columnaDniHuesped.ReadOnly = true;
            // 
            // columnaNombreHuesped
            // 
            columnaNombreHuesped.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaNombreHuesped.HeaderText = "Nombre de Huesped";
            columnaNombreHuesped.Name = "columnaNombreHuesped";
            columnaNombreHuesped.ReadOnly = true;
            // 
            // columnaApellidoHuesped
            // 
            columnaApellidoHuesped.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaApellidoHuesped.HeaderText = "Apellido de Huesped";
            columnaApellidoHuesped.Name = "columnaApellidoHuesped";
            columnaApellidoHuesped.ReadOnly = true;
            // 
            // columnaEstadoHabitacion
            // 
            columnaEstadoHabitacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaEstadoHabitacion.HeaderText = "Disponible";
            columnaEstadoHabitacion.Name = "columnaEstadoHabitacion";
            columnaEstadoHabitacion.ReadOnly = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(28, 69);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar Por Dni";
            // 
            // txtBuscarPorDni
            // 
            txtBuscarPorDni.Location = new Point(28, 87);
            txtBuscarPorDni.Name = "txtBuscarPorDni";
            txtBuscarPorDni.Size = new Size(150, 23);
            txtBuscarPorDni.TabIndex = 2;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscarDni.Location = new Point(253, 75);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(150, 45);
            btnBuscarDni.TabIndex = 3;
            btnBuscarDni.Text = "Buscar";
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // btnMostrarDisponibles
            // 
            btnMostrarDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMostrarDisponibles.Location = new Point(577, 75);
            btnMostrarDisponibles.Name = "btnMostrarDisponibles";
            btnMostrarDisponibles.Size = new Size(150, 45);
            btnMostrarDisponibles.TabIndex = 4;
            btnMostrarDisponibles.Text = "Mostrar Disponibles";
            btnMostrarDisponibles.UseVisualStyleBackColor = true;
            btnMostrarDisponibles.Click += btnMostrarDisponibles_Click;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(799, 441);
            Controls.Add(btnMostrarDisponibles);
            Controls.Add(btnBuscarDni);
            Controls.Add(txtBuscarPorDni);
            Controls.Add(label1);
            Controls.Add(dgvRegistro);
            Name = "FrmRegistro";
            Text = "Registro";
            Load += FrmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRegistro;
        private DataGridViewTextBoxColumn columnaNroHabitacion;
        private DataGridViewTextBoxColumn columnaDniHuesped;
        private DataGridViewTextBoxColumn columnaNombreHuesped;
        private DataGridViewTextBoxColumn columnaApellidoHuesped;
        private DataGridViewTextBoxColumn columnaEstadoHabitacion;
        private Label label1;
        private TextBox txtBuscarPorDni;
        private Button btnBuscarDni;
        private Button btnMostrarDisponibles;
    }
}