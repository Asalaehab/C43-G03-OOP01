using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigntmentOOP
{
    //Q2
     struct Person
    {
        public int Age { get; set; }
        public string? Name { get; set; }

        public override string ToString()
        {
            return $"Name : {Name} Age : {Age}";
        }
    }
}
