using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Pages.ToDoPage
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Todo> ToDoList { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
           _db = db;
        }
        public void OnGet()
        {
            ToDoList = _db.Todos.ToList();
        }
    }
}
