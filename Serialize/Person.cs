using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize
{
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public int Year { get; set; }

        [NonSerialized]
        public string accNumber;

        public Person(string name, int year, string acc)
        {
            Name = name;
            Year = year;
            accNumber = acc;
        }
    }
}
