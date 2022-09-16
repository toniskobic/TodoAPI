namespace DataLayer
{
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.EntityFrameworkCore;

    public class TodoContextFactory : IDesignTimeDbContextFactory<TodoContext>
    {
        public TodoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TodoContext>();
            optionsBuilder.UseInMemoryDatabase("Todo");

            return new TodoContext(optionsBuilder.Options);
        }
    }
}
