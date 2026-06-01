namespace Hospital.WinForms;

partial class FrmStaffLogin
{
    private System.ComponentModel.IContainer components = null;
    private Panel cardPanel;
    private TableLayoutPanel loginLayout;
    private Label lblTitulo;
    private Label lblUsuario;
    private TextBox txtUsuario;
    private Label lblContrasena;
    private TextBox txtContrasena;
    private Button btnIngresar;
    private LinkLabel lnkOlvido;

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
        lblUsuario = new Label();
        txtUsuario = new TextBox();
        lblContrasena = new Label();
        txtContrasena = new TextBox();
        btnIngresar = new Button();
        lnkOlvido = new LinkLabel();
        cardPanel.SuspendLayout();
        loginLayout.SuspendLayout();
        SuspendLayout();

        cardPanel.BorderStyle = BorderStyle.FixedSingle;
        cardPanel.Controls.Add(loginLayout);
        cardPanel.Size = new Size(420, 320);
        cardPanel.Location = new Point(190, 120);
        cardPanel.Padding = new Padding(16);

        loginLayout.ColumnCount = 2;
        loginLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        loginLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        loginLayout.Dock = DockStyle.Fill;
        loginLayout.RowCount = 5;
        loginLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        loginLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        loginLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        loginLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        loginLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        loginLayout.Controls.Add(lblTitulo, 0, 0);
        loginLayout.SetColumnSpan(lblTitulo, 2);
        loginLayout.Controls.Add(lblUsuario, 0, 1);
        loginLayout.Controls.Add(txtUsuario, 1, 1);
        loginLayout.Controls.Add(lblContrasena, 0, 2);
        loginLayout.Controls.Add(txtContrasena, 1, 2);
        loginLayout.Controls.Add(btnIngresar, 1, 3);
        loginLayout.Controls.Add(lnkOlvido, 1, 4);

        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitulo.Text = "Ingreso de Personal";
        lblTitulo.Margin = new Padding(0, 0, 0, 12);

        lblUsuario.AutoSize = true;
        lblUsuario.Text = "Usuario";
        lblUsuario.Anchor = AnchorStyles.Left;

        txtUsuario.Dock = DockStyle.Fill;

        lblContrasena.AutoSize = true;
        lblContrasena.Text = "Contraseña";
        lblContrasena.Anchor = AnchorStyles.Left;

        txtContrasena.Dock = DockStyle.Fill;
        txtContrasena.UseSystemPasswordChar = true;

        btnIngresar.Text = "Iniciar sesión";
        btnIngresar.Anchor = AnchorStyles.Right;
        btnIngresar.Size = new Size(140, 34);

        lnkOlvido.Text = "¿Olvidaste tu contraseña?";
        lnkOlvido.AutoSize = true;
        lnkOlvido.Anchor = AnchorStyles.Right;

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 560);
        Controls.Add(cardPanel);
        Text = "Ingreso de Personal";
        cardPanel.ResumeLayout(false);
        loginLayout.ResumeLayout(false);
        loginLayout.PerformLayout();
        ResumeLayout(false);
    }
}
