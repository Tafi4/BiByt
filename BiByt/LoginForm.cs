using BiByt.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BiByt;

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

        if (Login.IsCredentialsValid(username, password))
        {
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.IsLogged = true;
            Properties.Settings.Default.Save();

            MenuForm redirectForm = new MenuForm();
            redirectForm.Show();
            Hide();
        }
        else
            MessageBox.Show("Неверный логин или пароль");
    }

    private void AgreementButton_Click(object sender, EventArgs e)
    {

    }

    private void CreateAccountButton_Click(object sender, EventArgs e)
    {
        RegistrationForm redirectForm = new RegistrationForm();
        redirectForm.Show();
        Hide();
    }

    private void LoginForm_Shown(object sender, EventArgs e)
    {
        if (Properties.Settings.Default.IsLogged)
        {
            string username = Properties.Settings.Default.Username;
            string password = Properties.Settings.Default.Password;
            if (Login.IsCredentialsValid(username, password))
            {
                MenuForm redirectForm = new MenuForm();
                redirectForm.Show();
                this.Hide();
            }
            else
            {
                Properties.Settings.Default.Username = null;
                Properties.Settings.Default.Password = null;
                Properties.Settings.Default.IsLogged = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("Вы вышли из аккаунт, т.к. пароль был изменен");
            }
        }
    }
}
