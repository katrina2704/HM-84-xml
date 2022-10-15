using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HM_84_xml_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader note = new XmlTextReader(@"C:\Users\Katrina\source\repos\HM 84 xml 2\HM 84 xml 2\XMLFile.xml");

            while (note.Read())
            {
                if(note.NodeType == XmlNodeType.Element && note.Name == "to" )
                {
                    string s1 = note.ReadElementContentAsString();
                    Console.WriteLine(s1);
                }
                if (note.NodeType == XmlNodeType.Element && note.Name == "from")
                {
                    string s2 = note.ReadElementContentAsString();
                    Console.WriteLine(s2);
                }
                if (note.NodeType == XmlNodeType.Element && note.Name == "heading")
                {
                    string s3 = note.ReadElementContentAsString();
                    Console.WriteLine(s3);
                }
                if (note.NodeType == XmlNodeType.Element && note.Name == "body")
                {
                    string s4 = note.ReadElementContentAsString();
                    Console.WriteLine(s4);
                }
            }
        }
    }
}
