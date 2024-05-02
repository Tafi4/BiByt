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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string username = LoginText.Text;
            string password = PasswordText.Text;
            string confirmPassword = ConfirmPasswordText.Text;

            // Проверяем, если пароли совпадают
            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем, если такой логин уже существует
            if (UserExists(username))
            {
                MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем, что длина логина больше или равна 4 символам
            if (username.Length < 4)
            {
                MessageBox.Show("Логин должен содержать минимум 4 символа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем, что длина пароля больше или равна 5 символам
            if (password.Length < 5)
            {
                MessageBox.Show("Пароль должен содержать минимум 5 символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем, что пароль содержит хотя бы одну цифру
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну цифру!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем, что пароль содержит хотя бы одну заглавную букву
            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну заглавную букву!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем, что пароль содержит хотя бы одну прописную букву
            if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну прописную букву!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем, что пароль содержит хотя бы один специальный символ
            if (!password.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Пароль должен содержать хотя бы один специальный символ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Если все проверки пройдены успешно, создаем аккаунт
            // Здесь вы можете вызвать метод Create из класса Query
            MessageBox.Show("Аккаунт успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Метод для проверки существования пользователя с указанным логином
        private bool UserExists(string username)
        {
            // Здесь вы можете вызвать метод Get из класса Query, чтобы проверить существование пользователя
            // Вернуть true, если пользователь существует, и false в противном случае
            return false; // Временно возвращаем false для тестирования
        }

        private void AgreementButton_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр новой формы
            LoginForm anotherForm = new LoginForm();

            // Показываем новую форму
            anotherForm.Show();

            // Закрываем текущую форму (если это необходимо)
            this.Hide();
        }

        private void LoginText_TextChanged(object sender, EventArgs e)
        {
            String login_user = LoginText.Text;
            String login_password = PasswordText.Text;
        }
    }
}
