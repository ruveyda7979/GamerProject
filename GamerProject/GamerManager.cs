using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
	public class GamerManager : IGamerService
	{
		IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
		{
			if (_userValidationService.Validate(gamer)== true)
			{
				Console.WriteLine("Kayıt başarıyla yapıldı.");
			}
			else
			{
				Console.WriteLine("Doğrulama başarısız.Kayıt başarısız.");
			}
		}

		public void Delete(Gamer gamer)
		{
			Console.WriteLine("Kayıt başarıyla silindi");
		}

		public void Update(Gamer gamer)
		{
			Console.WriteLine("Kayıt başarıyla güncellendi.");
		}
	}
}
