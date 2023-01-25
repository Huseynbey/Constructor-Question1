using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Animal
    {
        public string name;
        public string breed;
        public string color;
        public int age;

        public Animal(string name, string breed, string color, int age)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
        }
        public string GetDetails()
        {
            return $"{name} {breed} {age}";
        }
    }
}
    