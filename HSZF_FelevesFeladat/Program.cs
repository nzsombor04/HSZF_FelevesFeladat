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
        }
    }
}
