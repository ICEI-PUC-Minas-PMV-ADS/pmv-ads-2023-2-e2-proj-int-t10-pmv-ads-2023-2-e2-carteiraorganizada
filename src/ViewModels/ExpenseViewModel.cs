using C__VSCode.Models;

namespace C__VSCode.ViewModels
{
    public class ExpenseViewModel
    {
        public int Id { get; set; }
        public decimal Housing { get; set; }
        public decimal Studies { get; set; }
        public decimal Leisure { get; set; }
        public decimal Health { get; set; }

        public ExpenseViewModel() { }

        public ExpenseViewModel(Expense expense)
        {
            Id = expense.Id;
            Housing = expense.Housing;
            Studies = expense.Studies;
            Leisure = expense.Leisure;
            Health = expense.Health;
        }

        public decimal GetTotalExpense() 
        {
            return (Housing + Studies + Leisure + Health);
        }
    }
}
