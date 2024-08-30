using Microsoft.EntityFrameworkCore;
using session_3_Ef.Context;

namespace session_3_Ef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DBAppContext context = new DBAppContext();
            #region Explicit Loading
            //var Employee = context.Employees.FirstOrDefault(e => e.Id == 3);
            //context.Entry(Employee).Reference(e => e.WorkFor).Load();
            //Console.WriteLine(Employee.Name);
            //Console.WriteLine(Employee.Age);
            //Console.WriteLine(Employee.DeptID);
            //Console.WriteLine(Employee?.WorkFor?.Name ?? "not found");

            //var Department = context.Departments.FirstOrDefault(e => e.Id == 1);
            //context.Entry(Department).Collection(e=>e.Employees).Load();
            //Console.WriteLine(Department.Name);

            //Console.WriteLine(Department.Id);
            //foreach (var item in Department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion
            #region eager loading
            //var Employee = context.Employees.Include(e=>e.WorkFor).FirstOrDefault(e => e.Id == 3);

            //Console.WriteLine(Employee.Name);
            //Console.WriteLine(Employee.Age);
            //Console.WriteLine(Employee.DeptID);
            //Console.WriteLine(Employee?.WorkFor?.Name ?? "not found");

            //var Department = context.Departments.Include(d=>d.Employees).FirstOrDefault(e => e.Id == 1);

            //Console.WriteLine(Department.Name);

            //Console.WriteLine(Department.Id);
            //foreach (var item in Department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion
            #region Lazy Loading
            //var Employee = context.Employees.FirstOrDefault(e => e.Id == 3);

            //Console.WriteLine(Employee.Name);
            //Console.WriteLine(Employee.Age);
            //Console.WriteLine(Employee.DeptID);
            //Console.WriteLine(Employee?.WorkFor?.Name ?? "not found");

            //var Department = context.Departments.Include(d => d.Employees).FirstOrDefault(e => e.Id == 1);

            //Console.WriteLine(Department.Name);

            //Console.WriteLine(Department.Id);
            //foreach (var item in Department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            #region Join
            using DBAppContext context = new DBAppContext();
            //var result= context.Employees.Join(context.Departments, E => E.DeptID, D => D.Id, (E, D) => new {E.Id,E.Name,D.Name,D.Id});
            //var Result = from E in context.Employees
            //             join D in context.Departments
            //             on E.DeptID equals D.Id
            //             select new
            //             {
            //                 EmpID = E.Id,
            //                 EmpName = E.Name,
            //                 DepartmentName = D.Name,
            //             };
            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

        }
    }
}
