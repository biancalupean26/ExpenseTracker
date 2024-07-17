using ExpenseTracker.Models;

namespace ExpenseTracker.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Expense> Expenses { get; set; }

        public List<Income> Icomes { get; set; }
    }
}
