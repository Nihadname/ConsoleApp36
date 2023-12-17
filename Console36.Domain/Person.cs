using Console36.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console36.Domain
{
    public class Person:BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
     //   public List<Person> People { get; set;}
        public int Salary { get; set; }
        public int Age;
        public string Address { get; set; }
        public override string ToString()
        {
            return $"id:{Id} Name:{Name} {Salary}";
        }
    }

}
