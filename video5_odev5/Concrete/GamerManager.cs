using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using video5_odev5.Abstract;
using video5_odev5.Entitiy;

namespace video5_odev5.Concrete
{
    internal class GamerManager : IGamerManagerService
    {
        ICheckService _gamerCheckService;

        public GamerManager(ICheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " Account has been deleted!!!");
        }

        public void Record(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " was recorded");
            }
            else
            {
                Console.WriteLine("Gamer information is wrong!!!!");
            }
           
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " has been updated!!");
        }
    }
}
