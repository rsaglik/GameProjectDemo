using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrate
{
    public class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns;
        public CampaignManager()
        {
            campaigns = new List<Campaign>();
        }

        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
        }

        public void Delete(Campaign campaign)
        {
            campaigns.Remove(campaign);
        }

        public List<Campaign> GetList()
        {
            return campaigns;
        }

        public void Update(Campaign campaign)
        {
            var updateCampaign = campaigns.Where(x=>x.Id == campaign.Id).FirstOrDefault();
            if(updateCampaign != null)
            {
                updateCampaign.Name = campaign.Name;
                updateCampaign.Discount = campaign.Discount;
            }
        }
    }
}
