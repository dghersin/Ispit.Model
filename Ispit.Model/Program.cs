
using Ispit.Model;

// Ucenik ucenik = new Ucenik("Daniel", "Ghersinich", new DateTime(1972, 5, 31), 4.7);

Console.WriteLine("Unesi tri ucenika.");
Ucenik ucenik = new Ucenik();
var ucenici = ucenik.UnesiUcenika(3);
Console.WriteLine("************************* Uneseni ucenici *************************");
ucenik.IspisUcenika(ucenici);
