using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]")]

public class UsersController : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register(string username, string password)
    {
        // I'll put registration logic here later
    }
}