using System;
namespace TypeParameter_Ref_vs_Out
{
    class Program
    {
        static void Main()
        {
            int IdEmployeeRef = 101;
            bool IsActiveRef = true;
            String EmpNameRef = "Amala";


            // Ref
            UpdateEmployeeDetails(ref IdEmployeeRef, ref IsActiveRef, ref EmpNameRef);
            Console.WriteLine($"UPDATE method");
            Console.WriteLine($"employ ID      :{IdEmployeeRef}");
            Console.WriteLine($"Employ Active  :{IsActiveRef}");
            Console.WriteLine($"Employ Name    :{EmpNameRef}");


            int IdEmployeeOut;
            bool IsActiveOut ;
            String EmpNameOut ;
            //Out
            GetEmployeeDetails(out IdEmployeeOut, out IsActiveOut, out EmpNameOut);
            Console.WriteLine($"GET method");
            Console.WriteLine($"employ ID      :{IdEmployeeOut}");
            Console.WriteLine($"Employ Active  :{IsActiveOut}");
            Console.WriteLine($"Employ Name    :{EmpNameOut}");
        }
        static void UpdateEmployeeDetails(ref int empid, ref bool status, ref string name)
        {
            empid = 201;
            status = false;
            name = "Sheru Bhai 1";
        }
        static void GetEmployeeDetails(out int empid, out bool status, out string name)
        {
            empid = 2001;
            status = false;
            name = "Sheru Bhai 2";
        }
    }
}
