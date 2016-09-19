using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", "Gold", 2012, true);
            //print the object
            Console.WriteLine(m1);
            //get; is fired as soon as I try to read the name of the medal holder. Set; would be fired if i tried to write-to this field-like-property.
            Console.WriteLine(m1.Name);
            Console.WriteLine();
            //assign a new object to m1
            m1 = new Medal("Michael Phelps", "Swimming", "Gold", 2012, false);
            //print the updated m1
            Console.WriteLine(m1);
            //print only the name of the medal holder
            Console.WriteLine(m1.Name);
            Console.WriteLine();



 //create a list to store the medal objects
 List<Medal> medals = new List<Medal>();
 medals.Add(new Medal("Ryan Cochrane", "Swimming", "Silver", 2012, false));
 medals.Add(new Medal("Adam van Koeverden", "Canoeing", "Silver", 2012, false));
 medals.Add(new Medal("Rosie MacLennan", "Gymnastics", "Gold", 2012, false));
 medals.Add(new Medal("Christine Girard", "Weightlifting", "Bronze", 2012, false));
 medals.Add(new Medal("Charles Hamelin", "Short Track", "Gold", 2014, true));
 medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", "Gold", 2012, true));
 medals.Add(new Medal("Jennifer Jones", "Curling", "Gold", 2014, false));
 medals.Add(new Medal("Charle Cournoyer", "Short Track", "Bronze", 2014, false));
 medals.Add(new Medal("Mark McMorris", "Snowboarding", "Bronze", 2014, false));
 medals.Add(new Medal("Sidney Crosby ", "Ice Hockkey", "Gold", 2014, false));
 medals.Add(new Medal("Brad Jacobs", "Curling", "Gold", 2014, false));
 medals.Add(new Medal("Ryan Fry", "Curling", "Gold", 2014, false));
 medals.Add(new Medal("Antoine Valois-Fortier", "Judo", "Bronze", 2012, false));
 medals.Add(new Medal("Brent Hayden", "Swimming", "Bronze", 2012, false));

 //print all the medals
 foreach(Medal m in medals)
 {
     Console.WriteLine(m);
 }
 Console.WriteLine();

 //print only the names of all the medal holder
 foreach (Medal m in medals)
 {
     Console.WriteLine(m.Name);
 }
 Console.WriteLine();
//print all the gold medals
 foreach (Medal m in medals)
 {
     if (m.Color == "Gold")
     {
         Console.WriteLine(m.Name);
     }
 }
 Console.WriteLine();
//print all the medals in 2012
 foreach (Medal m in medals)
 {
     if (m.Year == 2012)
     {
         Console.WriteLine(m.Name);
     }
 }
 Console.WriteLine();
//print all the world record medals
 foreach (Medal m in medals)
 {
     if (m.IsRecord == true)
     {
         Console.WriteLine(m.Name);
     }
 }
 Console.WriteLine();
        }
    }
}
