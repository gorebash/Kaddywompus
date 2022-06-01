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
        private readonly ILogger _logger;


        public FamilyMembersController(IUserService userService, ILogger<User> logger)
        {
            _userService = userService;
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetUsers();
        }


        [HttpPost]
        public async Task<ActionResult> Post (User user)
        {
            try
            {
                var saved = await _userService.SaveUser(user);
                return Ok(saved);
            } catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to save user.");
            }

            return BadRequest();
        }
    }
}
