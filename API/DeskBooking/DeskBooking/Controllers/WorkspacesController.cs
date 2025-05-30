using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DeskBooking.API.Controllers
{
    public class WorkspacesController : BaseApiController
    {
        public WorkspacesController() { }

        [HttpGet]
        public async Task<ActionResult> GetWorkspaces() /////TODO
        {
            return Ok();
        }
    }
}
