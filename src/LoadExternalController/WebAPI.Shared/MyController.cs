using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LoadExternalController.WebAPI.Shared
{
    public abstract class MyController : ControllerBase
    {
        protected abstract Task<ActionResult> GetActionAsync();

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return await GetActionAsync();
        }
    }
}
