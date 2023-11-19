using C__VSCode.Models;

namespace C__VSCode.Data.Interfaces
{
     public interface IBankAccountRepository
    {
        void Add(BankAccount bankAccount);
        void Update(BankAccount bankAccount);
        BankAccount GetById(int id);
    }
}