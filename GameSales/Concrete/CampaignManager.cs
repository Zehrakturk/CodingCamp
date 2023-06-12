using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using video5_odev5.Abstract;
using video5_odev5.Entitiy;

namespace video5_odev5.Concrete
{
    internal class CampaignManager : ICampaignManagerService
    {

        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" aded.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " deleted.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " updated.");
        }
    }
}
