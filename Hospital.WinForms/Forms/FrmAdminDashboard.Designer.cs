namespace Hospital.WinForms;

partial class FrmAdminDashboard
{
    private System.ComponentModel.IContainer components = null;
    private SplitContainer mainSplit;
    private FlowLayoutPanel navLayout;
    private Label lblUsuario;
    private Button btnNavPacientes;
    private Button btnNavMedicos;
    private Button btnNavCitas;
    private Button btnNavEspecialidades;
    private Button btnCerrarSesion;
    private TabControl tabMain;
    private TabPage tabPacientes;
    private TabPage tabMedicos;
    private TabPage tabCitas;
    private TabPage tabEspecialidades;

    private DataGridView dgvPacientes;
    private GroupBox grpPaciente;
    private TableLayoutPanel pacientesLayout;
    private TextBox txtPacienteNombre;
    private TextBox txtPacienteApellidos;
    private TextBox txtPacienteCurp;
    private DateTimePicker dtpPacienteNacimiento;
    private ComboBox cboPacientePrioridad;
    private FlowLayoutPanel pacientesButtons;
    private Button btnPacienteNuevo;
    private Button btnPacienteGuardar;
    private Button btnPacienteEditar;
    private Button btnPacienteEliminar;
    private Button btnPacienteLimpiar;

    private DataGridView dgvMedicos;
    private GroupBox grpMedico;
    private TableLayoutPanel medicosLayout;
    private TextBox txtMedicoNombre;
    private TextBox txtMedicoApellidos;
    private TextBox txtMedicoTelefono;
    private TextBox txtMedicoEmail;
    private TextBox txtMedicoCedula;
    private ComboBox cboMedicoEspecialidad;
    private CheckBox chkMedicoActivo;
    private FlowLayoutPanel medicosButtons;
    private Button btnMedicoNuevo;
    private Button btnMedicoGuardar;
    private Button btnMedicoEditar;
    private Button btnMedicoEliminar;
    private Button btnMedicoLimpiar;

    private DataGridView dgvEspecialidades;
    private GroupBox grpEspecialidad;
    private TableLayoutPanel especialidadesLayout;
    private TextBox txtEspecialidadNombre;
    private FlowLayoutPanel especialidadesButtons;
    private Button btnEspecialidadNuevo;
    private Button btnEspecialidadGuardar;
    private Button btnEspecialidadEditar;
    private Button btnEspecialidadEliminar;
    private Button btnEspecialidadLimpiar;

    private DataGridView dgvCitas;
    private GroupBox grpCita;
    private TableLayoutPanel citasLayout;
    private ComboBox cboCitaPaciente;
    private ComboBox cboCitaMedico;
    private DateTimePicker dtpCitaFechaHora;
    private ComboBox cboCitaEstado;
    private GroupBox grpReceta;
    private TableLayoutPanel recetaLayout;
    private TextBox txtRecetaDiagnostico;
    private TextBox txtRecetaMedicamento;
    private TextBox txtRecetaDosis;
    private FlowLayoutPanel citasButtons;
    private Button btnCitaNuevo;
    private Button btnCitaGuardar;
    private Button btnCitaEditar;
    private Button btnCitaCancelar;
    private Button btnCitaLimpiar;

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
        mainSplit = new SplitContainer();
        navLayout = new FlowLayoutPanel();
        lblUsuario = new Label();
        btnNavPacientes = new Button();
        btnNavMedicos = new Button();
        btnNavCitas = new Button();
        btnNavEspecialidades = new Button();
        btnCerrarSesion = new Button();
        tabMain = new TabControl();
        tabPacientes = new TabPage();
        tabMedicos = new TabPage();
        tabCitas = new TabPage();
        tabEspecialidades = new TabPage();

        dgvPacientes = new DataGridView();
        grpPaciente = new GroupBox();
        pacientesLayout = new TableLayoutPanel();
        txtPacienteNombre = new TextBox();
        txtPacienteApellidos = new TextBox();
        txtPacienteCurp = new TextBox();
        dtpPacienteNacimiento = new DateTimePicker();
        cboPacientePrioridad = new ComboBox();
        pacientesButtons = new FlowLayoutPanel();
        btnPacienteNuevo = new Button();
        btnPacienteGuardar = new Button();
        btnPacienteEditar = new Button();
        btnPacienteEliminar = new Button();
        btnPacienteLimpiar = new Button();

        dgvMedicos = new DataGridView();
        grpMedico = new GroupBox();
        medicosLayout = new TableLayoutPanel();
        txtMedicoNombre = new TextBox();
        txtMedicoApellidos = new TextBox();
        txtMedicoTelefono = new TextBox();
        txtMedicoEmail = new TextBox();
        txtMedicoCedula = new TextBox();
        cboMedicoEspecialidad = new ComboBox();
        chkMedicoActivo = new CheckBox();
        medicosButtons = new FlowLayoutPanel();
        btnMedicoNuevo = new Button();
        btnMedicoGuardar = new Button();
        btnMedicoEditar = new Button();
        btnMedicoEliminar = new Button();
        btnMedicoLimpiar = new Button();

        dgvEspecialidades = new DataGridView();
        grpEspecialidad = new GroupBox();
        especialidadesLayout = new TableLayoutPanel();
        txtEspecialidadNombre = new TextBox();
        especialidadesButtons = new FlowLayoutPanel();
        btnEspecialidadNuevo = new Button();
        btnEspecialidadGuardar = new Button();
        btnEspecialidadEditar = new Button();
        btnEspecialidadEliminar = new Button();
        btnEspecialidadLimpiar = new Button();

        dgvCitas = new DataGridView();
        grpCita = new GroupBox();
        citasLayout = new TableLayoutPanel();
        cboCitaPaciente = new ComboBox();
        cboCitaMedico = new ComboBox();
        dtpCitaFechaHora = new DateTimePicker();
        cboCitaEstado = new ComboBox();
        grpReceta = new GroupBox();
        recetaLayout = new TableLayoutPanel();
        txtRecetaDiagnostico = new TextBox();
        txtRecetaMedicamento = new TextBox();
        txtRecetaDosis = new TextBox();
        citasButtons = new FlowLayoutPanel();
        btnCitaNuevo = new Button();
        btnCitaGuardar = new Button();
        btnCitaEditar = new Button();
        btnCitaCancelar = new Button();
        btnCitaLimpiar = new Button();

        ((System.ComponentModel.ISupportInitialize)mainSplit).BeginInit();
        mainSplit.Panel1.SuspendLayout();
        mainSplit.Panel2.SuspendLayout();
        mainSplit.SuspendLayout();
        navLayout.SuspendLayout();
        tabMain.SuspendLayout();
        tabPacientes.SuspendLayout();
        tabMedicos.SuspendLayout();
        tabCitas.SuspendLayout();
        tabEspecialidades.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
        grpPaciente.SuspendLayout();
        pacientesLayout.SuspendLayout();
        pacientesButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
        grpMedico.SuspendLayout();
        medicosLayout.SuspendLayout();
        medicosButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
        grpEspecialidad.SuspendLayout();
        especialidadesLayout.SuspendLayout();
        especialidadesButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
        grpCita.SuspendLayout();
        citasLayout.SuspendLayout();
        grpReceta.SuspendLayout();
        recetaLayout.SuspendLayout();
        citasButtons.SuspendLayout();
        SuspendLayout();

        mainSplit.Dock = DockStyle.Fill;
        mainSplit.FixedPanel = FixedPanel.Panel1;
        mainSplit.IsSplitterFixed = false;
        mainSplit.SplitterDistance = 220;
        mainSplit.Panel1.Controls.Add(navLayout);
        mainSplit.Panel2.Controls.Add(tabMain);

        navLayout.Dock = DockStyle.Fill;
        navLayout.FlowDirection = FlowDirection.TopDown;
        navLayout.WrapContents = false;
        navLayout.Padding = new Padding(12);
        navLayout.Controls.Add(lblUsuario);
        navLayout.Controls.Add(btnNavPacientes);
        navLayout.Controls.Add(btnNavMedicos);
        navLayout.Controls.Add(btnNavCitas);
        navLayout.Controls.Add(btnNavEspecialidades);
        navLayout.Controls.Add(btnCerrarSesion);

        lblUsuario.AutoSize = true;
        lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblUsuario.Text = "Usuario: Admin";
        lblUsuario.Margin = new Padding(4, 4, 4, 16);

        btnNavPacientes.Text = "Pacientes";
        btnNavPacientes.Width = 180;
        btnNavMedicos.Text = "Médicos";
        btnNavMedicos.Width = 180;
        btnNavCitas.Text = "Citas";
        btnNavCitas.Width = 180;
        btnNavEspecialidades.Text = "Especialidades";
        btnNavEspecialidades.Width = 180;
        btnCerrarSesion.Text = "Cerrar sesión";
        btnCerrarSesion.Width = 180;
        btnCerrarSesion.Margin = new Padding(3, 24, 3, 3);

        tabMain.Dock = DockStyle.Fill;
        tabMain.TabPages.Add(tabPacientes);
        tabMain.TabPages.Add(tabMedicos);
        tabMain.TabPages.Add(tabCitas);
        tabMain.TabPages.Add(tabEspecialidades);

        tabPacientes.Text = "Pacientes";
        tabPacientes.Controls.Add(dgvPacientes);
        tabPacientes.Controls.Add(grpPaciente);

        dgvPacientes.Dock = DockStyle.Fill;
        dgvPacientes.BackgroundColor = SystemColors.Window;
        dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        grpPaciente.Dock = DockStyle.Bottom;
        grpPaciente.Height = 200;
        grpPaciente.Text = "Detalle Paciente";
        grpPaciente.Controls.Add(pacientesLayout);

        pacientesLayout.ColumnCount = 4;
        pacientesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        pacientesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        pacientesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        pacientesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        pacientesLayout.Dock = DockStyle.Fill;
        pacientesLayout.RowCount = 4;
        pacientesLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        pacientesLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        pacientesLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        pacientesLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        pacientesLayout.Controls.Add(new Label { Text = "Nombre", AutoSize = true }, 0, 0);
        pacientesLayout.Controls.Add(txtPacienteNombre, 1, 0);
        pacientesLayout.Controls.Add(new Label { Text = "Apellidos", AutoSize = true }, 2, 0);
        pacientesLayout.Controls.Add(txtPacienteApellidos, 3, 0);
        pacientesLayout.Controls.Add(new Label { Text = "CURP", AutoSize = true }, 0, 1);
        pacientesLayout.Controls.Add(txtPacienteCurp, 1, 1);
        pacientesLayout.Controls.Add(new Label { Text = "Fecha nacimiento", AutoSize = true }, 2, 1);
        pacientesLayout.Controls.Add(dtpPacienteNacimiento, 3, 1);
        pacientesLayout.Controls.Add(new Label { Text = "Prioridad", AutoSize = true }, 0, 2);
        pacientesLayout.Controls.Add(cboPacientePrioridad, 1, 2);
        pacientesLayout.Controls.Add(pacientesButtons, 0, 3);
        pacientesLayout.SetColumnSpan(pacientesButtons, 4);

        txtPacienteNombre.Dock = DockStyle.Fill;
        txtPacienteApellidos.Dock = DockStyle.Fill;
        txtPacienteCurp.Dock = DockStyle.Fill;
        dtpPacienteNacimiento.Dock = DockStyle.Fill;
        cboPacientePrioridad.Dock = DockStyle.Fill;
        cboPacientePrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPacientePrioridad.Items.AddRange(new object[] { "1 - URGENTE (URGENT)", "2 - ALTA (HIGH)", "3 - MEDIA (MEDIUM)", "4 - BAJA (LOW)" });

        pacientesButtons.FlowDirection = FlowDirection.LeftToRight;
        pacientesButtons.Dock = DockStyle.Fill;
        pacientesButtons.Controls.Add(btnPacienteNuevo);
        pacientesButtons.Controls.Add(btnPacienteGuardar);
        pacientesButtons.Controls.Add(btnPacienteEditar);
        pacientesButtons.Controls.Add(btnPacienteEliminar);
        pacientesButtons.Controls.Add(btnPacienteLimpiar);

        btnPacienteNuevo.Text = "Nuevo";
        btnPacienteGuardar.Text = "Guardar";
        btnPacienteEditar.Text = "Editar";
        btnPacienteEliminar.Text = "Eliminar";
        btnPacienteLimpiar.Text = "Limpiar";

        tabMedicos.Text = "Médicos";
        tabMedicos.Controls.Add(dgvMedicos);
        tabMedicos.Controls.Add(grpMedico);

        dgvMedicos.Dock = DockStyle.Fill;
        dgvMedicos.BackgroundColor = SystemColors.Window;
        dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        grpMedico.Dock = DockStyle.Bottom;
        grpMedico.Height = 220;
        grpMedico.Text = "Detalle Médico";
        grpMedico.Controls.Add(medicosLayout);

        medicosLayout.ColumnCount = 4;
        medicosLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        medicosLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        medicosLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        medicosLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        medicosLayout.Dock = DockStyle.Fill;
        medicosLayout.RowCount = 5;
        medicosLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        medicosLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        medicosLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        medicosLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        medicosLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        medicosLayout.Controls.Add(new Label { Text = "Nombre", AutoSize = true }, 0, 0);
        medicosLayout.Controls.Add(txtMedicoNombre, 1, 0);
        medicosLayout.Controls.Add(new Label { Text = "Apellidos", AutoSize = true }, 2, 0);
        medicosLayout.Controls.Add(txtMedicoApellidos, 3, 0);
        medicosLayout.Controls.Add(new Label { Text = "Teléfono", AutoSize = true }, 0, 1);
        medicosLayout.Controls.Add(txtMedicoTelefono, 1, 1);
        medicosLayout.Controls.Add(new Label { Text = "Email", AutoSize = true }, 2, 1);
        medicosLayout.Controls.Add(txtMedicoEmail, 3, 1);
        medicosLayout.Controls.Add(new Label { Text = "Cédula profesional", AutoSize = true }, 0, 2);
        medicosLayout.Controls.Add(txtMedicoCedula, 1, 2);
        medicosLayout.Controls.Add(new Label { Text = "Especialidad", AutoSize = true }, 2, 2);
        medicosLayout.Controls.Add(cboMedicoEspecialidad, 3, 2);
        medicosLayout.Controls.Add(new Label { Text = "Activo", AutoSize = true }, 0, 3);
        medicosLayout.Controls.Add(chkMedicoActivo, 1, 3);
        medicosLayout.Controls.Add(medicosButtons, 0, 4);
        medicosLayout.SetColumnSpan(medicosButtons, 4);

        txtMedicoNombre.Dock = DockStyle.Fill;
        txtMedicoApellidos.Dock = DockStyle.Fill;
        txtMedicoTelefono.Dock = DockStyle.Fill;
        txtMedicoEmail.Dock = DockStyle.Fill;
        txtMedicoCedula.Dock = DockStyle.Fill;
        cboMedicoEspecialidad.Dock = DockStyle.Fill;
        chkMedicoActivo.AutoSize = true;

        medicosButtons.FlowDirection = FlowDirection.LeftToRight;
        medicosButtons.Dock = DockStyle.Fill;
        medicosButtons.Controls.Add(btnMedicoNuevo);
        medicosButtons.Controls.Add(btnMedicoGuardar);
        medicosButtons.Controls.Add(btnMedicoEditar);
        medicosButtons.Controls.Add(btnMedicoEliminar);
        medicosButtons.Controls.Add(btnMedicoLimpiar);

        btnMedicoNuevo.Text = "Nuevo";
        btnMedicoGuardar.Text = "Guardar";
        btnMedicoEditar.Text = "Editar";
        btnMedicoEliminar.Text = "Eliminar";
        btnMedicoLimpiar.Text = "Limpiar";

        tabEspecialidades.Text = "Especialidades";
        tabEspecialidades.Controls.Add(dgvEspecialidades);
        tabEspecialidades.Controls.Add(grpEspecialidad);

        dgvEspecialidades.Dock = DockStyle.Fill;
        dgvEspecialidades.BackgroundColor = SystemColors.Window;
        dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        grpEspecialidad.Dock = DockStyle.Bottom;
        grpEspecialidad.Height = 160;
        grpEspecialidad.Text = "Detalle Especialidad";
        grpEspecialidad.Controls.Add(especialidadesLayout);

        especialidadesLayout.ColumnCount = 4;
        especialidadesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        especialidadesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        especialidadesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        especialidadesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        especialidadesLayout.Dock = DockStyle.Fill;
        especialidadesLayout.RowCount = 2;
        especialidadesLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        especialidadesLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        especialidadesLayout.Controls.Add(new Label { Text = "Nombre", AutoSize = true }, 0, 0);
        especialidadesLayout.Controls.Add(txtEspecialidadNombre, 1, 0);
        especialidadesLayout.Controls.Add(especialidadesButtons, 0, 1);
        especialidadesLayout.SetColumnSpan(especialidadesButtons, 4);

        txtEspecialidadNombre.Dock = DockStyle.Fill;

        especialidadesButtons.FlowDirection = FlowDirection.LeftToRight;
        especialidadesButtons.Dock = DockStyle.Fill;
        especialidadesButtons.Controls.Add(btnEspecialidadNuevo);
        especialidadesButtons.Controls.Add(btnEspecialidadGuardar);
        especialidadesButtons.Controls.Add(btnEspecialidadEditar);
        especialidadesButtons.Controls.Add(btnEspecialidadEliminar);
        especialidadesButtons.Controls.Add(btnEspecialidadLimpiar);

        btnEspecialidadNuevo.Text = "Nuevo";
        btnEspecialidadGuardar.Text = "Guardar";
        btnEspecialidadEditar.Text = "Editar";
        btnEspecialidadEliminar.Text = "Eliminar";
        btnEspecialidadLimpiar.Text = "Limpiar";

        tabCitas.Text = "Citas";
        tabCitas.Controls.Add(dgvCitas);
        tabCitas.Controls.Add(grpCita);

        dgvCitas.Dock = DockStyle.Fill;
        dgvCitas.BackgroundColor = SystemColors.Window;
        dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        grpCita.Dock = DockStyle.Bottom;
        grpCita.Height = 260;
        grpCita.Text = "Detalle Cita";
        grpCita.Controls.Add(citasLayout);

        citasLayout.ColumnCount = 4;
        citasLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        citasLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        citasLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        citasLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        citasLayout.Dock = DockStyle.Fill;
        citasLayout.RowCount = 4;
        citasLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        citasLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        citasLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        citasLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        citasLayout.Controls.Add(new Label { Text = "Paciente", AutoSize = true }, 0, 0);
        citasLayout.Controls.Add(cboCitaPaciente, 1, 0);
        citasLayout.Controls.Add(new Label { Text = "Médico", AutoSize = true }, 2, 0);
        citasLayout.Controls.Add(cboCitaMedico, 3, 0);
        citasLayout.Controls.Add(new Label { Text = "Fecha/Hora", AutoSize = true }, 0, 1);
        citasLayout.Controls.Add(dtpCitaFechaHora, 1, 1);
        citasLayout.Controls.Add(new Label { Text = "Estado", AutoSize = true }, 2, 1);
        citasLayout.Controls.Add(cboCitaEstado, 3, 1);
        citasLayout.Controls.Add(grpReceta, 0, 2);
        citasLayout.SetColumnSpan(grpReceta, 4);
        citasLayout.Controls.Add(citasButtons, 0, 3);
        citasLayout.SetColumnSpan(citasButtons, 4);

        cboCitaPaciente.Dock = DockStyle.Fill;
        cboCitaMedico.Dock = DockStyle.Fill;
        dtpCitaFechaHora.Dock = DockStyle.Fill;
        cboCitaEstado.Dock = DockStyle.Fill;
        cboCitaEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCitaEstado.Items.AddRange(new object[] { "PENDIENTE", "ATENDIDA", "CANCELADA" });

        grpReceta.Dock = DockStyle.Fill;
        grpReceta.Text = "Receta";
        grpReceta.Enabled = false;
        grpReceta.AccessibleName = "Receta";
        grpReceta.AccessibleDescription = "Deshabilitado: las recetas solo se capturan para citas atendidas";
        grpReceta.Controls.Add(recetaLayout);

        recetaLayout.ColumnCount = 2;
        recetaLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        recetaLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        recetaLayout.Dock = DockStyle.Fill;
        recetaLayout.RowCount = 3;
        recetaLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        recetaLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        recetaLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        recetaLayout.Controls.Add(new Label { Text = "Diagnóstico", AutoSize = true }, 0, 0);
        recetaLayout.Controls.Add(txtRecetaDiagnostico, 1, 0);
        recetaLayout.Controls.Add(new Label { Text = "Medicamento", AutoSize = true }, 0, 1);
        recetaLayout.Controls.Add(txtRecetaMedicamento, 1, 1);
        recetaLayout.Controls.Add(new Label { Text = "Dosis", AutoSize = true }, 0, 2);
        recetaLayout.Controls.Add(txtRecetaDosis, 1, 2);

        txtRecetaDiagnostico.Dock = DockStyle.Fill;
        txtRecetaMedicamento.Dock = DockStyle.Fill;
        txtRecetaDosis.Dock = DockStyle.Fill;

        citasButtons.FlowDirection = FlowDirection.LeftToRight;
        citasButtons.Dock = DockStyle.Fill;
        citasButtons.Controls.Add(btnCitaNuevo);
        citasButtons.Controls.Add(btnCitaGuardar);
        citasButtons.Controls.Add(btnCitaEditar);
        citasButtons.Controls.Add(btnCitaCancelar);
        citasButtons.Controls.Add(btnCitaLimpiar);

        btnCitaNuevo.Text = "Nuevo";
        btnCitaGuardar.Text = "Guardar";
        btnCitaEditar.Text = "Editar";
        btnCitaCancelar.Text = "Cancelar";
        btnCitaLimpiar.Text = "Limpiar";

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1280, 720);
        Controls.Add(mainSplit);
        Text = "Dashboard Admin";

        mainSplit.Panel1.ResumeLayout(false);
        mainSplit.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)mainSplit).EndInit();
        mainSplit.ResumeLayout(false);
        navLayout.ResumeLayout(false);
        navLayout.PerformLayout();
        tabMain.ResumeLayout(false);
        tabPacientes.ResumeLayout(false);
        tabMedicos.ResumeLayout(false);
        tabCitas.ResumeLayout(false);
        tabEspecialidades.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
        grpPaciente.ResumeLayout(false);
        pacientesLayout.ResumeLayout(false);
        pacientesLayout.PerformLayout();
        pacientesButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
        grpMedico.ResumeLayout(false);
        medicosLayout.ResumeLayout(false);
        medicosLayout.PerformLayout();
        medicosButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
        grpEspecialidad.ResumeLayout(false);
        especialidadesLayout.ResumeLayout(false);
        especialidadesLayout.PerformLayout();
        especialidadesButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
        grpCita.ResumeLayout(false);
        citasLayout.ResumeLayout(false);
        citasLayout.PerformLayout();
        grpReceta.ResumeLayout(false);
        recetaLayout.ResumeLayout(false);
        recetaLayout.PerformLayout();
        citasButtons.ResumeLayout(false);
        ResumeLayout(false);
    }
}
