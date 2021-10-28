using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AdapterXML2JSON.XmlAdaptee
{
    public class EmployeeManager
    {
        public List<Employee> listEmpolyee;
        public EmployeeManager()
        {
            listEmpolyee = new List<Employee>();
            this.listEmpolyee.Add(new Employee(1, "Ibraheem"));
            this.listEmpolyee.Add(new Employee(2, "Dawood"));
            this.listEmpolyee.Add(new Employee(3, "Zakariya"));
        }
        public virtual string GetAllEmployees()
        {
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(listEmpolyee.GetType());


            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, listEmpolyee, emptyNamepsaces);
                return stream.ToString();
            }
        }
    }
}
