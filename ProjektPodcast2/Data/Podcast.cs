using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Podcast
    {
        public string Title { get; set; }

        public List<Episode> EpisodeList { get; set; }

        public Category PodcastCategory { get; set; }

        public string Url { get; set; }

    }
}
