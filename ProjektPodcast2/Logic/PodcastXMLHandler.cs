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
    public class PodcastXMLHandler
    {   

        public void Serialize(object o)
        {
            string path = Environment.CurrentDirectory + "podcast.xml";
         
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

        public List<Podcast> Deserialize(string path)
        {

           

            
            XmlSerializer fromXML = new XmlSerializer(typeof(List<Podcast>));
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var obj = fromXML.Deserialize(fs);

            var lista = (List<Podcast>)obj;

            return lista;



        }                   
    }
    }


