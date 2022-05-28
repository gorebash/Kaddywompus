using Kw.Data;
using Kw.Model;

namespace Kw.CoreApi.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
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
    }
}
