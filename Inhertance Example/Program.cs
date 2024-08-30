using Inhertance_Example.Context;
using Inhertance_Example.Model;

namespace Inhertance_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

         using AppContextDB1 Context =new AppContextDB1();
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                Name = "Bassim",
                Address = "Giza",
                Email = "bassim@gmail.com",
                Salary = 2999


            };

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Name = "ahmed",
                Email = "ahmed@gmail.com",
                NumberOfHour = 2,
                HourRate = 10,
                Address="alex",

            };
            //Context.FullTimeEmployees.Add(fullTimeEmployee);
            //Context.PartTimeEmployees.Add(partTimeEmployee);


            //Context.Employees.Add(fullTimeEmployee);
            //Context.Employees.Add([partTimeEmployee]);

           //var result= Context.Employees.OfType<FullTimeEmployee>();
           // foreach (var employee in result)
           // {
           //     Console.WriteLine(employee.Name);
           // }


            Context.SaveChanges();

        }
    }
}
