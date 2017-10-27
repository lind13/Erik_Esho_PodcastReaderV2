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

namespace ProjektPodcast2
{
    public partial class Form1 : Form
    {
        private List<Data.Podcast> podcastList = new List<Data.Podcast>();
        private List<Data.Category> categoryList = new List<Data.Category>();
        private Logic.RSSReader RSSReader = new Logic.RSSReader();
        private Logic.Validator Validator = new Logic.Validator();
        public Process p = new Process();




        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
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
            catch (Exception)
            {




            }


        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (Validator.ValidateIfStringNotNull(textBox1.Text) && Validator.ValidateUrl(textBox1.Text) && Validator.ValidateIfStringNotNull(textBox2.Text) && Validator.ValidateIfStringNotNull(textBox3.Text))
                {


                    var NewCategory = new Data.Category() { CategoryName = textBox2.Text };

                    var NewPodcast = new Data.Podcast() { Title = textBox3.Text, PodcastCategory = NewCategory, Url = textBox1.Text };


                    podcastList.Add(NewPodcast);
                    categoryList.Add(NewCategory);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();


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
            if(listBox1.SelectedItem != null)
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

                listBox2.DataSource = null;
                listBox2.DataSource = podcastList
                .Where(items => items.PodcastCategory.Equals(category))
                .ToList();
                listBox2.DisplayMember = "Title";




            }
        }
    }
}
