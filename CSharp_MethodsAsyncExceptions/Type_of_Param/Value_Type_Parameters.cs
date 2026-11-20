using System;

namespace Type_of_Param
{
    class Program
    {
        static void Main()
        {
            int IdEmployee = 101;
            bool IsActive = true;
            String EmpName = "Amala";

            UpdateEmployeeDetails(IdEmployee,IsActive,EmpName);
            Console.WriteLine($"outside method");
            Console.WriteLine($"employ ID      :{IdEmployee}");
            Console.WriteLine($"Employ Active  :{IsActive}");
            Console.WriteLine($"Employ Name    :{EmpName}");
        }
        static void UpdateEmployeeDetails(int empid,bool status, string name)
        {
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
