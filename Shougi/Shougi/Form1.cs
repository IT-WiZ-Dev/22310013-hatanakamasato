using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shougi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonkensaku_Click(object sender, EventArgs e)
        {
            Kensaku kensaku = new Kensaku();
            kensaku.Show();
        }


        private void buttonTouroku_Click(object sender, EventArgs e)
        {
            
            Touroku touroku = new Touroku();
            touroku.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
