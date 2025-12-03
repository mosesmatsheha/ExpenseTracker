using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models

{
    public class Expense
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Desription is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Categorty type is required")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Amount is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero")]
        public double Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
