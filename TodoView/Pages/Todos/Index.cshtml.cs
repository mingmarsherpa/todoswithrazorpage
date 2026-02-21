using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TodoView.Models;
using TodoView.Data;

namespace TodoView.Pages.Todos
{
    public class IndexModel : PageModel
    {
        private readonly TodoDbContext _context;

        public IndexModel(TodoDbContext context)
        {
            _context = context;
        }

        public IList<Todo> Todos { get; set; }

        public async Task OnGetAsync()
        {
            Todos = await _context.TodoItems.ToListAsync();
        }
    }
}
