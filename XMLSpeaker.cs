using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAB_8
{
    public class XMLSpeaker
    {
        public string filePath;
        public string fileName;
        XElement root;
        public XMLSpeaker(string fileName)
        {
            this.fileName = fileName;
            var currentDirectory = Directory.GetCurrentDirectory();
            filePath = Path.Combine(currentDirectory, fileName);
            root = XElement.Load(filePath);
        }

        public IEnumerable<XElement> GetAllData()
        {
            root = XElement.Load(filePath);
            IEnumerable<XElement> result =
                from el in root.Elements("student")
                select el;
            return result;
        }

        public IEnumerable<XElement> GetSpecificData(string column, string value)
        {
            root = XElement.Load(filePath);
            IEnumerable<XElement> result =
                from el in root.Elements("student")
                where "" + (string)el.Element(column).Value == "" + (string)value
                select el;
            return result;
        }

        public XElement CreateElement(string course, string groupID, string LastName, string checkBookID, string study, string mark)
        {
            return new XElement("student",
                   new XElement("course", course),
                   new XElement("groupID", groupID),
                   new XElement("lastName", LastName),
                   new XElement("checkbookID", checkBookID),
                   new XElement("study", study),
                   new XElement("mark", mark));
        }

        public void writeToFile(XElement element)
        {
            root.Add(element);
            root.Save(filePath);
        }

        public Dictionary<string, float> getAVGMarks(string ColumnName,string ValColumnName)
        {
            IEnumerable<XElement> values = GetAllData();
            Dictionary<string, float> result = new Dictionary<string, float>();
            Dictionary<string, int> counter = new Dictionary<string, int>();
            Dictionary<string, float> final_result = new Dictionary<string, float>();
            foreach (XElement element in values)
            {
                if (result.ContainsKey(element.Element(ColumnName).Value)){
                    result[element.Element(ColumnName).Value] += float.Parse(element.Element(ValColumnName).Value);
                    counter[element.Element(ColumnName).Value]++;
                }
                else
                {
                    result.Add(element.Element(ColumnName).Value, float.Parse(element.Element(ValColumnName).Value));
                    counter.Add(element.Element(ColumnName).Value,1);
                }
            }

            foreach (KeyValuePair<string,float> val in result)
            {
                final_result.Add(val.Key,val.Value / counter[val.Key]);
            }
            return final_result;
        }
    }
}
