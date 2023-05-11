namespace formularioTeste;

public partial class Form1 : Form
{   
    Button btnLogin;
    Label lblNome;
    TextBox txbLogin;
    Button btnClose;
    private TextBox txtNome;

    public Form1()
    {
        this.BackColor = System.Drawing.Color.LightGray;

        this.Text = "Formulario";

        this.ControlBox = false;
        this.MaximizeBox = false;
        this.MinimizeBox = false;

        this.MinimumSize = new Size(600, this.Height);
        this.MaximumSize = new Size(600, this.Height);

        this.MaximumSize = new Size(350, this.Width);
        this.MinimumSize = new Size(350, this.Width);

        this.lblNome = new Label();
        this.lblNome.Text = "Nome";
        lblNome.Location = new Point(150, 50);
        Controls.Add(lblNome);

        this.btnLogin = new Button();
        this.btnLogin.Text = "Olá";
        btnLogin.Location = new Point(95, 170);
        Controls.Add(btnLogin);
        btnLogin.Click += new EventHandler(btnLogin_Click);

        this.txtNome = new TextBox();
        txtNome.Location = new Point(120, 80);
        Controls.Add(txtNome);

        this.btnLogin = new Button();
        this.btnLogin.Text = "Enviar";
        btnLogin.Location = new Point(95, 170);
        Controls.Add(btnLogin);

        btnLogin.Click += new EventHandler(btnLogin_Click);

        this.btnClose = new Button();
        this.btnClose.Text = "Fechar";
        this.btnClose.Location = new Point(200,170);
        Controls.Add(btnClose);
        btnClose.Click += new EventHandler(BtnClose_Click);
    }


    private void BtnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

   private void btnLogin_Click(object sender, EventArgs e)
    {
        string nome = txtNome.Text;
        MessageBox.Show("Olá, " + nome + "!");
    }

}
