using Console36.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36.Services.interfaces
{
    public interface IPerson
    {
        List<Person>  GettingPeopleWhoEarnMoreThan1000();
        void Filter(Predicate<Person> filtering);

    }
}
