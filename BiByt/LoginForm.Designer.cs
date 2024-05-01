namespace BiByt
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginText = new TextBox();
            PasswordText = new TextBox();
            LoginButton = new Button();
            pictureBox1 = new PictureBox();
            CreateAccountButton = new Button();
            AgreementButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginText
            // 
            LoginText.BackColor = Color.FromArgb(247, 166, 0);
            LoginText.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            LoginText.Location = new Point(74, 121);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(235, 33);
            LoginText.TabIndex = 0;
            LoginText.Text = "Логин";
            LoginText.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordText
            // 
            PasswordText.BackColor = Color.FromArgb(247, 166, 0);
            PasswordText.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            PasswordText.Location = new Point(74, 160);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(235, 33);
            PasswordText.TabIndex = 1;
            PasswordText.Text = "Пароль";
            PasswordText.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(247, 166, 0);
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginButton.Location = new Point(74, 223);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(235, 37);
            LoginButton.TabIndex = 9;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(138, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.BackColor = Color.FromArgb(247, 166, 0);
            CreateAccountButton.BackgroundImageLayout = ImageLayout.None;
            CreateAccountButton.Cursor = Cursors.Hand;
            CreateAccountButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateAccountButton.Location = new Point(190, 266);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(119, 24);
            CreateAccountButton.TabIndex = 11;
            CreateAccountButton.Text = "создать акаунт";
            CreateAccountButton.UseVisualStyleBackColor = false;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // AgreementButton
            // 
            AgreementButton.BackColor = Color.FromArgb(247, 166, 0);
            AgreementButton.Cursor = Cursors.Hand;
            AgreementButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AgreementButton.Location = new Point(74, 266);
            AgreementButton.Name = "AgreementButton";
            AgreementButton.Size = new Size(110, 24);
            AgreementButton.TabIndex = 12;
            AgreementButton.Text = "соглашение";
            AgreementButton.UseVisualStyleBackColor = false;
            AgreementButton.Click += AgreementButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(411, 442);
            Controls.Add(AgreementButton);
            Controls.Add(CreateAccountButton);
            Controls.Add(pictureBox1);
            Controls.Add(LoginButton);
            Controls.Add(PasswordText);
            Controls.Add(LoginText);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginText;
        private TextBox PasswordText;
        private Button LoginButton;
        private PictureBox pictureBox1;
        private Button CreateAccountButton;
        private Button AgreementButton;
    }
}