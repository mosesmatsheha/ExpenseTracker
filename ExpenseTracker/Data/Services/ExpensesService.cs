using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data.Services
{
    public class ExpensesService: IExpensesService
    {
        public readonly DataContext _context;
        public ExpensesService(DataContext context) 
        {
            _context = context;
        
        }

        public async Task<IEnumerable<Expense>> GetAllExpensesAsync()
        {
            var expenses = await _context.Expenses.ToListAsync();
            return expenses;
        }

        public async Task Add(Expense expense)
        {
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
        }
        public  List<object> GetChart()
        {
            var dataCategory = _context.Expenses
                .GroupBy(e => e.Type)
                .Select(g => new
                {
                    Type = g.Key,
                    TotalAmount = g.Sum(e => e.Amount)
                }).ToList<object>();
            foreach (var item in dataCategory)
            {
                Console.WriteLine($"{item}");
            }
            return dataCategory;
        }
    }
}
