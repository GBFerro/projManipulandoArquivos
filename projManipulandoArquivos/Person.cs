using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projManipulandoArquivos
{
    internal class Person
    {
        public string Name { get; set; }

        public char Gender { get; set; }

        public Person(string name, char gender)
        {
            (Name, Gender) = (name, gender);
            //Name = name;
            //Gender = gender;
        }

        public override string? ToString()
        {
            return $"Nome: {this.Name} | Gênero: {this.Gender}";
        }
    }
}
