using HSZF_FelevesFeladat.Model;
using System.Xml.Linq;

namespace HSZF_FelevesFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public List<Employee> XmlLoad()
        {
            // XML file beolvasas
            string filePath = "employees-departments.xml";
            XDocument xmlDoc = XDocument.Load(filePath);

            //Minden alkalmazott feldolgozasa
            var employees = xmlDoc.Descendants("Employee")
                .Select(e => new Employee
                {
                    EmployeeId = int.Parse(e.Attribute("employeeid").Value),
                    Name = e.Element("Name").Value,
                    BirthYear = int.Parse(e.Element("BirthYear").Value),
                    StartYear = int.Parse(e.Element("StartYear").Value),
                    CompletedProjects = int.Parse(e.Element("CompletedProjects").Value),
                    Active = bool.Parse(e.Element("Active").Value),
                    Retired = bool.Parse(e.Element("Retired").Value),
                    Email = e.Element("Email").Value,
                    Phone = e.Element("Phone").Value,
                    Job = e.Element("Job").Value,
                    Level = e.Element("Level").Value,
                    Salary = int.Parse(e.Element("Salary").Value),
                    Commission = int.Parse(e.Element("Commission").Value),
                    Departments = e.Element("Departments").Elements("Department")
                        .Select(d => new Department
                        {
                            DepartmentName = d.Element("Name").Value,
                            DepartmentCode = d.Element("DepartmentCode").Value,
                            HeadOfDepartment = d.Element("HeadOfDepartment").Value
                        }).ToList()
                }).ToList();

            return employees;
        }
    }
}
