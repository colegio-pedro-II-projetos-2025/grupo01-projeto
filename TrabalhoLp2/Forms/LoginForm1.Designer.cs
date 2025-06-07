namespace TrabalhoLp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            lbl_login_senha = new Label();
            lbl_login_email = new Label();
            lbl_criar = new Label();
            lbl_login = new Label();
            txt_lgn_email = new TextBox();
            btn_login = new Button();
            txt_lgn_senha = new TextBox();
            imageList1 = new ImageList(components);
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(lbl_login_senha);
            panel1.Controls.Add(lbl_login_email);
            panel1.Controls.Add(lbl_criar);
            panel1.Controls.Add(lbl_login);
            panel1.Controls.Add(txt_lgn_email);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(txt_lgn_senha);
            panel1.Location = new Point(190, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 500);
            panel1.TabIndex = 0;
            // 
            // lbl_login_senha
            // 
            lbl_login_senha.AutoSize = true;
            lbl_login_senha.ForeColor = SystemColors.Control;
            lbl_login_senha.Location = new Point(90, 173);
            lbl_login_senha.Name = "lbl_login_senha";
            lbl_login_senha.Size = new Size(39, 15);
            lbl_login_senha.TabIndex = 4;
            lbl_login_senha.Text = "Senha";
            // 
            // lbl_login_email
            // 
            lbl_login_email.AutoSize = true;
            lbl_login_email.ForeColor = SystemColors.Control;
            lbl_login_email.Location = new Point(90, 116);
            lbl_login_email.Name = "lbl_login_email";
            lbl_login_email.Size = new Size(36, 15);
            lbl_login_email.TabIndex = 4;
            lbl_login_email.Text = "Email";
            // 
            // lbl_criar
            // 
            lbl_criar.AutoSize = true;
            lbl_criar.ForeColor = SystemColors.Control;
            lbl_criar.Location = new Point(164, 464);
            lbl_criar.Name = "lbl_criar";
            lbl_criar.Size = new Size(65, 15);
            lbl_criar.TabIndex = 3;
            lbl_criar.Text = "Criar conta";
            lbl_criar.Click += label2_Click;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Lucida Console", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = SystemColors.Control;
            lbl_login.Location = new Point(34, 47);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(109, 32);
            lbl_login.TabIndex = 1;
            lbl_login.Text = "Login";
            lbl_login.Click += lbl_login_Click;
            // 
            // txt_lgn_email
            // 
            txt_lgn_email.Location = new Point(90, 134);
            txt_lgn_email.Name = "txt_lgn_email";
            txt_lgn_email.Size = new Size(220, 23);
            txt_lgn_email.TabIndex = 0;
            txt_lgn_email.TextChanged += textBox1_TextChanged;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(90, 276);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(220, 45);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_lgn_senha
            // 
            txt_lgn_senha.Location = new Point(90, 191);
            txt_lgn_senha.Name = "txt_lgn_senha";
            txt_lgn_senha.Size = new Size(220, 23);
            txt_lgn_senha.TabIndex = 0;
            txt_lgn_senha.TextChanged += textBox1_TextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "SUPER_BATTLE_LOGO.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 47);
            label1.Name = "label1";
            label1.Size = new Size(365, 65);
            label1.TabIndex = 1;
            label1.Text = "SUPER-BATTLE";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(784, 788);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Off;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txt_lgn_email;
        private Label lbl_login;
        private Label lbl_criar;
        private Button btn_login;
        private TextBox txt_lgn_senha;
        private Label lbl_login_senha;
        private Label lbl_login_email;
        private ImageList imageList1;
        private Label label1;
    }
}
