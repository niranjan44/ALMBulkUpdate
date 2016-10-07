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
        private const int AutoCompleteElementsCount = 50;
        private const string XMLFilePath = "ALMRun.xml";

        public XMLOperations()
        {
            ReadXMLAutoSource();
        }
        public void ReadXMLAutoSource()
        {
            try
            {
                // string path = "ALMRun.xml";
                if (File.Exists(XMLFilePath))
                {
                    xDoc = XDocument.Load(XMLFilePath);
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
            xDoc.Save(XMLFilePath);
        }

        public void AddToAutoCompleteSource(string node, string value)
        {
            try
            {
                if (!IsElementPresent(node, value))
                {
                    xDoc.Element("TextBoxAutoCompleteSource").Element(node).Add(
                        new XElement("Name", value));
                    xDoc.Save(XMLFilePath);
                    LimitAutoSourceElement(node);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private bool IsElementPresent(string node, string value)
        {
            string[] elements = ReadAutoSource(node);

            if (elements.Contains(value))
                return true;
            else
                return false;

        }

        private void LimitAutoSourceElement(string node)
        {
            IEnumerable<XElement> elements = xDoc.Root.Descendants(node).Elements();

            if (elements.Count() > AutoCompleteElementsCount)
            {
                XElement lastElement = elements.FirstOrDefault();
                lastElement.Remove();


            }

        }

        public string[] ReadAutoSource(string node)
        {
            try
            {
                List<string> values = new List<string>();
                IEnumerable<XElement> elements = xDoc.Root.Descendants(node).Elements();

                int count = elements.Count();

                foreach (XElement element in elements)
                {
                    values.Add(element.Value);
                }

                return values.ToArray<string>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
