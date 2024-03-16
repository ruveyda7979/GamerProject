using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
	public class UserValidationManager : IUserValidationService
	{
		public bool Validate(Gamer gamer)
		{
			if(gamer.BirthDate == 2000 && gamer.FirstName =="Rüveyda" && gamer.LastName== "Koçaker" && gamer.IdentificationNumber == 1234)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
