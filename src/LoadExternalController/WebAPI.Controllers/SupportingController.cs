using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using LoadExternalController.WebAPI.Shared;

namespace LoadExternalController.WebAPI.Main.Controllers
{
    [ApiController]
    [Route("api/support")]
    public class SupportingController : MyController
    {
        protected override async Task<ActionResult> GetActionAsync()
        {
            return Ok("Supporting");
        }
    }
}
