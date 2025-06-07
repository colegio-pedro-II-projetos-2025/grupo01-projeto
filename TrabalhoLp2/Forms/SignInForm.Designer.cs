namespace TrabalhoLp2.Forms
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_cadastro_nome = new TextBox();
            txt_email_cadastro = new TextBox();
            txt_cadastro_senha = new TextBox();
            btn_cadastrar = new Button();
            lbl_cadastrar_nome = new Label();
            lbl_cadastrar_email = new Label();
            lbl_atention = new Label();
            lbl_cadastrar_senha = new Label();
            SuspendLayout();
            // 
            // txt_cadastro_nome
            // 
            txt_cadastro_nome.Location = new Point(153, 120);
            txt_cadastro_nome.Name = "txt_cadastro_nome";
            txt_cadastro_nome.Size = new Size(239, 23);
            txt_cadastro_nome.TabIndex = 0;
            // 
            // txt_email_cadastro
            // 
            txt_email_cadastro.Location = new Point(153, 179);
            txt_email_cadastro.Name = "txt_email_cadastro";
            txt_email_cadastro.Size = new Size(239, 23);
            txt_email_cadastro.TabIndex = 0;
            // 
            // txt_cadastro_senha
            // 
            txt_cadastro_senha.Location = new Point(151, 244);
            txt_cadastro_senha.Name = "txt_cadastro_senha";
            txt_cadastro_senha.Size = new Size(239, 23);
            txt_cadastro_senha.TabIndex = 0;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.FromArgb(0, 192, 0);
            btn_cadastrar.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadastrar.Location = new Point(163, 324);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(220, 62);
            btn_cadastrar.TabIndex = 1;
            btn_cadastrar.Text = "CADASTRAR";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click_2;
            // 
            // lbl_cadastrar_nome
            // 
            lbl_cadastrar_nome.AutoSize = true;
            lbl_cadastrar_nome.Location = new Point(153, 102);
            lbl_cadastrar_nome.Name = "lbl_cadastrar_nome";
            lbl_cadastrar_nome.Size = new Size(40, 15);
            lbl_cadastrar_nome.TabIndex = 2;
            lbl_cadastrar_nome.Text = "Nome";
            lbl_cadastrar_nome.Click += lbl_cadastrar_nome_Click;
            // 
            // lbl_cadastrar_email
            // 
            lbl_cadastrar_email.AutoSize = true;
            lbl_cadastrar_email.Location = new Point(153, 161);
            lbl_cadastrar_email.Name = "lbl_cadastrar_email";
            lbl_cadastrar_email.Size = new Size(36, 15);
            lbl_cadastrar_email.TabIndex = 2;
            lbl_cadastrar_email.Text = "Email";
            // 
            // lbl_atention
            // 
            lbl_atention.AutoSize = true;
            lbl_atention.Location = new Point(325, 226);
            lbl_atention.Name = "lbl_atention";
            lbl_atention.Size = new Size(0, 15);
            lbl_atention.TabIndex = 2;
            // 
            // lbl_cadastrar_senha
            // 
            lbl_cadastrar_senha.AutoSize = true;
            lbl_cadastrar_senha.Location = new Point(151, 226);
            lbl_cadastrar_senha.Name = "lbl_cadastrar_senha";
            lbl_cadastrar_senha.Size = new Size(39, 15);
            lbl_cadastrar_senha.TabIndex = 2;
            lbl_cadastrar_senha.Text = "Senha";
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 566);
            Controls.Add(lbl_atention);
            Controls.Add(lbl_cadastrar_senha);
            Controls.Add(lbl_cadastrar_email);
            Controls.Add(lbl_cadastrar_nome);
            Controls.Add(btn_cadastrar);
            Controls.Add(txt_cadastro_senha);
            Controls.Add(txt_email_cadastro);
            Controls.Add(txt_cadastro_nome);
            Name = "SignInForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_cadastro_nome;
        private TextBox txt_email_cadastro;
        private TextBox txt_cadastro_senha;
        private Button btn_cadastrar;
        private Label lbl_cadastrar_nome;
        private Label lbl_cadastrar_email;
        private Label lbl_atention;
        private Label lbl_cadastrar_senha;
    }
}