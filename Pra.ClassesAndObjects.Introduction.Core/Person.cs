using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.ClassesAndObjects.Introduction.Core
{
    public class Person
    {
        public string firstname;
        public string lastname;

        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public override string ToString()
        {
            return $"{firstname} {lastname}";
        }
    }
}
