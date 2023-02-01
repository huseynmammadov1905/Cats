
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Models
{
    internal class Cat
    {
       public string Nickname { get; set; }

        public int Age;

        public int age { get { return Age; } set { Age = (value >= 0 && value <= 20 ) ? value : 0; } }

        public bool Gender { get; set; }

        public double Energy;

        public double energy { get { return Energy; } set { Energy = value >= 0 ? value : 50; } }

        public double Price;

        public double price { get { return Price; } set { Price = value >=0 ? value : 50; } }

        public int mealQuantity;



        public int mealquantity { get { return mealQuantity; } set { mealQuantity =  value >= 0 ? value : 1; } }

        public Cat() { }
        public Cat(string nickname, int age, bool gender, double price, int mealquantity,int Enrg)
        {
            Nickname=nickname;
            this.age=age;

            Gender=gender;

            energy = Enrg;

            this.price=price;

            this.mealquantity=mealquantity;
        }


        public void Eat(Cat cat) {
            Console.WriteLine("piwik yemek yeyir");

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("3");
                Thread.Sleep(1000);
                Console.WriteLine("2");
                Thread.Sleep(1000);
                Console.WriteLine("1");
                Thread.Sleep(1000);

            }

            Console.WriteLine($"{cat.Nickname} piwik yemeyi bitirdi");

            Thread.Sleep(1500);

            cat.mealQuantity--;

            cat.Energy += cat.Energy < 100 ? 25 : 0;
        }


        public void Sleep(Cat cat) {

            if(Energy < 100)
            {
                Console.WriteLine($"{cat.Nickname} piwik yatir");
                Energy += 25;
                price += 1;
                
            }
            else { Console.WriteLine($"{cat.Nickname} piwik yatmaq istemir"); }
          
        }


        public void Play(Cat cat)
        {
            Console.WriteLine($"{cat.Nickname} piwik oynayir");
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("3");
                Thread.Sleep(1000);
                Console.WriteLine("2");
                Thread.Sleep(1000);
                Console.WriteLine("1");
                Thread.Sleep(1000);

            }

            Energy -=Energy > 0 ? 25 : 0;

            Console.WriteLine($"{cat.Nickname} piwik oynadi");
            Thread.Sleep(1500);
        }

 


    }
}
