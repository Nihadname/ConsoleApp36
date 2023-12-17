// See https://aka.ms/new-console-template for more information
using ConsoleApp36.Services.Services;

Console.WriteLine("hello world!");
try
{
    ServicePerson servicePerson = new ServicePerson();
    servicePerson.Filter(a => a.Salary > 1000);
}
catch(Exception ex)
{
    Console.WriteLine(ex);
}