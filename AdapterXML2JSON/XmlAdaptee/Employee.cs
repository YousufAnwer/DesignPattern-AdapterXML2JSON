using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdapterXML2JSON.XmlAdaptee
{
    [Serializable]
    public  class Employee
    {
        Employee() { }
        public Employee(int id, string name)
        {
            this.employeeId = id;
            this.employeeName = name;
        }
        [XmlAttribute]
        public int employeeId { get; set; }
        [XmlAttribute]
        public string  employeeName { get; set; }
    }
}
