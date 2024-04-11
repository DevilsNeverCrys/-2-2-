// SubscriptionsController.cs
using Microsoft.AspNetCore.Mvc;

namespace SubscriptionsService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubscriptionsController : ControllerBase
    {
        [HttpGet("{userId}")]
        public IActionResult GetSubscriptions(int userId)
        {
            // Логіка отримання підписок користувача з бази даних
            return Ok(new { UserId = userId, Subscription = "Gold" });
        }

        // Додайте інші методи для управління підписками користувачів
    }
}
