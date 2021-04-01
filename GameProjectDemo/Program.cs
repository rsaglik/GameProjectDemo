using GameProjectDemo.Concrate;
using GameProjectDemo.Entities;
using System;
using GameProjectDemo.Abstract;
using GameProjectDemo.Adapter;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player
            {
                Id = 1,
                FirstName = "Burhan",
                LastName = "Uğur",
                DateOfBirth = new DateTime(1994, 9, 15),
                IdentityNumber = "11032136889"
            };
            
            //Player added
            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Add(player1);


            Game game1 = new Game
            {
                Id = 1,
                Name = "Pubg Mobile",
                Price = 30
            };
            //Game added
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);


            Campaign campaign1 = new Campaign
            {
                Id = 1,
                Discount = 30,
                Name = "Black Friday"
            };
            //Campaign added
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);



            //Camgaign Sales
            OrderManager orderManager = new OrderManager();
            orderManager.CampaignSale(player1, game1, campaign1);

            //sales
            Console.WriteLine("");
            orderManager.Sale(player1, game1);

            Console.ReadLine();
        }
    }
}
