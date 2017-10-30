using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;

namespace ProjektPodcast2
{
    public partial class Main : Form
    {
        internal List<Data.Podcast> podcastList = new List<Data.Podcast>();
        internal List<Data.Category> categoryList = new List<Data.Category>();
        
       
        internal Logic.RSSReader RSSReader = new Logic.RSSReader();
        internal Logic.Validator Validator = new Logic.Validator();
        public Process p = new Process();
        

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Logic.PodcastXMLHandler deserializerPod = new Logic.PodcastXMLHandler();
            Logic.CategoryXMLHandler categoryXMLHandler = new Logic.CategoryXMLHandler();

            var podcastList = deserializerPod.Deserialize(Environment.CurrentDirectory + "podcast.xml");
            var categoryList = categoryXMLHandler.Deserialize(Environment.CurrentDirectory + "category.xml");

            foreach (var item in podcastList)
            {
                var title = item.Title;
                var category = item.PodcastCategory;
                var url = item.Url;

                Data.Podcast podcast = new Data.Podcast() { Title = title, PodcastCategory = category, Url = url };
                this.podcastList.Add(podcast);


            }

            foreach (var item in categoryList)
            {
                var name = item.CategoryName;

                Data.Category category = new Data.Category() { CategoryName = name };
                this.categoryList.Add(category);
            }

            comboBox1.DataSource = this.categoryList;
            comboBox1.DisplayMember = "CategoryName";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (listBox2.SelectedItem != null)
                {
                    Data.Podcast selectedItem = listBox2.SelectedItem as Data.Podcast;
                    string url = selectedItem.Url;
                    label1.Text = "Ett ögonblick, avsnitt håller på att läsas in...";




                    var episodeList = await RSSReader.GetEpisodes(url);
                    listBox1.DataSource = null;
                    listBox1.DataSource = episodeList;
                    listBox1.DisplayMember = "EpisodeName";
                    label1.Text = "";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Avsnitten kunde inte läsas in...");
                
            }

     }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.ValidateIfStringNotNull(textBox1.Text) && Validator.ValidateIfStringNotNull(textBox2.Text) && Validator.ValidateIfStringNotNull(textBox3.Text) && Validator.ValidateUrl(textBox1.Text))
                {

                    bool exists = categoryList.Any(item => item.CategoryName == textBox2.Text);

                    if (exists)
                    {
                        Data.Category category = categoryList.Find(item => item.CategoryName.Equals(textBox2.Text));
                        var NewPodcast = new Data.Podcast() { Title = textBox3.Text, PodcastCategory = category, Url = textBox1.Text };
                        podcastList.Add(NewPodcast);
                    }
                    else
                    {
                        var NewCategory = new Data.Category() { CategoryName = textBox2.Text };

                        var NewPodcastWithNewCategory = new Data.Podcast() { Title = textBox3.Text, PodcastCategory = NewCategory, Url = textBox1.Text };

                        podcastList.Add(NewPodcastWithNewCategory);
                        categoryList.Add(NewCategory);
                    }


                    textBox1.Text = "Fyll i namn...";
                    textBox2.Text = "Fyll i kategori...";
                    textBox3.Text = "Fyll i RSS-länk...";

                    uppDateComboBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uppDateComboBox()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = categoryList;
            comboBox1.DisplayMember = "CategoryName";


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Data.Episode episode = listBox1.SelectedItem as Data.Episode;
                string info = episode.Info;
                string date = episode.PubDate;
                DateTime dateAsDateTime = Convert.ToDateTime(date);
                string modDate = dateAsDateTime.ToString("yyyy-MM-dd");
                string link = episode.Link;



                richTextBox1.Text = info + @"

Datum: " + modDate + @"

" + link;




            }

        }







        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_LinkClicked_1(object sender, LinkClickedEventArgs e) => p = Process.Start(e.LinkText);

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedItem != null)
            {
                var category = comboBox1.SelectedItem as Data.Category;
                string categoryName = category.CategoryName;

                listBox2.DataSource = null;
                listBox2.DataSource = podcastList
                .Where(items => items.PodcastCategory.CategoryName.Equals(categoryName))
                .ToList();
                listBox2.DisplayMember = "Title";




            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {



                Data.Episode episodeLink = listBox1.SelectedItem as Data.Episode;
                var valdMp3Link = episodeLink.Mp3Link;
                Data.Episode titel = listBox1.SelectedItem as Data.Episode;
                var namn = titel.EpisodeName;
                string fileLocation = Environment.CurrentDirectory + namn.Replace("/", "av").Replace("&", "och").Replace(" ", "").Replace(":", "") + ".mp3";


                using (var client = new WebClient())
                {
                    label1.Text = "Filen laddas ner...";
                    await Task.Run(() => client.DownloadFile(valdMp3Link, fileLocation));
                    MessageBox.Show("Avsnitt: " + namn + " har laddats ner");
                }

            }
            catch
            {
                MessageBox.Show("Filen kunde inte laddas ner");
            }

            label1.Text = "";
        }



        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            Data.Episode titel = listBox1.SelectedItem as Data.Episode;
            var namn = titel.EpisodeName;
            string fileLocation = Environment.CurrentDirectory + namn.Replace("/", "av").Replace("&", "och").Replace(" ", "").Replace(":", "") + ".mp3";
            axWindowsMediaPlayer1.URL = fileLocation;
        }



        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logic.PodcastXMLHandler serializer = new Logic.PodcastXMLHandler();
            Logic.CategoryXMLHandler categoryXMLHandler = new Logic.CategoryXMLHandler();

            serializer.Serialize(podcastList);
            categoryXMLHandler.Serialize(categoryList);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
                    
        }
    }
}
