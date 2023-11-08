using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulamento
{
    class Person
    { /*contrutor*/
        public string name;
        public int age;

        public Person()
        {
            //
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name)
        {
            this.name = name;
        }

        public string ToString()
        {
            return $"Nome: {name} Idade: {age}";
        }
    }
}