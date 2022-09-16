namespace DataLayer.Repositories
{
    using DataLayer.Models;

    public class UserRepository : DataRepository<User>
    {
        public UserRepository(TodoContext todoContext) : base(todoContext)
        {
        }

    }
}
