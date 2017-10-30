using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.IO.IsolatedStorage;
using Data;

namespace Logic
{
    public class XML
    {
        public void Main(string[] args)
        {
            
        }

        public void Serialize(object o)
        {
            string path = Environment.CurrentDirectory + "test.xml";
         
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
                    //TextWriter textWriter = new StreamWriter(path);
                    toXML.Serialize(file, o);
                }
            }
                        
            //Data.Category category = new Data.Category();
            //Data.Episode episode = new Data.Episode();
            //Data.Podcast podcast = new Data.Podcast();
        }

        public List<Podcast> Deserialize(string path)
        {

            //var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            string path = Environment.CurrentDirectory + "test.xml";
            XmlSerializer fromXML = null;
            FileStream fs = new FileStream(path, FileMode.Open);
            fromXML.Deserialize(fs);
            
        }                   
    }
    }


