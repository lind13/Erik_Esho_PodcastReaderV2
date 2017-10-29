using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.IO.IsolatedStorage;

namespace Logic
{
    class XML
    {
        

        public void Main(string[] args)
        {
           
        }

        public void Serializer(object o)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            XmlSerializer toXML = new XmlSerializer(o.GetType());
            TextWriter textWriter = new StreamWriter(path);
            Data.Category category = new Data.Category();
            Data.Episode episode = new Data.Episode();
            Data.Podcast podcast = new Data.Podcast();
            FileStream file = File.Create(path);
            toXML.Serialize(file, o);
            

            
        }

        public void Deserialize(object o)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            XmlSerializer fromXML = null;
            FileStream fs = new FileStream(path, FileMode.Open);
            fromXML.Deserialize(fs);
            
        }                   
    }
    }


