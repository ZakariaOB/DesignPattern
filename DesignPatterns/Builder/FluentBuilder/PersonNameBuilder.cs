using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FluentBuilder
{

    public abstract class PersonBuilder
    {
        protected Person _person = new Person();
        public Person Build()
        {
            return _person;
        }
    }

    public class PersonNameBuilder<SELF> : PersonBuilder 
            where SELF : PersonNameBuilder<SELF>
    {
        public SELF Called(string name)
        {
            _person.Name = name;
            return (SELF)this;
        }
    }

    public class PersonJobBuilder<SELF> : PersonNameBuilder<PersonJobBuilder<SELF>> 
            where SELF : PersonJobBuilder<SELF>
    {
        public SELF WithJob(string job)
        {
            _person.Job = job;
            return (SELF)this;
        }
    }

    public class PersonCityBuilder<SELF> : PersonJobBuilder<PersonCityBuilder<SELF>> 
        where SELF: PersonCityBuilder<SELF>
    {
        public SELF InCity(string city)
        {
            _person.City = city;
            return (SELF)this;
        }

    }
        
}
