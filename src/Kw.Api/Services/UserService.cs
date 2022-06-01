using Kw.Data;
using Kw.Model;

namespace Kw.Api.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        Task<User> SaveUser(User user);
    }

    public class SqlUserService : IUserService
    {
        private readonly KwDbContext _db;

        public SqlUserService(KwDbContext db)
        {
            _db = db;
        }

        public IEnumerable<User> GetUsers ()
        {
            return _db.Users;
        }

        public async Task<User> SaveUser(User user)
        {
            var r = _db.Users.Add(user);
            await _db.SaveChangesAsync();

            return r.Entity;
        }
    }
}
