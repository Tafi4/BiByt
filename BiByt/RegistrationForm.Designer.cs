namespace BiByt
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            AgreementButton = new Button();
            LoginButton = new Button();
            pictureBox1 = new PictureBox();
            CreateAccountButton = new Button();
            PasswordText = new TextBox();
            LoginText = new TextBox();
            ConfirmPasswordText = new TextBox();  // Заменили ConfimPassowordText на ConfirmPasswordText
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AgreementButton
            // 
            AgreementButton.BackColor = Color.FromArgb(247, 166, 0);
            AgreementButton.Cursor = Cursors.Hand;
            AgreementButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AgreementButton.Location = new Point(85, 318);
            AgreementButton.Name = "AgreementButton";
            AgreementButton.Size = new Size(110, 24);
            AgreementButton.TabIndex = 18;
            AgreementButton.Text = "соглашение";
            AgreementButton.UseVisualStyleBackColor = false;
            AgreementButton.Click += AgreementButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(247, 166, 0);
            LoginButton.BackgroundImageLayout = ImageLayout.None;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginButton.Location = new Point(201, 318);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(119, 24);
            LoginButton.TabIndex = 17;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.BackColor = Color.FromArgb(247, 166, 0);
            CreateAccountButton.Cursor = Cursors.Hand;
            CreateAccountButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateAccountButton.Location = new Point(85, 275);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(235, 37);
            CreateAccountButton.TabIndex = 15;
            CreateAccountButton.Text = "Создать акаунт";
            CreateAccountButton.UseVisualStyleBackColor = false;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // PasswordText
            // 
            PasswordText.BackColor = Color.FromArgb(247, 166, 0);
            PasswordText.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            PasswordText.Location = new Point(85, 183);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(235, 33);
            PasswordText.TabIndex = 14;
            PasswordText.Text = "Пароль";
            PasswordText.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginText
            // 
            LoginText.BackColor = Color.FromArgb(247, 166, 0);
            LoginText.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            LoginText.Location = new Point(85, 131);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(235, 33);
            LoginText.TabIndex = 13;
            LoginText.Text = "Логин";
            LoginText.TextAlign = HorizontalAlignment.Center;
            LoginText.TextChanged += LoginText_TextChanged;
            // 
            // ConfirmPasswordText
            // 
            ConfirmPasswordText.BackColor = Color.FromArgb(247, 166, 0);
            ConfirmPasswordText.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            ConfirmPasswordText.Location = new Point(85, 222);
            ConfirmPasswordText.Name = "ConfirmPasswordText";
            ConfirmPasswordText.Size = new Size(235, 33);
            ConfirmPasswordText.TabIndex = 19;
            ConfirmPasswordText.Text = "Повторите пароль";
            ConfirmPasswordText.TextAlign = HorizontalAlignment.Center;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(408, 450);
            Controls.Add(ConfirmPasswordText); // Изменили здесь
            Controls.Add(AgreementButton);
            Controls.Add(LoginButton);
            Controls.Add(pictureBox1);
            Controls.Add(CreateAccountButton);
            Controls.Add(PasswordText);
            Controls.Add(LoginText);
            Name = "RegistrationForm";
            Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AgreementButton;
        private Button LoginButton;
        private PictureBox pictureBox1;
        private Button CreateAccountButton;
        private TextBox PasswordText;
        private TextBox LoginText;
        private TextBox ConfirmPasswordText;

    }
}
