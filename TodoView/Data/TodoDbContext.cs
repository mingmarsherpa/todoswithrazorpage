using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TodoView.Models;
namespace TodoView.Data;

public class TodoDbContext:IdentityDbContext<User>
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options)
        : base(options) {}

    public DbSet<Todo> TodoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Todo>()
            .HasOne(t => t.User)
            .WithMany(u => u.TodoItems)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

