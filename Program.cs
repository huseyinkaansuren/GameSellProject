using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer { Id = 1, FirstName = "Kaan", LastName = "Süren", BirthYear = 1998, IdentityNumber = 12345 };
            gamerManager.Add(gamer);

            GameManager gameManager = new GameManager();
            Game kenshi = new Game{ GameName = "Kenshi", GamePrice = 50, Id = 1 } ;
            gameManager.AddGame(kenshi);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign { campaignRate = 50, campaingName = "Kenshi Campaign", Id = 1 };

            SaleManager saleManager = new SaleManager();

            saleManager.Sale(kenshi,gamer);

        }
    }
}
