namespace ExpenseTracker.Data.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool Planned { get; set; }

        public int CategoryId { get; set; } // Cheia străină pentru Category

        public Category Category { get; set; }
    }
}
