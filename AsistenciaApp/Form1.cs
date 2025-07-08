using AsistenciaApp.Interfaces;
using AsistenciaApp.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using AsistenciaApp.models;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


namespace AsistenciaApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly IAsistenciaServicio attendanceService;
        private int selectedId = -1;

        public MainForm()
        {
            InitializeComponent();
            attendanceService = new AsistenciaServicio();

            dgvRegistros.AutoGenerateColumns = true;
            ActualizarVista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre.");
                return;
            }

            if (txtDNI.Text.Length != 8 || !int.TryParse(txtDNI.Text, out _))
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos numéricos.");
                return;
            }

            var emp = new Empleados(
                txtNombre.Text.Trim(),
                dtpFecha.Value,
                chkPresente.Checked,
                chkTarde.Checked,
                txtDNI.Text.Trim(),
                txtArea.Text.Trim(),
                txtCargo.Text.Trim(),
                txtCorreo.Text.Trim()
            );

            attendanceService.AddRecord(emp);
            ActualizarVista();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Seleccione un registro para modificar.");
                return;
            }

            var emp = new Empleados
            {
                Id = selectedId,
                Name = txtNombre.Text.Trim(),
                Date = dtpFecha.Value,
                Present = chkPresente.Checked,
                Late = chkTarde.Checked,
                DNI = txtDNI.Text.Trim(),
                Area = txtArea.Text.Trim(),
                Position = txtCargo.Text.Trim(),
                Email = txtCorreo.Text.Trim()
            };

            attendanceService.UpdateRecord(selectedId, emp);
            ActualizarVista();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }

            attendanceService.DeleteRecord(selectedId);
            ActualizarVista();
            LimpiarCampos();
        }

        private void btnReporteTXT_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo de texto (*.txt)|*.txt";
                saveFileDialog.Title = "Guardar reporte de asistencia (.txt)";
                saveFileDialog.FileName = "reporte_asistencia.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                        {
                            sw.WriteLine("REPORTE DE ASISTENCIA - Nudo Boreal");
                            sw.WriteLine("Fecha de generaci�n: " + DateTime.Now);
                            sw.WriteLine("-----------------------------------------------------");

                            foreach (DataGridViewRow row in dgvRegistros.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string linea = $"ID: {row.Cells["Id"].Value}, Nombre: {row.Cells["Name"].Value}, DNI: {row.Cells["DNI"].Value}, " +
                                                   $"�rea: {row.Cells["Area"].Value}, Cargo: {row.Cells["Position"].Value}, Correo: {row.Cells["Email"].Value}, " +
                                                   $"Fecha: {row.Cells["Date"].Value}, Presente: {row.Cells["Present"].Value}, Tarde: {row.Cells["Late"].Value}";
                                    sw.WriteLine(linea);
                                }
                            }

                            sw.WriteLine("-----------------------------------------------------");
                            sw.WriteLine($"Total de registros: {dgvRegistros.Rows.Count - 1}");
                        }

                        MessageBox.Show("Archivo TXT generado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el TXT: " + ex.Message);
                    }
                }
            }
        }

        private void btnReporteCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Guardar reporte de asistencia (.csv)";
                saveFileDialog.FileName = "reporte_asistencia.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Usa UTF-8 con BOM para que Excel reconozca los acentos
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, new UTF8Encoding(true)))
                        {
                            // Encabezado con punto y coma como separador
                            sw.WriteLine("ID;Nombre;Fecha;Presente;Tarde;DNI;Área;Cargo;Correo");

                            foreach (DataGridViewRow row in dgvRegistros.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string linea =
                                        $"{row.Cells["Id"].Value};" +
                                        $"{row.Cells["Name"].Value};" +
                                        $"{Convert.ToDateTime(row.Cells["Date"].Value).ToString("dd/MM/yyyy HH:mm")};" +
                                        $"{row.Cells["Present"].Value};" +
                                        $"{row.Cells["Late"].Value};" +
                                        $"{row.Cells["DNI"].Value};" +
                                        $"{row.Cells["Area"].Value};" +
                                        $"{row.Cells["Position"].Value};" +
                                        $"{row.Cells["Email"].Value}";

                                    sw.WriteLine(linea);
                                }
                            }
                        }

                        MessageBox.Show("Archivo CSV generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el CSV: " + ex.Message);
                    }
                }
            }
        }


        private void LimpiarCampos()
        {
            selectedId = -1;
            txtNombre.Clear();
            txtDNI.Clear();
            txtArea.Clear();
            txtCargo.Clear();
            txtCorreo.Clear();
            chkPresente.Checked = false;
            chkTarde.Checked = false;
            dtpFecha.Value = DateTime.Now;
            cmbFiltroNombre.SelectedIndex = 0;
        }



        private void ActualizarVista()
        {
            var data = attendanceService.GetRecords();

            // Filtro por nombre
            if (!string.IsNullOrWhiteSpace(cmbFiltroNombre.Text) && cmbFiltroNombre.Text != "Todos")
                data = data.Where(e => e.Name == cmbFiltroNombre.Text).ToList();

            // Filtro por presentes
            if (chkSoloPresentes.Checked)
                data = data.Where(e => e.Present).ToList();

            // Filtro por tarde
            if (chkSoloTarde.Checked)
                data = data.Where(e => e.Late).ToList();

            // Filtro por faltaron
            if (chkSoloFaltaron.Checked)
                data = data.Where(e => !e.Present && !e.Late).ToList();

            // Desconectar evento de selecci�n
            dgvRegistros.SelectionChanged -= dgvRegistros_SelectionChanged;

            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = data;

            dgvRegistros.SelectionChanged += dgvRegistros_SelectionChanged;

            lblTotal.Text = $"Total registros: {data.Count}";

            // Actualizar ComboBox nombres
            var nombres = attendanceService.GetRecords().Select(e => e.Name).Distinct().ToList();

            cmbFiltroNombre.SelectedIndexChanged -= cmbFiltroNombre_SelectedIndexChanged;

            cmbFiltroNombre.Items.Clear();
            cmbFiltroNombre.Items.Add("Todos");
            cmbFiltroNombre.Items.AddRange(nombres.ToArray());

            if (cmbFiltroNombre.SelectedIndex == -1)
                cmbFiltroNombre.SelectedIndex = 0;

            cmbFiltroNombre.SelectedIndexChanged += cmbFiltroNombre_SelectedIndexChanged;



            //Encabezado de la tabla

            dgvRegistros.Columns["Id"].HeaderText = "ID";
            dgvRegistros.Columns["Name"].HeaderText = "Nombre";
            dgvRegistros.Columns["DNI"].HeaderText = "DNI";
            dgvRegistros.Columns["Area"].HeaderText = "Área";
            dgvRegistros.Columns["Position"].HeaderText = "Cargo";
            dgvRegistros.Columns["Email"].HeaderText = "Correo";
            dgvRegistros.Columns["Date"].HeaderText = "Fecha";
            dgvRegistros.Columns["Present"].HeaderText = "Presente";
            dgvRegistros.Columns["Late"].HeaderText = "Tarde";
        }


        private void dgvRegistros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRegistros.CurrentRow?.DataBoundItem is Empleados emp)
            {
                selectedId = emp.Id;
                txtNombre.Text = emp.Name;
                txtDNI.Text = emp.DNI;
                txtArea.Text = emp.Area;
                txtCargo.Text = emp.Position;
                txtCorreo.Text = emp.Email;
                dtpFecha.Value = emp.Date;
                chkPresente.Checked = emp.Present;
                chkTarde.Checked = emp.Late;
            }
        }

        private void cmbFiltroNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarVista();
        }

        private void chkSoloPresentes_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVista();
        }

        private void chkSoloTarde_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVista();
        }

        private void chkSoloFaltaron_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVista();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void chkPresente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPresente.Checked)
            {
                chkTarde.Checked = false;
            }
        }

        private void chkTarde_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTarde.Checked)
            {
                chkPresente.Checked = false;
            }
        }
    }
}
