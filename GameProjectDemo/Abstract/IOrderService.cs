using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IOrderService
    {
        void CampaignSale(Player player, Game game, Campaign campaign);
        void Sale(Player player, Game game);
    }
}
