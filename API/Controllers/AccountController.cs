using System.Security.Cryptography;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        public AccountController(DataContext context)
        {
            _context = context;

        }

        // [HttpPost("register")]
        // public async Task<ActionResult<AppUser>> Register(string username, string password)
        // {
        //     using var hmac = new HMACSHA512();

        // }
    }
}