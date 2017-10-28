﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Data
{
    public class Category
    {
        [XmlElement ("Category Name")]
        public string CategoryName { get; set; }
        [XmlArray ("List of Pods")]
        public List<Podcast> PodList { get; set; }
    }
}
