using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DeskBooking.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController : ControllerBase
    {
        public BookingsController() { }

        [HttpGet]
        public async Task<ActionResult> GetBookings() /////TODO
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetBooking() /////TODO
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CreateBooking() /////TODO
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBooking() /////TODO
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBooking() /////TODO
        {
            return Ok();
        }
    }
}
