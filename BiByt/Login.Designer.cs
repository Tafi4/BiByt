namespace BiByt
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            UsernameText = new TextBox();
            PasswordText = new TextBox();
            UserAgreementBtn = new Button();
            LoginBtn = new Button();
            CreateAccountBtn = new Button();
            SuspendLayout();
            // 
            // UsernameText
            // 
            UsernameText.BackColor = SystemColors.InactiveBorder;
            UsernameText.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UsernameText.Location = new Point(103, 84);
            UsernameText.Margin = new Padding(4, 3, 4, 3);
            UsernameText.Multiline = true;
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(223, 36);
            UsernameText.TabIndex = 6;
            UsernameText.Text = "Логин ";
            UsernameText.TextAlign = HorizontalAlignment.Center;
            UsernameText.UseWaitCursor = true;
            // 
            // PasswordText
            // 
            PasswordText.BackColor = SystemColors.InactiveBorder;
            PasswordText.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PasswordText.Location = new Point(103, 128);
            PasswordText.Margin = new Padding(4, 3, 4, 3);
            PasswordText.Multiline = true;
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(223, 35);
            PasswordText.TabIndex = 8;
            PasswordText.Text = "Пароль";
            PasswordText.TextAlign = HorizontalAlignment.Center;
            PasswordText.UseWaitCursor = true;
            // 
            // UserAgreementBtn
            // 
            UserAgreementBtn.BackColor = SystemColors.ButtonFace;
            UserAgreementBtn.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserAgreementBtn.Location = new Point(103, 211);
            UserAgreementBtn.Margin = new Padding(4, 3, 4, 3);
            UserAgreementBtn.Name = "UserAgreementBtn";
            UserAgreementBtn.Size = new Size(107, 23);
            UserAgreementBtn.TabIndex = 11;
            UserAgreementBtn.Text = " соглашение";
            UserAgreementBtn.UseVisualStyleBackColor = false;
            UserAgreementBtn.Click += UserAgreementBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ButtonFace;
            LoginBtn.Location = new Point(103, 169);
            LoginBtn.Margin = new Padding(4, 3, 4, 3);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(224, 36);
            LoginBtn.TabIndex = 10;
            LoginBtn.Text = "Войти";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.BackColor = SystemColors.ButtonFace;
            CreateAccountBtn.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateAccountBtn.Location = new Point(216, 211);
            CreateAccountBtn.Margin = new Padding(4, 3, 4, 3);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(110, 23);
            CreateAccountBtn.TabIndex = 12;
            CreateAccountBtn.Text = "Создать акаунт";
            CreateAccountBtn.UseVisualStyleBackColor = false;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(436, 464);
            Controls.Add(CreateAccountBtn);
            Controls.Add(UserAgreementBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordText);
            Controls.Add(UsernameText);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button UserAgreementBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button CreateAccountBtn;
    }
}