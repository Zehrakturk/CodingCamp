using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using video5_odev5.Abstract;
using video5_odev5.Entitiy;

namespace video5_odev5.Concrete
{
    internal class GameSalesManager : IGameSalesService
    {
        private ICheckService _checkService;

        public GameSalesManager(ICheckService checkService)
        {
            _checkService = checkService;
        }

        public void AddToCart(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Enter the campaign code: ");

            if (_checkService.CheckIfRealCampaignCode(campaign,Console.ReadLine()))
            {
                Console.WriteLine(game.GameName+" added to cart "+gamer.UserName+"account with"+campaign.CampaignName);
            }
            else
            {
                Console.WriteLine("Campaign Code is wrong!!!");
            }
        }

        public void DeleteToCart(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName+" deleted to cart "+gamer.UserName+"account with"+campaign.CampaignName);
        }
    }
}
