using TrabalhoLp2.Entidade;
using TrabalhoLp2.Forms;
using TrabalhoLp2.Repositorio;
using TrabalhoLp2.Util;
using System.Drawing.Text;
using Org.BouncyCastle.Asn1.Pkcs;
using System.Runtime.InteropServices;
using System.Media;

namespace TrabalhoLp2
{
    public partial class Form1 : Form
    {
        PrivateFontCollection fontesPersonalizadas = new PrivateFontCollection();
        private SoundPlayer player;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\seuUsuario\Desktop\projetolp4\grupo01-projeto\Imagem\fundo_tijolo.jpeg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            LoadCustomFont();
            label1.Font = new Font(fontesPersonalizadas.Families[0], 32f);
            label1.ForeColor = Color.Orange;
            label1.BackColor = Color.Black;
            label1.Width = 365;
            label1.Height = 65;
            label1.Location = new Point(135, 60);

            string caminhoAudio = @"C:\Users\seuUsuario\Desktop\projetolp4\grupo01-projeto\Audios\Ogre Boss (online-audio-converter.com).wav";
            player = new SoundPlayer(caminhoAudio);
            player.Load();
            player.PlayLooping();
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

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            PrivateFontCollection fontesPersonalizadas = new PrivateFontCollection();
            string caminhoFonte = @"C:\Users\seuUsuario\Desktop\projetolp4\grupo01-projeto\Fonte_Press_Start_2P\PressStart2P-Regular.ttf";

            if (File.Exists(caminhoFonte))
            {

                fontesPersonalizadas.AddFontFile(caminhoFonte);

                Font fontePixel = new Font(fontesPersonalizadas.Families[0], 16);

                label1.Font = fontePixel;
                label1.Text = "SUPER-BATTLE";
                label1.ForeColor = Color.Orange;
                label1.BackColor = Color.Black;
                label1.Width = 365;
                label1.Height = 65;
                label1.Location = new Point(135, 60);
                label1.Font = new Font(fontesPersonalizadas.Families[0], 32f);


            }
            else
            {
                MessageBox.Show("Fonte não encontrada: " + caminhoFonte);
            }
        }
        private void LoadCustomFont()
        {
            string fontPath = @"C:\Users\seuUsuario\Desktop\projetolp4\grupo01-projeto\Fonte_Press_Start_2P\PressStart2P-Regular.ttf";

            byte[] fontData = System.IO.File.ReadAllBytes(fontPath);
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            fontesPersonalizadas.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);
        }
    }
}
