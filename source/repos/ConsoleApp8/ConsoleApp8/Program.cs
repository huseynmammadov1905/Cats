
using ConsoleApp8.Models;
using Cats.Models;
using Task_Cats.Models;

PetShop ps = new PetShop();

CatHouse ch = new CatHouse("piwiklandiya");

Cat c = new("sari ", 2, true, 30, 10, 75);
Cat c1 = new("qara ", 3, false, 60, 5, 100);

ps.Add(ch);

ch.AddCat(c);
ch.AddCat(c1);

c.Play(c);
c1.Play(c1);

ch.Show();


