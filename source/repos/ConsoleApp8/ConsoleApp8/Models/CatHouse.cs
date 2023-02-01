using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp8.Models;

namespace Cats.Models
{
    internal class CatHouse : Cat 
    {

        public List<Cat> cats = new ();

        public string chName { get; set; }
        
        int catCount = 3;

        public CatHouse(string chName)
        {
            this.chName=chName;
        }

 


        public void  AddCat(Cat cat)
        {

            foreach (var item in cats)
            {
                if (cat.Nickname == item.Nickname)
                {
                    Console.WriteLine("Bele piwik var");
                    Thread.Sleep(1500);
                    return;
                }
            }


            cats.Add(cat);
            catCount++;
            Console.WriteLine($"{cat.Nickname } piwik elave olundu");
            Thread.Sleep(1500);

        }

      

        public void RemoveCat(Cat cat)
        {

          
            
            foreach (var item in cats)
            {
                if (item.Nickname == cat.Nickname)
                {
                    cats.Remove(cat);
                    catCount--;
                    Console.WriteLine("piwik cixarildi");
                    Thread.Sleep(1500);
                    return;
                }

            }
            Console.WriteLine("bele piwik yoxdur");
            Thread.Sleep(1500);

        }


        public void Show()
        {

            for (int i = 0; i < cats.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{cats[i].Nickname} piwik");
            }
        
        }

    }
}
