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
    public class Podcast
    {       
        [XmlElement("Title")]
        public string Title { get; set; }
        [XmlArray("EpisodeList"), XmlArrayItem(typeof(Episode))]
        public List<Episode> EpisodeList { get; set; }
        [XmlElement("Category")]
        public Category PodcastCategory { get; set; }
        [XmlElement("URL")]
        public string Url { get; set; }
    }
}
