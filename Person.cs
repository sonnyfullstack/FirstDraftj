using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmailAdress { get; set; }
        public string HomeAdress { get; set; }
        public string PrivatePhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
