using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;
using Microsoft.Build.Framework.XamlTypes;

namespace ChuckNoris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            var category = await ChuckNorrisClient.GetCategories();
            foreach (var c in category)
            {
                comboBox1.Items.Add(c);

            }
            
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var c = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show(c.JokeText);
            
        }
    }
}
