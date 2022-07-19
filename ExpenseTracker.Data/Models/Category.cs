using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Data.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId {get; set;}
        public string Name {get; set;}
    }
}