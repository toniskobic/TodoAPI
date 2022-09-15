using DataLayer.Interfaces;
using DataLayer.Models;

namespace DataLayer.Repositories
{
    public class TodoItemRepository : DataRepository<TodoItem>, ITodoItemRepository
    {
        private readonly TodoContext _todoContext;
        public TodoItemRepository(TodoContext todoContext) : base(todoContext)
        {
            _todoContext = todoContext;
        }

        public void Update(TodoItem todoItemToUpdate, TodoItem todoItem)
        {

            todoItemToUpdate.Name = todoItem.Name;
            todoItemToUpdate.IsComplete = todoItem.IsComplete;
            _todoContext.SaveChanges();
        }
    }
}
