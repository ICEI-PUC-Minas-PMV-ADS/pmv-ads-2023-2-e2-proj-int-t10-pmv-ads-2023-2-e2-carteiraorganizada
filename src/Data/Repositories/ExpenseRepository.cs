using C__VSCode.Data.Interfaces;
using C__VSCode.Models;

namespace C__VSCode.Data.Repositories
{

    public class ExpenseRepository : IExpenseRepository
    {
        private readonly BaseDbContext _context;

        public ExpenseRepository(BaseDbContext context)
        {
            _context = context;
        }

        public void Add(Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges();
        }

        public Expense GetById(int id)
        {
            return _context.Expenses.FirstOrDefault(e => e.Id == id);
        }

        public void Update(Expense expense)
        {
            _context.Expenses.Update(expense);
            _context.SaveChanges();
        }
    }
}
