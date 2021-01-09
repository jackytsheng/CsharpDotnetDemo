using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CommandController : ControllerBase
  {
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      
    }
  }
}