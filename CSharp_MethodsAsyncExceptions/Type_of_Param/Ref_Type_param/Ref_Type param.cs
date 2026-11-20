using System;

namespace TypeParameter_RefType
{
    class Program
    {
        static void Main()
        {
            int IdEmployee = 101;
            bool IsActive = true;
            String EmpName = "Amala";
            // ----------------------Ref type parameter
            // if we modify any parameter ref value it will impacted to the original value

            //must be initilise the arguments before passing

            // if we update the parameter inside the method it also reflect to the outside of method
            UpdateEmployeeDetails(ref IdEmployee, ref IsActive, ref EmpName);
            Console.WriteLine($"outside method");
            Console.WriteLine($"employ ID      :{IdEmployee}");
            Console.WriteLine($"Employ Active  :{IsActive}");
            Console.WriteLine($"Employ Name    :{EmpName}");
        }
        static void UpdateEmployeeDetails(ref int empid, ref bool status, ref string name)
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
