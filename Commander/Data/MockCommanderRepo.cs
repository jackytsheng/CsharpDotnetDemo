using Commander.Models;
using System.Collections.Generic;
namespace Commander.Data
{
    public class MockcommanderRepo : ICommanderRepo
    {
      public IEnumerable<Command> GetAppCommands()
      {
        var commands = new List<Command>
        {
          new Command{
          Id=0,
          HowTo = "Boil an egg",
          Line = "Boil Water",
          Platform = "Kitchen"
          },
          new Command{
          Id=2,
          HowTo = "Fried an egg",
          Line = "Using a pan",
          Platform = "Kitchen"
          }
        };
        return commands;
      }

      public Command GetCommandById(int id)
      {
        return new Command{
          Id=0,
          HowTo = "Boil an egg",
          Line = "Boil Water",
          Platform = "Kitchen"
        };
      }
    }
}