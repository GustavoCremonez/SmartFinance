using Microsoft.AspNetCore.Mvc;
using SmartFinance.Domain.Contracts;
using SmartFinance.Domain.Entities;

namespace SmartFinance.API.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)

        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Consumes("application/json")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                User? entity = await _userService.GetUserAsync(id);

                if (entity == null)
                    return NotFound();
                else
                    return Ok(entity);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Consumes("application/json")]
        public async Task<IActionResult> Create(User user)
        {
            try
            {
                await _userService.CreateUserAsync(user);
                return CreatedAtAction(nameof(Create), user);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}