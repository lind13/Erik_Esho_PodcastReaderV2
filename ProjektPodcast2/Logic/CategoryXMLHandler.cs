using Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logic
{
    public class CategoryXMLHandler
    {
        public void Serialize(object o)
        {
            string path = Environment.CurrentDirectory + "category.xml";

            if (File.Exists(path))
            {
                using (FileStream file = File.Create(path))
                {
                    XmlSerializer toXML = new XmlSerializer(o.GetType());
                    toXML.Serialize(file, o);
                }
            }
            else
            {
                using (FileStream file = File.Create(path))
                {
                    XmlSerializer toXML = new XmlSerializer(o.GetType());              
                    toXML.Serialize(file, o);
                }
            }


        }

        public List<Category> Deserialize(string path)
        {

            XmlSerializer fromXML = new XmlSerializer(typeof(List<Category>));
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var obj = fromXML.Deserialize(fs);

            var lista = (List<Category>)obj;

            return lista;

        }

    }
}
