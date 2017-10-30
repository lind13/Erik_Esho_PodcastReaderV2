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
    [Serializable]
    public class Episode
    {
        [XmlElement("Episode")]
        public string EpisodeName { get; set; }
        [XmlElement("Date")]
        public string PubDate { get; set; }
        [XmlElement("Link")]
        public string Link { get; set; }
        [XmlElement("Information")]
        public string Info { get; set; }
        [XmlElement("MP3Link")]
        public string Mp3Link { get; set; }
    }

    


}
