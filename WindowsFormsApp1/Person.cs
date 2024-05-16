using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Person
    {
        string name;
        int age;
        string proffesion;

        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name, int age, string proffesion)
        {
            this.name = name;
            this.age = age;
            this.proffesion = proffesion;
        }
        public string GetInformation()
        {
            string information;
            information = "Ім`я: " + this.name + "; Вік: " + this.age.ToString() + ";Професія: " +this.proffesion;
            return information;
        }
    }
}
