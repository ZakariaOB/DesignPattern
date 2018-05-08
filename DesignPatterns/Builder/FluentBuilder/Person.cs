using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FluentBuilder
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Job { get; set; }

        public string City { get; set; }
    }
}
