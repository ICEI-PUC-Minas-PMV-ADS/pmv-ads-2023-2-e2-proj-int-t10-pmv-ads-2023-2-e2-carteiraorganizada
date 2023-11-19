using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C__VSCode.Models;

namespace C__VSCode.ViewModels
{
    public class BankAccountViewModel
    {
        public int Id  { get; set; }
        public decimal Bradesco { get; set; }
        public decimal Nubank { get; set; }
        public decimal Neon { get; set; }
        public decimal Salary { get; set; }


        public BankAccountViewModel()
        {
        }

        public BankAccountViewModel(BankAccount bankAccount)
        {
            Id = bankAccount.Id;
            Bradesco = bankAccount.Bradesco;
            Nubank = bankAccount.Nubank;
            Neon = bankAccount.Neon;
            Salary = bankAccount.Salary;
        }

        public decimal GetTotalBalance() 
        {
            return (Nubank + Bradesco + Neon);
        }
    }
}