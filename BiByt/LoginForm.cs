using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiByt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginText.Text;
            string password = PasswordText.Text;

            // Проверяем логин и пароль
            if (CheckLogin(username, password))
            {
                // Если успешно, переходим на другую форму
                menu anotherForm = new menu();
                anotherForm.Show();
                this.Hide();
            }
            else
            {
                // Если не успешно, выводим сообщение об ошибке
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void AgreementButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            RegistrationForm anotherForm = new RegistrationForm();

            anotherForm.Show();

            this.Hide();
        }

        private void LoginText_TextChanged(object sender, EventArgs e)
        {

        }

        private bool CheckLogin(string username, string password)
        {
            // Здесь вы можете добавить код для подключения к базе данных и выполнить запрос для проверки логина и пароля.
            // Пока просто сравним введенные значения с временными значениями.
            string tempUsername = "user";
            string tempPassword = "password";

            if (username == tempUsername && password == tempPassword)
                return true;
            else
                return false;
        }
    }
}
