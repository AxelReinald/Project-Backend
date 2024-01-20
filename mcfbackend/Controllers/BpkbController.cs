using mcfbackend.Context;
using mcfbackend.Models;
using mcfbackend.Service;
using Microsoft.AspNetCore.Mvc;

namespace mcfbackend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BpkbController : ControllerBase
    {
        private readonly BpkbService _bpkbService;

        public BpkbController(McfDbContext context)
        {
            _bpkbService = new BpkbService(context);
        }
        [HttpPost("Insertdatabpkb")]
        public ActionResult Insertdatabpkb(Tr_bpkb valuebpkb)
        {
            _bpkbService.Addinsertbpkb(valuebpkb);
            return Ok();
        }
        [HttpGet("GetStorageLocations")]
        public ActionResult GetStorageLocations()
        {
            var result = _bpkbService.GetStorageLocations();
            return Ok(result);
        }
    }
}
