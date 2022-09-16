namespace DataLayer.Repositories
{
    using DataLayer.Models;

    public class TodoItemRepository : DataRepository<TodoItem>
    {
        public TodoItemRepository(TodoContext todoContext) : base(todoContext)
        {
        }
    }
}
