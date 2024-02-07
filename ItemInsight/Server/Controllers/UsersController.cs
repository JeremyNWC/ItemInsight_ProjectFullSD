using ItemInsight.Server.IRepository;
using ItemInsight.Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ItemInsight.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }


        // api/User
        [HttpGet]
        public async Task<ActionResult?> GetUserProfile()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);

 
                var us = await _userManager.FindByIdAsync(user);

                if (us == null)
                {
                    return NotFound();

                }

                var getRole = await _userManager.GetRolesAsync(us);

                return Ok(new { id = us.Id, role = getRole[0] });
            
        }
    }
}
