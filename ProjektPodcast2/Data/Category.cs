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
    public class  Category
    {
        [XmlElement("CategoryName")]
        public string CategoryName { get; set; }
        [XmlArray ("PodcastList"), XmlArrayItem(typeof(Podcast))]
        public List<Podcast> PodList { get; set; }
    }
}
