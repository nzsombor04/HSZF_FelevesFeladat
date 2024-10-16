using System.Xml.Linq;

namespace HSZF_FelevesFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public void XmlLoad()
        {
            // XML file beolvasas
            string filePath = "employees-departments.xml";
            XDocument xmlDoc = XDocument.Load(filePath);

            //Minden alkalmazott feldolgozasa
            var employees = xmlDoc.Descendants("Employee")
                .Select(e => new
                {
                    EmployeeId = e.Attribute("employeeid")?.Value,
                    Name = e.Element("Name")?.Value,
                    BirthYear = e.Element("BirthYear")?.Value,
                    StartYear = e.Element("StartYear")?.Value,
                    ConpletedProjects = e.Element("CompletedProjects")?.Value,
                    Active = e.Element("Active")?.Value,
                    Retired = e.Element("Retired")?.Value,
                    Email = e.Element("Email")?.Value,
                    Phone = e.Element("Phone")?.Value,
                    Job = e.Element("Job")?.Value,
                    Level = e.Element("Level")?.Value,
                    Salary = e.Element("Salary")?.Value,
                    Commission = e.Element("Commission")?.Value,
                    Departments = e.Element("Departments").Elements("Department")
                        .Select(d => new
                        {
                            DepartmentName = d.Element("Name")?.Value,
                            DepartmentCode = d.Element("DepartmentCode")?.Value,
                            HeadfOfDepartment = d.Element("HeadOfDepartment")?.Value,
                        }).ToList()
                });
        }
    }
}
