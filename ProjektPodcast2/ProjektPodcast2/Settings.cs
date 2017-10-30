using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektPodcast2
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string podName = txtPodName.Text;
            string newPodName = txtPodNewName.Text;
            string newUrl = txtPodNewUrl.Text;
            string newCategory = txtPodNewCategory.Text;
            

                
        }
    }
}
