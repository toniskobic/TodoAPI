namespace DataLayer
{
    public class DatabaseScope
    {
        private readonly TodoContext _todoContext;

        public DatabaseScope(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }

        public void Save()
        {
            _todoContext.SaveChangesAsync();
        }
    }
}
