// UsersController.cs
using Microsoft.AspNetCore.Mvc;

namespace UsersService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            // Логіка отримання користувача з бази даних
            return Ok(new { Id = id, Name = "John Doe", Email = "john@example.com" });
        }

        // Додайте інші методи для створення, оновлення та видалення користувачів
    }
}
