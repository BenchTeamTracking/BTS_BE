using BTS.Application.Interfaces;
using BTS_BE.Controllers.Api;
using Microsoft.AspNetCore.Mvc;

namespace BTS_BE.Controllers
{
    public class UserController: BaseApiController
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Get user information
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _userRepository.GetItemByIdAsync(id);
            return Ok(result);
        }
    }
}
