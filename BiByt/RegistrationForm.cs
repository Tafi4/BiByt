using BiByt.Database;
using BiByt.Utils;
using AppContext = BiByt.Database.AppContext;

namespace BiByt;

public partial class RegistrationForm : Form
{
    public RegistrationForm()
    {
        InitializeComponent();
    }

    private void CreateAccountButton_Click(object sender, EventArgs e)
    {
        var username = LoginText.Text;
        var password = PasswordText.Text;
        var confirmPassword = ConfirmPasswordText.Text;

        const string requirements = "Пароль не соответсвует требованиям:" +
                                    "\n- Как минимум 6 символов" +
                                    "\n- Спепиальный символ" +
                                    "\n- Цифру" +
                                    "\n- Заглавную букву" +
                                    "\n- Прописную букву";

        if (password != confirmPassword)
        {
            MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (Registration.IsPasswordValid(password))
        {
            MessageBox.Show(requirements, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (Registration.IsUsernameAvailable(username))
        {
            MessageBox.Show("Такой логин уже занят.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        using (AppContext context = new AppContext())
        {
            var newUser = new User { Username = username, Password = password };
            context.Set<User>().Add(newUser);
            context.SaveChanges();
        }

        MessageBox.Show("Аккаунт успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        MenuForm redirectForm = new MenuForm();
        redirectForm.Show();
        Hide();
    }

    private void AgreementButton_Click(object sender, EventArgs e)
    {
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        LoginForm redirectForm = new LoginForm();
        redirectForm.Show();
        Hide();
    }
}