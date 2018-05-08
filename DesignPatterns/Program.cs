using DesignPatterns.Builder;
using DesignPatterns.Builder.FluentBuilder;
using DesignPatterns.SOLID.LiskovSubstitutionPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new Builder();
            var person = builder.InCity("casa").WithJob("Ing").Called("Zakaria").Build();

            Console.ReadKey();
        }

        public class Builder : PersonCityBuilder<Builder>
        {
            public Person Build()
            {
                return _person;
            }
        }
    }
}
