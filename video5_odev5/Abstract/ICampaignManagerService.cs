using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using video5_odev5.Concrete;
using video5_odev5.Entitiy;

namespace video5_odev5.Abstract
{
    internal interface ICampaignManagerService
    {
        void AddCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
    }
}
