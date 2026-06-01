namespace Hospital.WinForms;

partial class FrmPortalInicio
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel mainLayout;
    private Panel headerPanel;
    private Label lblTitulo;
    private PictureBox picLogo;
    private TableLayoutPanel cardsLayout;
    private Panel cardPersonal;
    private Panel cardPaciente;
    private TableLayoutPanel cardPersonalLayout;
    private TableLayoutPanel cardPacienteLayout;
    private Label lblPersonalTitulo;
    private Label lblPersonalDescripcion;
    private Button btnIngresoPersonal;
    private Label lblPacienteTitulo;
    private Label lblPacienteDescripcion;
    private Button btnIngresoPaciente;

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
        mainLayout = new TableLayoutPanel();
        headerPanel = new Panel();
        lblTitulo = new Label();
        picLogo = new PictureBox();
        cardsLayout = new TableLayoutPanel();
        cardPersonal = new Panel();
        cardPaciente = new Panel();
        cardPersonalLayout = new TableLayoutPanel();
        cardPacienteLayout = new TableLayoutPanel();
        lblPersonalTitulo = new Label();
        lblPersonalDescripcion = new Label();
        btnIngresoPersonal = new Button();
        lblPacienteTitulo = new Label();
        lblPacienteDescripcion = new Label();
        btnIngresoPaciente = new Button();
        mainLayout.SuspendLayout();
        headerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        cardsLayout.SuspendLayout();
        cardPersonal.SuspendLayout();
        cardPaciente.SuspendLayout();
        cardPersonalLayout.SuspendLayout();
        cardPacienteLayout.SuspendLayout();
        SuspendLayout();
        
        mainLayout.ColumnCount = 1;
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.RowCount = 2;
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        mainLayout.Controls.Add(headerPanel, 0, 0);
        mainLayout.Controls.Add(cardsLayout, 0, 1);

        headerPanel.Dock = DockStyle.Fill;
        headerPanel.Padding = new Padding(16);
        headerPanel.Controls.Add(lblTitulo);
        headerPanel.Controls.Add(picLogo);

        picLogo.Location = new Point(16, 16);
        picLogo.Size = new Size(80, 80);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabStop = false;

        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitulo.Location = new Point(112, 38);
        lblTitulo.Text = "Sistema Hospitalario";

        cardsLayout.ColumnCount = 2;
        cardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        cardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        cardsLayout.Dock = DockStyle.Fill;
        cardsLayout.Padding = new Padding(16);
        cardsLayout.RowCount = 1;
        cardsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        cardsLayout.Controls.Add(cardPersonal, 0, 0);
        cardsLayout.Controls.Add(cardPaciente, 1, 0);

        cardPersonal.BorderStyle = BorderStyle.FixedSingle;
        cardPersonal.Dock = DockStyle.Fill;
        cardPersonal.Padding = new Padding(16);
        cardPersonal.Controls.Add(cardPersonalLayout);

        cardPersonalLayout.ColumnCount = 1;
        cardPersonalLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        cardPersonalLayout.Dock = DockStyle.Fill;
        cardPersonalLayout.RowCount = 3;
        cardPersonalLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        cardPersonalLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        cardPersonalLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        cardPersonalLayout.Controls.Add(lblPersonalTitulo, 0, 0);
        cardPersonalLayout.Controls.Add(lblPersonalDescripcion, 0, 1);
        cardPersonalLayout.Controls.Add(btnIngresoPersonal, 0, 2);

        lblPersonalTitulo.AutoSize = true;
        lblPersonalTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        lblPersonalTitulo.Text = "Ingreso como Personal";

        lblPersonalDescripcion.Dock = DockStyle.Fill;
        lblPersonalDescripcion.Text = "Acceso para administrativos, médicos y personal autorizado.";

        btnIngresoPersonal.Anchor = AnchorStyles.Right;
        btnIngresoPersonal.Text = "Ingreso como Personal";
        btnIngresoPersonal.Size = new Size(200, 36);

        cardPaciente.BorderStyle = BorderStyle.FixedSingle;
        cardPaciente.Dock = DockStyle.Fill;
        cardPaciente.Padding = new Padding(16);
        cardPaciente.Controls.Add(cardPacienteLayout);

        cardPacienteLayout.ColumnCount = 1;
        cardPacienteLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        cardPacienteLayout.Dock = DockStyle.Fill;
        cardPacienteLayout.RowCount = 3;
        cardPacienteLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        cardPacienteLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        cardPacienteLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        cardPacienteLayout.Controls.Add(lblPacienteTitulo, 0, 0);
        cardPacienteLayout.Controls.Add(lblPacienteDescripcion, 0, 1);
        cardPacienteLayout.Controls.Add(btnIngresoPaciente, 0, 2);

        lblPacienteTitulo.AutoSize = true;
        lblPacienteTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        lblPacienteTitulo.Text = "Ingreso como Paciente";

        lblPacienteDescripcion.Dock = DockStyle.Fill;
        lblPacienteDescripcion.Text = "Portal de autoservicio para pacientes.";

        btnIngresoPaciente.Anchor = AnchorStyles.Right;
        btnIngresoPaciente.Text = "Ingreso como Paciente";
        btnIngresoPaciente.Size = new Size(200, 36);

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 650);
        Controls.Add(mainLayout);
        Text = "Portal de Inicio";
        mainLayout.ResumeLayout(false);
        headerPanel.ResumeLayout(false);
        headerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        cardsLayout.ResumeLayout(false);
        cardPersonal.ResumeLayout(false);
        cardPaciente.ResumeLayout(false);
        cardPersonalLayout.ResumeLayout(false);
        cardPersonalLayout.PerformLayout();
        cardPacienteLayout.ResumeLayout(false);
        cardPacienteLayout.PerformLayout();
        ResumeLayout(false);
    }
}
