// See https://aka.ms/new-console-template for more information
using GameProject;



GamerManager gamerManager = new GamerManager(new UserValidationManager());

gamerManager.Add(new Gamer
{
	Id = 1,
	FirstName="Rüveyda",
	LastName = "Koçaker",
	BirthDate = 2000,
	IdentificationNumber = 1234

});
Console.WriteLine("Hello, World!");

