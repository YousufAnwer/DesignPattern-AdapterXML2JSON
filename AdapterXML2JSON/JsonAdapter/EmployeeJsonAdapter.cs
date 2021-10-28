using AdapterXML2JSON.Target;
using AdapterXML2JSON.XmlAdaptee;
using System.Xml;

namespace AdapterXML2JSON.JsonAdapter
{
    /// <summary>
    /// using existing functionality of Xml on Line:17
    /// and convert it into JSON on Client Requirement
    /// and give access to client using IEmployee interface
    /// </summary>
    public class EmployeeJsonAdapter : EmployeeManager,IEmployee
    {

        public override string GetAllEmployees()
        {
            
            string returnXml = base.GetAllEmployees();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(returnXml);
            return Newtonsoft.Json.JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
         
        }
    }
}
