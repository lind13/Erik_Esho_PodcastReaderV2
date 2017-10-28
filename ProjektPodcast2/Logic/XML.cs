using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Logic
{
    class XML
    {
        public void Main(string[] arg)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Data.Category));
            TextReader reader = new StreamReader(@"C:\myXml.xml");
            object obj = deserializer.Deserialize(reader);
            Data.Category XmlData = (Data.Category)obj;
            reader.Close();
        }
    }
}
