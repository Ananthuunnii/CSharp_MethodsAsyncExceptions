using System;

namespace TypeParameter_InType
{
    class Program
    {
        static void Main()
        {
            int IdEmployee = 101;
            bool IsActive = true;
            String EmpName = "Amala";


            // use "in" to pass parameter for readonly purpuse 
            // passing a "in" parameter must assign a value
            UpdateEmployeeDetails(in IdEmployee, in IsActive, in EmpName);      // here we use the "in" 
            Console.WriteLine($"outside method");
            Console.WriteLine($"employ ID      :{IdEmployee}");
            Console.WriteLine($"Employ Active  :{IsActive}");
            Console.WriteLine($"Employ Name    :{EmpName}");
        }
        static void UpdateEmployeeDetails(in int empid,in bool status,in string name) // also in method we use "in"
        {
            //Readonly access Allowed
            //empid = 201;  // we can't able to update is show compile time error
            Console.WriteLine($"inside method");
            Console.WriteLine($"employ ID      :{empid }");
            Console.WriteLine($"Employ Active  :{status}");
            Console.WriteLine($"Employ Name    :{name}");
        }
    }
}
