using BiByt.Database;
using static BiByt.Database.Transaction;
using AppContext = BiByt.Database.AppContext;

namespace BiByt
{
    public partial class AddTransactionForm : Form
    {
        public AddTransactionForm()
        {
            InitializeComponent();
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            var cost = AmountText.Text;
            var type = TypeTransBox.SelectedIndex;

            int number;
            if (int.TryParse(cost, out number))
            {
                using (AppContext context = new AppContext())
                {
                    Dictionary<int, TransactionType> test_dict = new Dictionary<int, TransactionType>() {
                        {  0, TransactionType.Translation },
                        {  1, TransactionType.Cash },
                        {  2, TransactionType.Clothes },
                        {  3, TransactionType.CarService },
                        {  4, TransactionType.Pharmacy },
                        {  5, TransactionType.House },
                        {  6, TransactionType.Other },
                     };
                    var user = context.Set<User>().FirstOrDefault(u => u.Username == Properties.Settings.Default.Username);
                    var newTrans = new Transaction { UserId = user.Id, Cost = number, Type = test_dict[type] };
                    context.Set<Transaction>().Add(newTrans);
                    context.SaveChanges();
                    MessageBox.Show("Транзакция добавлена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Сумма не является целым числом", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            MenuForm redirectForm = new MenuForm();
            redirectForm.Show();
            Hide();
        }
    }
}
