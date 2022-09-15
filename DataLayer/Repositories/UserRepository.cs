using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.Extensions.Logging;

namespace DataLayer.Repositories
{
    public class UserRepository : DataRepository<User>, IUserRepository
    {
        private readonly TodoContext _todoContext;
        public UserRepository(TodoContext todoContext) : base(todoContext)
        {
            _todoContext = todoContext;
        }

        public void Update(User userToUpdate, User user)
        {
            
            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            _todoContext.SaveChanges();
        }
    }
}
