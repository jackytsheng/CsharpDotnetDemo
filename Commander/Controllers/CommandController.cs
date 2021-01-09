using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Commander.Data;

namespace Commander.Controllers
{
  [Route("api/commands")]
  [ApiController]
  public class CommandController : ControllerBase
  {
    private readonly MockcommanderRepo _repository = new MockcommanderRepo();
    //Get api/commands
    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      var commandItems = _repository.GetAppCommands();

      return Ok(commandItems);
    }
    //Get api/comands/{id}
    [HttpGet("{id}")]
    public ActionResult <Command> GetCommandById(int id)
    {
      var commandItem = _repository.GetCommandById(id);

      return Ok(id);
    }
  }
}