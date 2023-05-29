using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sozaihantei
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(@"C:\Users\hatam\Pictures\visual\seni.jpg");
            //pictureBoxSeni.Image = Image.FromFile(@"C:\Users\hatam\Pictures\visual\seni4.jpg");
            labelTitle.BackColor = Color.Transparent;
            buttonSubtitle.TextAlign = ContentAlignment.MiddleLeft;


        }

        private void buttonSindan_Click(object sender, EventArgs e)
        {
            FormSindan form = new FormSindan();
            form.Show();
        }
    }
}
