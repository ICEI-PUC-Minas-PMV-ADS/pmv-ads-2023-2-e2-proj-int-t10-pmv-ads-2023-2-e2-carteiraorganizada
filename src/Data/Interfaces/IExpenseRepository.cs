using C__VSCode.Models;

namespace C__VSCode.Data.Interfaces
{
    public interface IExpenseRepository
    {
        void Add(Expense expense);
        Expense GetById(int id);
        void Update(Expense expense);
    }
}