using Kw.Api.Services;
using Kw.Data;
using Kw.Model;
using Microsoft.AspNetCore.Mvc;

namespace Kw.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamilyMembersController : ControllerBase
    {
        private readonly IUserService _userService;

        public FamilyMembersController(IUserService userService)
        {
            _userService = userService;
        }

        public IEnumerable<User> Index()
        {
            return _userService.GetUsers();
        }


        private static List<User> Users()
        {
            var user = new User
            {
                Id = 1,
                Name = "Gorilla"
            };

            return new List<User> {
                user,
                new User
                {
                    Id = 2,
                    Name = "Panther",
                },
                new User
                {
                    Id = 3,
                    Name = "Monkey",
                },
                new User
                {
                    Id = 4,
                    Name = "Fox",
                },
                new User
                {
                    Id = 5,
                    Name = "Zebra",
                },
                new User
                {
                    Id = 6,
                    Name = "Moose",
                },
            };
        }
    }
}
