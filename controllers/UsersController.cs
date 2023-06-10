using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]")]

public class UsersController : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            return BadRequest("Username and password are required.");
        }

        if (password.Length < 6)
        {
            return BadRequest("Password must be at least 6 characters long.");
        }

        // More registration logic will go here

    }
}