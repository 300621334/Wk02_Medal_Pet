using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> list = new List();
             list.Add(int#);
             list.insert(index# , int);
             list.remove(index#);
             list.clear()
             for...
             foreach...*/

            List<Pet> pets = new List<Pet>();
            Pet a = new Pet("Jacky", 12, "a dog");
            a.SetOwner("Michael");
            pets.Add(a);

            a = new Pet("Tommy", 2, "a cat");
            a.SetOwner("Jay");
            pets.Add(a);

            a = new Pet("Tony", 7, "a horse");
            a.SetOwner("Chris");
            pets.Add(a);

            //pets.Add(new Pet("Jacky", 12, "a dog")); //but how to .SetOwner() this way?
            //pets.Add(new Pet("tom", 2, "a cat"));
            //pets.Add(new Pet("Tony", 7, "a horse"));

            foreach (Pet p in pets)
            {
                if(p.GetOwnerName() == "Jay")
                {
                    Console.WriteLine(p);
                }
                
            }
        }


    }
}
