using HalfFrameWeb.Lib.Models.VM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HalfFrameWeb.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtController : ControllerBase
    {
        public async Task<List<ArtVM>> Latest()
        {

        }
    }
}
