namespace BiByt
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            UsernameText = new TextBox();
            PasswordText = new TextBox();
            RegisterBtn = new Button();
            RepeatPasswordText = new TextBox();
            UserAgreementBtn = new Button();
            SuspendLayout();
            // 
            // UsernameText
            // 
            UsernameText.BackColor = SystemColors.InactiveBorder;
            UsernameText.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UsernameText.Location = new Point(101, 99);
            UsernameText.Margin = new Padding(4, 3, 4, 3);
            UsernameText.Multiline = true;
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(223, 36);
            UsernameText.TabIndex = 7;
            UsernameText.Text = "Логин ";
            UsernameText.TextAlign = HorizontalAlignment.Center;
            UsernameText.UseWaitCursor = true;
            // 
            // PasswordText
            // 
            PasswordText.BackColor = SystemColors.InactiveBorder;
            PasswordText.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PasswordText.Location = new Point(100, 141);
            PasswordText.Margin = new Padding(4, 3, 4, 3);
            PasswordText.Multiline = true;
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(223, 35);
            PasswordText.TabIndex = 9;
            PasswordText.Text = "Пароль";
            PasswordText.TextAlign = HorizontalAlignment.Center;
            PasswordText.UseWaitCursor = true;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = SystemColors.ButtonFace;
            RegisterBtn.Location = new Point(101, 223);
            RegisterBtn.Margin = new Padding(4, 3, 4, 3);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(224, 36);
            RegisterBtn.TabIndex = 11;
            RegisterBtn.Text = "Зарегистрироваться";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // RepeatPasswordText
            // 
            RepeatPasswordText.BackColor = SystemColors.InactiveBorder;
            RepeatPasswordText.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            RepeatPasswordText.Location = new Point(101, 182);
            RepeatPasswordText.Margin = new Padding(4, 3, 4, 3);
            RepeatPasswordText.Multiline = true;
            RepeatPasswordText.Name = "RepeatPasswordText";
            RepeatPasswordText.Size = new Size(223, 35);
            RepeatPasswordText.TabIndex = 12;
            RepeatPasswordText.Text = "Повторить пароль";
            RepeatPasswordText.TextAlign = HorizontalAlignment.Center;
            RepeatPasswordText.UseWaitCursor = true;
            // 
            // UserAgreementBtn
            // 
            UserAgreementBtn.BackColor = SystemColors.ButtonFace;
            UserAgreementBtn.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserAgreementBtn.Location = new Point(102, 265);
            UserAgreementBtn.Margin = new Padding(4, 3, 4, 3);
            UserAgreementBtn.Name = "UserAgreementBtn";
            UserAgreementBtn.Size = new Size(223, 23);
            UserAgreementBtn.TabIndex = 13;
            UserAgreementBtn.Text = "Пользовательское соглашение";
            UserAgreementBtn.UseVisualStyleBackColor = false;
            UserAgreementBtn.Click += UserAgreementBtn_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(436, 464);
            Controls.Add(UserAgreementBtn);
            Controls.Add(RepeatPasswordText);
            Controls.Add(RegisterBtn);
            Controls.Add(PasswordText);
            Controls.Add(UsernameText);
            Name = "Registration";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameText;
        private TextBox PasswordText;
        private Button RegisterBtn;
        private TextBox RepeatPasswordText;
        private Button UserAgreementBtn;
    }
}