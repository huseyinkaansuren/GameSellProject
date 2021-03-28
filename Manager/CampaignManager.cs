using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign,Game game)
        {
            game.GamePrice = game.GamePrice * (campaign.campaignRate / 100);
        }

        public void DeleteCampaign(Campaign campaign, Game game)
        {
            game.GamePrice = game.GamePrice * (100 / campaign.campaignRate);
        }
    }
}
