using ExpenseTracker.Models;

namespace ExpenseTracker.Data.Services
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAllExpensesAsync();
        Task Add(Expense expense);
        List<object> GetChart();
    }
}
