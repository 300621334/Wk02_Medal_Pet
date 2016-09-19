using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedalDemo
{
    public class Medal
    {
        //"Properties" (not fields) that generate fields in background:
        public string Color { get; private set;}
        public bool IsRecord { get; private set; }
        public string Name { get; private set; }
        public string TheEvent { get; private set; }
        public int Year { get; private set; }


        //constructor
        public Medal(string name, string theEvent, string color,int year, bool isRecord)
        {
            this.Color = color;
            this.IsRecord= isRecord;
            this.Name = name;
            this.TheEvent = theEvent;
            this.Year = year;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}", Name, TheEvent, Color, Year, IsRecord);
        }

    }
}
