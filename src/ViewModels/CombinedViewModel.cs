using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__VSCode.ViewModels
{
    public class CombinedViewModel
    {
        public BankAccountViewModel BankAccountViewModel{ get; set; }
        public ExpenseViewModel ExpenseViewModel{ get; set; }

        public CombinedViewModel(BankAccountViewModel bankAccountViewModel, ExpenseViewModel expenseViewModel)
        {
            BankAccountViewModel = bankAccountViewModel;
            ExpenseViewModel = expenseViewModel;
        }

        public decimal GetRevenue() 
        {
            return (BankAccountViewModel.Salary - ExpenseViewModel.GetTotalExpense());
        }
    }
}