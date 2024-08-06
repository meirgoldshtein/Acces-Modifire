using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Acces_Modifire
{
    internal class Person
    {
        private int Age;
        public int getAge()
        {
            return Age;
        }
        public void setAge(int Age)
        {
            this.Age = Age;
        }

        public void printSpecies()
        {
            Dog myDog = new Dog();
            Console.WriteLine(myDog.GetSpecies());
        }


    }

    
}
