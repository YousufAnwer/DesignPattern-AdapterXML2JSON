using AdapterXML2JSON.JsonAdapter;
using AdapterXML2JSON.Target;
using System;

namespace AdapterXML2JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp = new EmployeeJsonAdapter();
            string value = emp.GetAllEmployees();
            Console.ReadLine();
        }
    }
}
