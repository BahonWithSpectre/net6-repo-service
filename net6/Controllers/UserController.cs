using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using net6.DapperAccessor.Services;

namespace net6.Controllers
{
    /// <summary>
    /// Контроллер для работы с Пользователями
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Получить список всех Пользователей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            return new JsonResult(await _userService.GetUserEnumerableAsync());
        }
    }
}
