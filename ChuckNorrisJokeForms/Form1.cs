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

namespace ChuckNorrisJokeForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jokeBtn_Click(object sender, EventArgs e)
        {
            Joke joke = new Joke();
            MessageBox.Show($"{joke.JokeText}");
        }
    }
}
