namespace AsistenciaApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtArea = new TextBox();
            txtCargo = new TextBox();
            txtCorreo = new TextBox();
            dtpFecha = new DateTimePicker();
            chkPresente = new CheckBox();
            chkTarde = new CheckBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            cmbFiltroNombre = new ComboBox();
            chkSoloPresentes = new CheckBox();
            chkSoloTarde = new CheckBox();
            chkSoloFaltaron = new CheckBox();
            dgvRegistros = new DataGridView();
            lblTotal = new Label();
            pictureBox2 = new PictureBox();
            btnReporteTXT = new Button();
            btnReporteCSV = new Button();
            txtObservaciones = new TextBox();
            btnUltimos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 175);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(311, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(330, 175);
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "DNI";
            txtDNI.Size = new Size(186, 27);
            txtDNI.TabIndex = 1;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(522, 175);
            txtArea.Name = "txtArea";
            txtArea.PlaceholderText = "Área";
            txtArea.Size = new Size(222, 27);
            txtArea.TabIndex = 2;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(762, 175);
            txtCargo.Name = "txtCargo";
            txtCargo.PlaceholderText = "Cargo";
            txtCargo.Size = new Size(252, 27);
            txtCargo.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(1038, 175);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(254, 27);
            txtCorreo.TabIndex = 4;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(12, 258);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(292, 27);
            dtpFecha.TabIndex = 5;
            // 
            // chkPresente
            // 
            chkPresente.AutoSize = true;
            chkPresente.Location = new Point(329, 261);
            chkPresente.Name = "chkPresente";
            chkPresente.Size = new Size(87, 24);
            chkPresente.TabIndex = 6;
            chkPresente.Text = "Presente";
            chkPresente.CheckedChanged += chkPresente_CheckedChanged;
            // 
            // chkTarde
            // 
            chkTarde.AutoSize = true;
            chkTarde.Location = new Point(432, 262);
            chkTarde.Name = "chkTarde";
            chkTarde.Size = new Size(67, 24);
            chkTarde.TabIndex = 7;
            chkTarde.Text = "Tarde";
            chkTarde.CheckedChanged += chkTarde_CheckedChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(505, 258);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 30);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(797, 258);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(142, 30);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(651, 258);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 30);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(959, 258);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(142, 30);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbFiltroNombre
            // 
            cmbFiltroNombre.Location = new Point(12, 307);
            cmbFiltroNombre.Name = "cmbFiltroNombre";
            cmbFiltroNombre.Size = new Size(432, 28);
            cmbFiltroNombre.TabIndex = 12;
            cmbFiltroNombre.SelectedIndexChanged += cmbFiltroNombre_SelectedIndexChanged;
            // 
            // chkSoloPresentes
            // 
            chkSoloPresentes.AutoSize = true;
            chkSoloPresentes.Location = new Point(451, 307);
            chkSoloPresentes.Name = "chkSoloPresentes";
            chkSoloPresentes.Size = new Size(128, 24);
            chkSoloPresentes.TabIndex = 13;
            chkSoloPresentes.Text = "Solo presentes";
            chkSoloPresentes.CheckedChanged += chkSoloPresentes_CheckedChanged;
            // 
            // chkSoloTarde
            // 
            chkSoloTarde.AutoSize = true;
            chkSoloTarde.Location = new Point(585, 307);
            chkSoloTarde.Name = "chkSoloTarde";
            chkSoloTarde.Size = new Size(100, 24);
            chkSoloTarde.TabIndex = 14;
            chkSoloTarde.Text = "Solo tarde";
            chkSoloTarde.CheckedChanged += chkSoloTarde_CheckedChanged;
            // 
            // chkSoloFaltaron
            // 
            chkSoloFaltaron.AutoSize = true;
            chkSoloFaltaron.Location = new Point(691, 307);
            chkSoloFaltaron.Name = "chkSoloFaltaron";
            chkSoloFaltaron.Size = new Size(117, 24);
            chkSoloFaltaron.TabIndex = 15;
            chkSoloFaltaron.Text = "Solo faltaron";
            chkSoloFaltaron.CheckedChanged += chkSoloFaltaron_CheckedChanged;
            // 
            // dgvRegistros
            // 
            dgvRegistros.ColumnHeadersHeight = 29;
            dgvRegistros.Location = new Point(68, 354);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(1223, 323);
            dgvRegistros.TabIndex = 16;
            dgvRegistros.SelectionChanged += dgvRegistros_SelectionChanged;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(841, 312);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(126, 23);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Total registros: 0";
            // 

            this.lblPresentes = new System.Windows.Forms.Label();
            this.lblPresentes.Location = new System.Drawing.Point(20, 490); // Ajusta ubicación si lo deseas
            this.lblPresentes.Size = new System.Drawing.Size(200, 23);
            this.lblPresentes.Text = "Presentes: 0";

            this.lblFaltaron = new System.Windows.Forms.Label();
            this.lblFaltaron.Location = new System.Drawing.Point(250, 490); // Ajusta ubicación si lo deseas
            this.lblFaltaron.Size = new System.Drawing.Size(200, 23);
            this.lblFaltaron.Text = "Faltaron: 0";

            this.Controls.Add(this.lblPresentes);
            this.Controls.Add(this.lblFaltaron);


            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1329, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // btnReporteTXT

            this.btnDuplicar = new System.Windows.Forms.Button();
            this.btnDuplicar.Location = new System.Drawing.Point(850, 100); // Ajusta posición
            this.btnDuplicar.Name = "btnDuplicar";
            this.btnDuplicar.Size = new System.Drawing.Size(100, 30);
            this.btnDuplicar.Text = "Duplicar";
            this.btnDuplicar.Click += new System.EventHandler(this.btnDuplicar_Click);
            this.Controls.Add(this.btnDuplicar);
            // 
            btnReporteTXT.Location = new Point(1164, 301);
            btnReporteTXT.Name = "btnReporteTXT";
            btnReporteTXT.Size = new Size(153, 30);
            btnReporteTXT.TabIndex = 15;
            btnReporteTXT.Text = "Reporte TXT";
            btnReporteTXT.UseVisualStyleBackColor = true;
            btnReporteTXT.Click += btnReporteTXT_Click;
            // 
            // btnReporteCSV
            // 
            btnReporteCSV.Location = new Point(1164, 258);
            btnReporteCSV.Name = "btnReporteCSV";
            btnReporteCSV.Size = new Size(153, 30);
            btnReporteCSV.TabIndex = 16;
            btnReporteCSV.Text = "Reporte CSV";
            btnReporteCSV.UseVisualStyleBackColor = true;
            btnReporteCSV.Click += btnReporteCSV_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(13, 225);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Observaciones";
            txtObservaciones.Size = new Size(300, 27);
            txtObservaciones.TabIndex = 0;
            // 
            // btnUltimos
            // 
            btnUltimos.Location = new Point(973, 303);
            btnUltimos.Name = "btnUltimos";
            btnUltimos.Size = new Size(100, 30);
            btnUltimos.TabIndex = 0;
            btnUltimos.Text = "Últimos 10";
            btnUltimos.Click += btnUltimos_Click;
            // 
            // MainForm
            // 
            AutoSize = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1329, 689);
            Controls.Add(btnUltimos);
            Controls.Add(txtObservaciones);
            Controls.Add(btnReporteTXT);
            Controls.Add(btnReporteCSV);
            Controls.Add(pictureBox2);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(txtArea);
            Controls.Add(txtCargo);
            Controls.Add(txtCorreo);
            Controls.Add(dtpFecha);
            Controls.Add(chkPresente);
            Controls.Add(chkTarde);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(cmbFiltroNombre);
            Controls.Add(chkSoloPresentes);
            Controls.Add(chkSoloTarde);
            Controls.Add(chkSoloFaltaron);
            Controls.Add(dgvRegistros);
            Controls.Add(lblTotal);
            Name = "MainForm";
            Text = "Registro de Asistencia";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox chkPresente;
        private System.Windows.Forms.CheckBox chkTarde;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnUltimos;
        private System.Windows.Forms.Button btnDuplicar;
        private System.Windows.Forms.ComboBox cmbFiltroNombre;
        private System.Windows.Forms.CheckBox chkSoloPresentes;
        private System.Windows.Forms.CheckBox chkSoloTarde;
        private System.Windows.Forms.CheckBox chkSoloFaltaron;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPresentes;
        private System.Windows.Forms.Label lblFaltaron;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReporteTXT;
        private System.Windows.Forms.Button btnReporteCSV;
    }
}
