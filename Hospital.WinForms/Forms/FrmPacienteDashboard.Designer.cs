namespace Hospital.WinForms;

partial class FrmPacienteDashboard
{
    private System.ComponentModel.IContainer components = null;
    private TabControl tabMain;
    private TabPage tabPerfil;
    private TabPage tabAgendar;
    private TabPage tabMisCitas;

    private TableLayoutPanel perfilLayout;
    private TextBox txtPerfilNombre;
    private TextBox txtPerfilApellidos;
    private TextBox txtPerfilTelefono;
    private TextBox txtPerfilEmail;
    private TextBox txtPerfilCurp;
    private DateTimePicker dtpPerfilNacimiento;
    private ComboBox cboPerfilPrioridad;
    private Button btnPerfilGuardar;

    private TableLayoutPanel agendarLayout;
    private ComboBox cboAgendarEspecialidad;
    private ComboBox cboAgendarMedico;
    private DateTimePicker dtpAgendarFecha;
    private ComboBox cboAgendarHorario;
    private Button btnAgendar;

    private DataGridView dgvMisCitas;
    private FlowLayoutPanel misCitasControls;
    private ComboBox cboFiltroEstado;
    private Button btnReprogramar;
    private Button btnCancelar;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        tabMain = new TabControl();
        tabPerfil = new TabPage();
        tabAgendar = new TabPage();
        tabMisCitas = new TabPage();
        perfilLayout = new TableLayoutPanel();
        txtPerfilNombre = new TextBox();
        txtPerfilApellidos = new TextBox();
        txtPerfilTelefono = new TextBox();
        txtPerfilEmail = new TextBox();
        txtPerfilCurp = new TextBox();
        dtpPerfilNacimiento = new DateTimePicker();
        cboPerfilPrioridad = new ComboBox();
        btnPerfilGuardar = new Button();

        agendarLayout = new TableLayoutPanel();
        cboAgendarEspecialidad = new ComboBox();
        cboAgendarMedico = new ComboBox();
        dtpAgendarFecha = new DateTimePicker();
        cboAgendarHorario = new ComboBox();
        btnAgendar = new Button();

        dgvMisCitas = new DataGridView();
        misCitasControls = new FlowLayoutPanel();
        cboFiltroEstado = new ComboBox();
        btnReprogramar = new Button();
        btnCancelar = new Button();

        tabMain.SuspendLayout();
        tabPerfil.SuspendLayout();
        tabAgendar.SuspendLayout();
        tabMisCitas.SuspendLayout();
        perfilLayout.SuspendLayout();
        agendarLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMisCitas).BeginInit();
        misCitasControls.SuspendLayout();
        SuspendLayout();

        tabMain.Dock = DockStyle.Fill;
        tabMain.TabPages.Add(tabPerfil);
        tabMain.TabPages.Add(tabAgendar);
        tabMain.TabPages.Add(tabMisCitas);

        tabPerfil.Text = "Perfil";
        tabPerfil.Controls.Add(perfilLayout);

        perfilLayout.ColumnCount = 4;
        perfilLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        perfilLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        perfilLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        perfilLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        perfilLayout.Dock = DockStyle.Fill;
        perfilLayout.RowCount = 5;
        perfilLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        perfilLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        perfilLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        perfilLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        perfilLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        perfilLayout.Controls.Add(new Label { Text = "Nombre", AutoSize = true }, 0, 0);
        perfilLayout.Controls.Add(txtPerfilNombre, 1, 0);
        perfilLayout.Controls.Add(new Label { Text = "Apellidos", AutoSize = true }, 2, 0);
        perfilLayout.Controls.Add(txtPerfilApellidos, 3, 0);
        perfilLayout.Controls.Add(new Label { Text = "Teléfono", AutoSize = true }, 0, 1);
        perfilLayout.Controls.Add(txtPerfilTelefono, 1, 1);
        perfilLayout.Controls.Add(new Label { Text = "Email", AutoSize = true }, 2, 1);
        perfilLayout.Controls.Add(txtPerfilEmail, 3, 1);
        perfilLayout.Controls.Add(new Label { Text = "CURP", AutoSize = true }, 0, 2);
        perfilLayout.Controls.Add(txtPerfilCurp, 1, 2);
        perfilLayout.Controls.Add(new Label { Text = "Fecha nacimiento", AutoSize = true }, 2, 2);
        perfilLayout.Controls.Add(dtpPerfilNacimiento, 3, 2);
        perfilLayout.Controls.Add(new Label { Text = "Prioridad", AutoSize = true }, 0, 3);
        perfilLayout.Controls.Add(cboPerfilPrioridad, 1, 3);
        perfilLayout.Controls.Add(btnPerfilGuardar, 3, 4);

        txtPerfilNombre.Dock = DockStyle.Fill;
        txtPerfilApellidos.Dock = DockStyle.Fill;
        txtPerfilTelefono.Dock = DockStyle.Fill;
        txtPerfilEmail.Dock = DockStyle.Fill;
        txtPerfilCurp.Dock = DockStyle.Fill;
        txtPerfilCurp.ReadOnly = true;
        dtpPerfilNacimiento.Dock = DockStyle.Fill;
        dtpPerfilNacimiento.Enabled = false;
        cboPerfilPrioridad.Dock = DockStyle.Fill;
        cboPerfilPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPerfilPrioridad.Items.AddRange(new object[] { "1 - URGENTE (URGENT)", "2 - ALTA (HIGH)", "3 - MEDIA (MEDIUM)", "4 - BAJA (LOW)" });
        btnPerfilGuardar.Text = "Guardar cambios";
        btnPerfilGuardar.Anchor = AnchorStyles.Right;

        tabAgendar.Text = "Agendar Cita";
        tabAgendar.Controls.Add(agendarLayout);

        agendarLayout.ColumnCount = 2;
        agendarLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        agendarLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        agendarLayout.Dock = DockStyle.Fill;
        agendarLayout.RowCount = 5;
        agendarLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        agendarLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        agendarLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        agendarLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        agendarLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        agendarLayout.Controls.Add(new Label { Text = "Especialidad", AutoSize = true }, 0, 0);
        agendarLayout.Controls.Add(cboAgendarEspecialidad, 1, 0);
        agendarLayout.Controls.Add(new Label { Text = "Médico", AutoSize = true }, 0, 1);
        agendarLayout.Controls.Add(cboAgendarMedico, 1, 1);
        agendarLayout.Controls.Add(new Label { Text = "Fecha", AutoSize = true }, 0, 2);
        agendarLayout.Controls.Add(dtpAgendarFecha, 1, 2);
        agendarLayout.Controls.Add(new Label { Text = "Horario", AutoSize = true }, 0, 3);
        agendarLayout.Controls.Add(cboAgendarHorario, 1, 3);
        agendarLayout.Controls.Add(btnAgendar, 1, 4);

        cboAgendarEspecialidad.Dock = DockStyle.Fill;
        cboAgendarMedico.Dock = DockStyle.Fill;
        dtpAgendarFecha.Dock = DockStyle.Fill;
        cboAgendarHorario.Dock = DockStyle.Fill;
        cboAgendarHorario.DropDownStyle = ComboBoxStyle.DropDownList;
        btnAgendar.Text = "Agendar";
        btnAgendar.Anchor = AnchorStyles.Right;

        tabMisCitas.Text = "Mis Citas";
        tabMisCitas.Controls.Add(dgvMisCitas);
        tabMisCitas.Controls.Add(misCitasControls);

        dgvMisCitas.Dock = DockStyle.Fill;
        dgvMisCitas.BackgroundColor = SystemColors.Window;
        dgvMisCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        misCitasControls.Dock = DockStyle.Top;
        misCitasControls.FlowDirection = FlowDirection.LeftToRight;
        misCitasControls.Padding = new Padding(8);
        misCitasControls.Controls.Add(new Label { Text = "Estado", AutoSize = true, Margin = new Padding(3, 6, 3, 3) });
        misCitasControls.Controls.Add(cboFiltroEstado);
        misCitasControls.Controls.Add(btnReprogramar);
        misCitasControls.Controls.Add(btnCancelar);

        cboFiltroEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboFiltroEstado.Items.AddRange(new object[] { "PENDIENTE", "ATENDIDA", "CANCELADA" });
        cboFiltroEstado.Width = 160;

        btnReprogramar.Text = "Reprogramar";
        btnCancelar.Text = "Cancelar/Eliminar";

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 700);
        Controls.Add(tabMain);
        Text = "Dashboard Paciente";

        tabMain.ResumeLayout(false);
        tabPerfil.ResumeLayout(false);
        tabAgendar.ResumeLayout(false);
        tabMisCitas.ResumeLayout(false);
        perfilLayout.ResumeLayout(false);
        perfilLayout.PerformLayout();
        agendarLayout.ResumeLayout(false);
        agendarLayout.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMisCitas).EndInit();
        misCitasControls.ResumeLayout(false);
        misCitasControls.PerformLayout();
        ResumeLayout(false);
    }
}
