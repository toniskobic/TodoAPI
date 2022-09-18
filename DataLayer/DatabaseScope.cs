namespace DataLayer
{
    using DataLayer.Interfaces;

    public class DatabaseScope : IDatabaseScope
    {
        private readonly TodoContext _todoContext;

        public DatabaseScope(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }

        public void SaveAsync()
        {
            _todoContext.SaveChangesAsync();
        }
    }
}
