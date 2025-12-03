using ExpenseTracker.Data;
using ExpenseTracker.Data.Services;
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        public readonly IExpensesService _expensesService;

        public ExpenseController(IExpensesService expensesService)
        {
            _expensesService = expensesService;
        }
        public async Task<IActionResult> Index()
        {
            var expenses = await _expensesService.GetAllExpensesAsync();
            return View(expenses);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            if(ModelState.IsValid)
            {
                await _expensesService.Add(expense);

                return RedirectToAction("Index");
            }
            return View(expense);
        }
    }
}
