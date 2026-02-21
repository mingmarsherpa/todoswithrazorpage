using Microsoft.EntityFrameworkCore;
using TodoView.Models;
namespace TodoView.Data;

public class TodoDbContext:DbContext
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options)
        : base(options) {}

    public DbSet<Todo> TodoItems { get; set; }
}
//https://www.learnrazorpages.com/razor-pages/files/viewstart