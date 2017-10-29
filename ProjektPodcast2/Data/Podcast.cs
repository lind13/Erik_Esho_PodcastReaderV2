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
        [XmlElement("Titel")]
        public string Title { get; set; }
        [XmlArray("Episodlista"), XmlArrayItem(typeof(Episode))]
        public List<Episode> EpisodeList { get; set; }
        [XmlElement("Podcastgenre")]
        public Category PodcastCategory { get; set; }
        [XmlElement("RSS-feed")]
        public string Url { get; set; }
    }
}
