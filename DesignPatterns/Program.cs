using DesignPatterns.Builder.FluentBuilder;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new Builder();
            AllPersons(builder);
            Console.ReadKey();
        }

        public class Builder : PersonCityBuilder<Builder>{}

        public static void AllPersons(Builder builder)
        {
            var person = builder.InCity("casa").WithJob("Ingénieur").Called("Zakaria").Build();
            var mohamed = builder.InCity("Marrakecj").WithJob("OK").Called("Zakaria").Build();
        }
    }
}
