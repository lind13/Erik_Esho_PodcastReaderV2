using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ServiceModel.Syndication;


namespace Logic
{
    public class RSSReader
    {
      
        public async Task<List<Data.Episode>> GetEpisodes(string url)
        {
            var xml = "";
            var feedOfPodcasts = new List<Data.Episode>();
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                await Task.Run(() => xml = client.DownloadString(url));
            }


            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);


            foreach (System.Xml.XmlNode item
               in dom.DocumentElement.SelectNodes("channel/item"))
            {

                var title = item.SelectSingleNode("title").InnerText;
                var date = item.SelectSingleNode("pubDate").InnerText;
                var link = item.SelectSingleNode("link").InnerText;
                var info = item.SelectSingleNode("description").InnerText;
                var feedItem = new Data.Episode() {EpisodeName = title, PubDate = date, Link = link, Info = info };

                feedOfPodcasts.Add(feedItem);

            }

             return feedOfPodcasts;
        }



    }
}
