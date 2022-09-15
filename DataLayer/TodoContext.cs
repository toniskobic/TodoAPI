using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using DataLayer.Models;

namespace DataLayer
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
    }
}
