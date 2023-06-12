using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using video5_odev5.Abstract;
using video5_odev5.Entitiy;

namespace video5_odev5.Concrete
{
    internal class CheckManager : ICheckService
    {
        public bool CheckIfRealCampaignCode(Campaign campaign,string code)
        {
            if (string.Equals(code,campaign.CampaignCode))
            {
                Console.WriteLine("Campaign Code is correct.");
                return true;
            }
            else
            {
                return false;
            }
     
        }

        public bool CheckIfRealGamer(Gamer gamer)
        {
            return true;
        }
    }
}
