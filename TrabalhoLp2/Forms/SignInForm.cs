using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoLp2.Entidade;
using TrabalhoLp2.Repositorio;
using TrabalhoLp2.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrabalhoLp2.Forms
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Z:\programação\TrabalhoLp2\Imagem\Design sem nome.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_cadastrar_Click_2(object sender, EventArgs e)
        {
            string nome = txt_cadastro_nome.Text;
            string email = txt_email_cadastro.Text;
            string senha = txt_cadastro_senha.Text;
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lbl_atention.Text = "Email inválido.";
                return;
            }
            if (senha.Length < 6)
            {
                lbl_atention.Text = "A senha deve ter pelo menos 6 caracteres.";
                return;
            }

            if (nome.Length < 3)
            {
                lbl_atention.Text = "O nome de usuário deve ter pelo menos 3 caracteres.";
                return;
            }
            UsuarioRepository repo = new UsuarioRepository(DbUtil.ConnectionString);
            Usuario novoUsuario = new Usuario
            {
                Email = email,
                Nome = nome,
                Senha = senha
            };

            try
            {
                int linhas = repo.InserirUsuario(novoUsuario);
                if (linhas > 0)
                {
                    lbl_atention.ForeColor = Color.Green;
                    lbl_atention.Text = "Usuário cadastrado com sucesso!";
                    LimparCampos();
                }
                else
                {
                    lbl_atention.Text = "Erro ao cadastrar.";
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                if (ex.Number == 1062)
                    lbl_atention.Text = "Já existe um usuário com este e-mail.";
            }
            catch (Exception ex)
            {
                lbl_atention.Text = "Erro inesperado: " + ex.Message;
            }
            MessageBox.Show("Usuário cadastrado com sucesso!");
        }
        private void LimparCampos()
        {
            txt_cadastro_nome.Text = "";
            txt_cadastro_senha.Text = "";
            txt_email_cadastro.Text = "";

        }

        private void lbl_cadastrar_nome_Click(object sender, EventArgs e)
        {

        }
    }
}
