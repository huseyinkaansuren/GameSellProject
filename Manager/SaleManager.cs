using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class SaleManager : ISaleService
    {
        CampaignManager campaignManager;
        public void CampaignSale(Game game, Gamer gamer,Campaign campaign)
        {
            campaignManager.AddCampaign(campaign,game);
            gamer.GamerLibrary.Add(game);
        }
        public void Sale(Game game, Gamer gamer)
        {
            gamer.GamerLibrary.Add(game);
            Console.WriteLine($"{game.GameName} Oyun Kütüphanesine eklendi");
        }
    }
}
