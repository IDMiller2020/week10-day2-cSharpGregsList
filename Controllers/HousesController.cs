using Microsoft.AspNetCore.Mvc;

namespace cSharpGregsList.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase
  {
    private readonly HousesService _service;
    public HousesController(HousesService service)
    {
      _service = service;
    }
    [HttpGet]
    public ActionResult<IEnumerable<House>> GetAll()
    {
      try
      {
        return Ok(FakeDb.Houses);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
  }
}