using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Pet
    {
        //fields
        private string name;
        private string owner;
        private int age;
        private string description;
        private bool inHouseTrained;

        //constructor:- NO void etc; name EXACTLY as class's name:
        public Pet(string name, int age, string description)
        {
            this.name = name;
            this.age = age;
            this.description = description;
            inHouseTrained=false;
            owner ="no one";
        }

        public override string ToString()
        {
            return string.Format("Pet name: {0} \nOwner: {1} \nAge: {2} \nDescription: {3} \nTrained in house?: {4}",
                name, owner, age, description, inHouseTrained ? "Yes" : "No");
        }


        public void SetOwner(string newOwner)
        {
            this.owner = newOwner;
        }
        public string GetOwnerName()
        {
            return owner;
        }
    }
}
