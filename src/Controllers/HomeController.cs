using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using C__VSCode.ViewModels;
using C__VSCode.Data.Repositories;
using C__VSCode.Models;
using C__VSCode.Data.Interfaces;
using Microsoft.VisualBasic;

namespace C__VSCode.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IExpenseRepository _expenseRepository;
    private readonly IBankAccountRepository _bankAccountRepository;

    public HomeController(ILogger<HomeController> logger, IExpenseRepository expenseRepository, IBankAccountRepository bankAccountRepository)
    {
        _logger = logger;
        _expenseRepository = expenseRepository;
        _bankAccountRepository = bankAccountRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        var expense = _expenseRepository.GetById(1);
        var expenseViewModel = new ExpenseViewModel(expense);

        var bankAccount = _bankAccountRepository.GetById(1);
        bankAccount.Salary = 3000;
        _bankAccountRepository.Update(bankAccount);
        var bankAccountViewModel = new BankAccountViewModel(bankAccount);
        var combinedViewModel = new CombinedViewModel(bankAccountViewModel, expenseViewModel);

        return View(combinedViewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult AddExpense(Expense expense)
    {
        try
        {
            _expenseRepository.Add(expense);
            return RedirectToAction("Privacy");
        }
        catch (Exception)
        {
            return RedirectToAction("Error");
        }
    }

    [HttpPost]
    public IActionResult UpdateExpense(ExpenseViewModel expenseViewModel)
    {
        try
        {
            var expense = _expenseRepository.GetById(expenseViewModel.Id);
            expense.Studies = expenseViewModel.Studies;
            expense.Housing = expenseViewModel.Housing;
            expense.Leisure = expenseViewModel.Leisure;
            expense.Health = expenseViewModel.Health;
            
            _expenseRepository.Update(expense);
            return RedirectToAction("Privacy");
        }
        catch (Exception)
        {
            return RedirectToAction("Error");
        }
    }
    
    [HttpPost]
    public IActionResult AddBankAccount(BankAccount bankAccount)
    {
        try
        {
            _bankAccountRepository.Add(bankAccount);
            return RedirectToAction("Privacy");
        }
        catch (Exception)
        {
            return RedirectToAction("Error");
        }
    }

    [HttpPost]
    public IActionResult UpdateBankAccount(BankAccountViewModel bankAccountViewModel)
    {
        try
        {
            var bankAccount = _bankAccountRepository.GetById(bankAccountViewModel.Id);
            bankAccount.Salary = bankAccountViewModel.Salary;
            bankAccount.Bradesco = bankAccountViewModel.Bradesco;
            bankAccount.Neon = bankAccountViewModel.Neon;
            bankAccount.Nubank = bankAccountViewModel.Nubank;

            _bankAccountRepository.Update(bankAccount);
            return RedirectToAction("Privacy");
        }
        catch (Exception)
        {
            return RedirectToAction("Error");
        }
    }
}