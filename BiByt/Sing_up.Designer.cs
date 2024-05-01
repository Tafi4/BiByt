namespace BiByt
{
    partial class Sing_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sing_up));
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(247, 166, 0);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(85, 318);
            button3.Name = "button3";
            button3.Size = new Size(110, 24);
            button3.TabIndex = 18;
            button3.Text = "соглашение";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(247, 166, 0);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(201, 318);
            button2.Name = "button2";
            button2.Size = new Size(119, 24);
            button2.TabIndex = 17;
            button2.Text = "Войти";
            button2.UseVisualStyleBackColor = false;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(247, 166, 0);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(85, 275);
            button1.Name = "button1";
            button1.Size = new Size(235, 37);
            button1.TabIndex = 15;
            button1.Text = "Создать акаунт";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(247, 166, 0);
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(85, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 33);
            textBox2.TabIndex = 14;
            textBox2.Text = "Пароль";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(247, 166, 0);
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(85, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 33);
            textBox1.TabIndex = 13;
            textBox1.Text = "Логин";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(247, 166, 0);
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(85, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 33);
            textBox3.TabIndex = 19;
            textBox3.Text = "Повторите пароль";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Sing_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(408, 450);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Sing_up";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}