using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Pages.ToDoPage
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Todo Todo { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {

        }
    }
}
