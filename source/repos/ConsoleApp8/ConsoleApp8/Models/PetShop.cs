
using Cats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Cats.Models
{
    internal class PetShop
    {
        List<CatHouse> ch = new();

       public void Add(CatHouse house)
        {
            ch.Add(house);
        }

        public int catHouseCount;


        public void show()
        {
            foreach (var item in ch)
            {
                Console.WriteLine(item.chName);
            }
        }
    }
}
