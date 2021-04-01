using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrate
{
    public class OrderManager : IOrderService
    {
        public void CampaignSale(Player player, Game game, Campaign campaign)
        {
            decimal price = game.Price - ((game.Price * (decimal)campaign.Discount) / 100);
            Console.WriteLine("Campaign Sales Detail");
            Console.WriteLine($"Player : {player.FirstName} {player.LastName}, Game : {game.Name}, Price : {game.Price}, Discount : {campaign.Discount}, Discounted Price : {price}");
        }

        public void Sale(Player player, Game game)
        {
            Console.WriteLine("Sales Detail");
            Console.WriteLine($"Player : {player.FirstName} {player.LastName}, Game : {game.Name}, Price : {game.Price}");
        }
    }
}
