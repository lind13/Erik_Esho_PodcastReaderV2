using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Category
    {
        public string CategoryName { get; set; }

        public List<Podcast> PodList { get; set; }
    }
}
