using Console36.Domain;
using ConsoleApp36.Helpers;
using ConsoleApp36.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36.Services.Services
{
    public class ServicePerson : IPerson
    {
        public void Filter( Predicate<Person> filtering)
        {
          List<Person> result = GettingPeopleWhoEarnMoreThan1000();
            var ResultPart = result.FindAll(filtering);
            foreach (var Person in ResultPart)
            {
                Console.WriteLine(Person);
            }
           if(ResultPart.Count == 0)
            {
                throw new Exception(Message.MessageError);
            }
        }

        public List<Person> GettingPeopleWhoEarnMoreThan1000()
        {
            Person person = new Person() { Id=1,Name="Kamil",SurName="Karimov",Address="baki",Age=17};
            Person person1 = new Person() { Id = 1, Name = "Kamil", SurName = "Karimov", Address = "baki", Age = 17,Salary=110 };
            Person person2 = new Person() { Id = 1, Name = "Kamil", SurName = "Karimov", Address = "baki", Age = 17, Salary = 100 };
            Person person3 = new Person() { Id = 1, Name = "Kamil", SurName = "Karimov", Address = "baki", Age = 17, Salary = 110 };
            List<Person> list = new List<Person>();
                list.Add(person);
            list.Add(person1);
            list.Add(person2);
            list.Add(person3);
            return list;
            
        }
    }
}
