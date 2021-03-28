using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    interface ICampaignService
    {
        void AddCampaign(Campaign campaign,Game game);
        void DeleteCampaign(Campaign campaign, Game game);
    }
}
