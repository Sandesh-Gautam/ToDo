using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
        public Priority Priority { get; set; } 
    }

    public enum Priority
    {
        High,Medium,Low
    }

}
