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

namespace ChuckNorrisForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnGetJoke_Click(object sender, EventArgs e)
        {
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show($"{j.Id}:{j.JokeText}\n\n{string.Join(", ", j.Categories)}");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var cat in categories)
            {
                DdCategories.Items.Add(cat);
            }
        }
    }
}
