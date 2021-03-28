using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    interface ISaleService
    {
        void CampaignSale(Game game, Gamer gamer, Campaign campaign);
        void Sale(Game game, Gamer gamer);
    }
}
