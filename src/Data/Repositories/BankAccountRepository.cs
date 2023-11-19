using C__VSCode.Data.Interfaces;
using C__VSCode.Models;

namespace C__VSCode.Data.Repositories
{
   

    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly BaseDbContext _context;

        public BankAccountRepository(BaseDbContext context)
        {
            _context = context;
        }

        public void Add(BankAccount bankAccount)
        {
            _context.BankAccounts.Add(bankAccount);
            _context.SaveChanges();
        }

        public BankAccount GetById(int id)
        {
            return _context.BankAccounts.FirstOrDefault(e => e.Id == id);
        }

        public void Update(BankAccount bankAccount)
        {
            _context.BankAccounts.Update(bankAccount);
            _context.SaveChanges();
        }
    }
}
