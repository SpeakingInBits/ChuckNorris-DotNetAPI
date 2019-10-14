using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisJoekWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            Joke j = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show(Convert.ToString(j.JokeText));

            
        }

        private  async void Form1_Load(object sender, EventArgs e)
        {
            var c =  await ChuckNorrisClient.GetCategories();
           
            foreach (var cat in c)
            {
                comboBox1.Items.Add(cat);
            }
            
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
