using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
	public class OrderManager : IOrderService
	{
		ICampaignService _campaignService;
        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }
        public void Sales(Gamer gamer)
		{
			Console.WriteLine("Satış başarıyla yapıldı.");
		}
	}
}
