using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
	public class CampaignManager : ICampaignService
	{
		
        public void Add(Campaign campaign)
		{


			Console.WriteLine("Yeni kampanya girişi başarıyla yapıldı.");
			
		}

		public void Delete(Campaign campaign)
		{
			Console.WriteLine("Kampanya silindi.");
		}

		public void Update(Campaign campaign)
		{
			Console.WriteLine("Kampanya güncellendi.");
		}
	}
}
