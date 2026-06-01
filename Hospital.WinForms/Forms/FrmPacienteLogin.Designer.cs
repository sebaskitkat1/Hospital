namespace Hospital.WinForms;

partial class FrmPacienteLogin
{
    private System.ComponentModel.IContainer components = null;
    private Panel cardPanel;
    private TableLayoutPanel loginLayout;
    private Label lblTitulo;
    private Label lblCurp;
    private TextBox txtCurp;
    private Label lblNacimiento;
    private DateTimePicker dtpNacimiento;
    private Button btnValidar;

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
        cardPanel = new Panel();
        loginLayout = new TableLayoutPanel();
        lblTitulo = new Label();
        lblCurp = new Label();
        txtCurp = new TextBox();
        lblNacimiento = new Label();
        dtpNacimiento = new DateTimePicker();
        btnValidar = new Button();
        cardPanel.SuspendLayout();
        loginLayout.SuspendLayout();
        SuspendLayout();

        cardPanel.BorderStyle = BorderStyle.FixedSingle;
        cardPanel.Controls.Add(loginLayout);
        cardPanel.Size = new Size(420, 280);
        cardPanel.Location = new Point(190, 140);
        cardPanel.Padding = new Padding(16);

        loginLayout.ColumnCount = 2;
        loginLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        loginLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        loginLayout.Dock = DockStyle.Fill;
        loginLayout.RowCount = 4;
        loginLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        loginLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        loginLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        loginLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        loginLayout.Controls.Add(lblTitulo, 0, 0);
        loginLayout.SetColumnSpan(lblTitulo, 2);
        loginLayout.Controls.Add(lblCurp, 0, 1);
        loginLayout.Controls.Add(txtCurp, 1, 1);
        loginLayout.Controls.Add(lblNacimiento, 0, 2);
        loginLayout.Controls.Add(dtpNacimiento, 1, 2);
        loginLayout.Controls.Add(btnValidar, 1, 3);

        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitulo.Text = "Ingreso de Paciente";
        lblTitulo.Margin = new Padding(0, 0, 0, 12);

        lblCurp.AutoSize = true;
        lblCurp.Text = "CURP";
        lblCurp.Anchor = AnchorStyles.Left;

        txtCurp.Dock = DockStyle.Fill;

        lblNacimiento.AutoSize = true;
        lblNacimiento.Text = "Fecha de nacimiento";
        lblNacimiento.Anchor = AnchorStyles.Left;

        dtpNacimiento.Dock = DockStyle.Fill;

        btnValidar.Text = "Validar";
        btnValidar.Anchor = AnchorStyles.Right;
        btnValidar.Size = new Size(120, 34);

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 560);
        Controls.Add(cardPanel);
        Text = "Ingreso de Paciente";
        cardPanel.ResumeLayout(false);
        loginLayout.ResumeLayout(false);
        loginLayout.PerformLayout();
        ResumeLayout(false);
    }
}
