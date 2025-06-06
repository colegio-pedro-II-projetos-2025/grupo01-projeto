using TrabalhoLp2.Entidade;
using TrabalhoLp2.Forms;
using TrabalhoLp2.Repositorio;
using TrabalhoLp2.Util;

namespace TrabalhoLp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\Trabalho de LP2\TrabalhoLp2\TrabalhoLp2\Imagem\Design sem nome (1).jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void login_img_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            SignInForm signIn = new SignInForm();
            signIn.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_lgn_email.Text.Trim();
            string senha = txt_lgn_senha.Text;

            UsuarioRepository repo = new UsuarioRepository(DbUtil.ConnectionString);
            Usuario usuario = repo.ObterPorEmailESenha(email, senha);

            if (usuario != null)
            {
                MainForm main = new MainForm(usuario);
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas! Tente novamente.");
            }
        }
    }
}
