using Homeworks_Const_Readonly_Access_Modifiers.Helpers.Constants;
using Homeworks_Const_Readonly_Access_Modifiers.Models;
using Homeworks_Const_Readonly_Access_Modifiers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Homeworks_Const_Readonly_Access_Modifiers.Controlles
{
    internal class EmployeeController
    {
        private readonly EmployeeService employeeService;

        public EmployeeController()
        { 
            employeeService = new EmployeeService();
        }
        public void GetAll()
        {
            

            var result = employeeService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.name+ " " +item.surname);
            }
        }
        public void GetAllByAge()
        {
            var employess = employeeService.GetAll();

            var result = employeeService.GetAllByAge(employess,30);

            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname + " " + item.age);
            }
        }
        public void GetCountByAge()
        {
            Console.WriteLine("Add first age:");
            int firstAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Add last age: ");
            int lastAge = int.Parse(Console.ReadLine());

            int count  = employeeService.GetCountByAge(employeeService.GetAll(),firstAge,lastAge);
            Console.WriteLine(count);
        }
       public void GetSumOfAges()
        {
            int sumOfAge = employeeService.SumOfAges(employeeService.GetAll());
            Console.WriteLine(sumOfAge);
        }
        public void GetAllByCheckedEmail()
        {
            Console.WriteLine("Add your text");
            string str = Console.ReadLine();

            Emplyee[] employess = employeeService.GetAll();

            Emplyee[] checkedEmplees = employeeService.GetAllByCheckEmail(employess,str);
            ///////
            
            if(checkedEmplees.Count() == 0)
            {
                Console.WriteLine(ResponseMessages.Notfound);
                return;
            }


            foreach (var item in checkedEmplees)
            {
                Console.WriteLine(item.name + " " + item.surname + " " + item.email);
            }

        }
    }
}
