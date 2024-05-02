using BiByt.Database;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Security.Policy;
using AppContext = BiByt.Database.AppContext;

namespace BiByt
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {

        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В вашем регионе недоступна эта функция", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ExpensesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В вашем регионе недоступна эта функция", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            AddTransactionForm redirectForm = new AddTransactionForm();
            redirectForm.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = null;
            Properties.Settings.Default.Password = null;
            Properties.Settings.Default.IsLogged = false;
            Properties.Settings.Default.Save();

            LoginForm redirectForm = new LoginForm();
            redirectForm.Show();
            Hide();
        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            var url = "https://www.tinkoff.ru/cf/9eWD57cJ2Rx";

            Clipboard.SetText(url);
            MessageBox.Show($"Отличный выбор! А теперь ты можешь (нужно) скинуть деньги: {url}", "Дай деняк", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            using (AppContext context = new AppContext())
            {
                context.Database.EnsureCreated();
                var user = context.Set<Database.User>().FirstOrDefault(u => u.Username == Properties.Settings.Default.Username);
                var items = context.Transactions.Where(item => item.UserId == user.Id);
                foreach (var item in items)
                {
                    ListTransactions.Items.Add($"[{item.Id}] {item.Type} - {item.Cost}");
                }
            }
        }
    }
}
