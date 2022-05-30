using Kw.Api.Services;
using Kw.Data;
using Kw.Model;
using Microsoft.AspNetCore.Mvc;

namespace Kw.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FamilyMembersController : ControllerBase
    {
        private readonly IUserService _userService;

        public FamilyMembersController(IUserService userService)
        {
            _userService = userService;
        }

        public IEnumerable<User> Index()
        {
            //return _userService.GetUsers();
            return Users();
        }


        private static List<User> Users()
        {
            var user = new User
            {
                Id = 1,
                FirstName = "Bat 2"
            };

            return new List<User> {
                user,
                new User
                {
                    Id = 2,
                    FirstName = "Panther",
                },
                new User
                {
                    Id = 3,
                    FirstName = "Monkey",
                },
                new User
                {
                    Id = 4,
                    FirstName = "Fox",
                },
                new User
                {
                    Id = 5,
                    FirstName = "Zebra",
                },
                new User
                {
                    Id = 6,
                    FirstName = "Moose",
                },
            };
        }
    }
}
