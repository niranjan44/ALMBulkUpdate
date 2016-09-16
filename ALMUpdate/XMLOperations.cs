using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace ALMUpdate
{
    class XMLOperations
    {
        XDocument xDoc;

        public XMLOperations()
        {
            ReadXMLAutoSource();
        }
        public void ReadXMLAutoSource()
        {
            try
            {
                string path = "Data.xml";
                if (File.Exists(path))
                {
                    xDoc = XDocument.Load(path);
                }
                else
                {
                    CreateAutoCompleteXMLSource();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void CreateAutoCompleteXMLSource()
        {
             xDoc = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Texboxes autocomplete XML source"),
                new XElement("TextBoxAutoCompleteSource",
                  new XElement("TestFolders"),
                   new XElement("ReleaseFolders"),
                    new XElement("ReleaseNames"),
                     new XElement("CycleNames")
                  ));
            xDoc.Save("Data.xml");
        }

        public void AddToAutoCompleteSource(string node, string value)
        {
            try
            {
                xDoc.Element("TextBoxAutoCompleteSource").Element(node).Add(
                    new XElement("Name", value));
                xDoc.Save("Data.xml");
                LimitAutoSourceElement(node);
               
            }
            catch(Exception ex)
            {

            }
        }

        private void LimitAutoSourceElement(string node)
        {
            IEnumerable<XElement> elements = xDoc.Root.Descendants(node).Elements();

            if(elements.Count()>10)
            {
                XElement lastElement = elements.FirstOrDefault();
                lastElement.Remove();
               // xDoc.Save("Data.xml");

            }

        }

        public string[] ReadAutoSource(string node)
        {
            try
            {
                List<string> values = new List<string>();
                IEnumerable<XElement> elements = xDoc.Root.Descendants(node).Elements();

                int count = elements.Count();

                foreach(XElement element in elements)
                {
                    values.Add(element.Value);
                }

                return values.ToArray<string>();
            }
            catch(Exception ex)
            {
                return null;
            }
        }


    }
}
