using DeskBooking.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DeskBooking.API.Controllers
{
    public class WorkspacesController : BaseApiController
    {
        private readonly IWorkspaceApplicationService _workspaceApplicationService;
        public WorkspacesController(IWorkspaceApplicationService workspaceApplicationService) 
        {
            _workspaceApplicationService = workspaceApplicationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetWorkspaces()
        {
            var workspacesResponse = await _workspaceApplicationService.GetAllWorkspaces();
            
            return Ok(workspacesResponse);
        }
    }
}
