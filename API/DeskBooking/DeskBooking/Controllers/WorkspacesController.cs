using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DeskBooking.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkspacesController : ControllerBase
    {
        public WorkspacesController() { }

        [HttpGet]
        public async Task<ActionResult> GetWorkspaces() /////TODO
        {
            return Ok();
        }
    }
}
