using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Data
{
    public class Episode
    {
        [XmlElement("Episod")]
        public string EpisodeName { get; set; }
        [XmlElement("Datum")]
        public string PubDate { get; set; }
        [XmlElement ("Länk")]
        public string Link { get; set; }
        [XmlElement ("Information")]
        public string Info { get; set; }
        [XmlElement ("MP3-fil")]
        public string Mp3Link { get; set; }
      
    }


}
