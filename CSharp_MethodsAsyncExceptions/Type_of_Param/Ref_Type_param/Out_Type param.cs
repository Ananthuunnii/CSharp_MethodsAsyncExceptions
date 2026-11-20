using System;

namespace TypeParameter_OutType
{
    class Program
    {
        static void Main()
        {
            int IdEmployee = 101;
            bool IsActive; //= true;
            String EmpName; // = "Amala";

            // we need to pass the arguments using "out" keyword
            // it's not mandatery to assign value to arguments before passing
            // we can initilise the variable and pass as a argument with "out" keyword
            // also it will update the oroginal value after updating parameters in method
            UpdateEmployeeDetails(out IdEmployee,out IsActive,out EmpName);
            Console.WriteLine($"outside method");
            Console.WriteLine($"employ ID      :{IdEmployee}");
            Console.WriteLine($"Employ Active  :{IsActive}");
            Console.WriteLine($"Employ Name    :{EmpName}");
        }
        static void UpdateEmployeeDetails(out int empid,out bool status,out string name)
        {
            // we need to update/assign value that parameter have "out"
            // otherwise it get compile time error
            empid = 201;
            status = false;
            name = "Sheru Bhai";

            Console.WriteLine($"inside method");
            Console.WriteLine($"employ ID      :{empid}");
            Console.WriteLine($"Employ Active  :{status}");
            Console.WriteLine($"Employ Name    :{name}");
        }
    }
}
