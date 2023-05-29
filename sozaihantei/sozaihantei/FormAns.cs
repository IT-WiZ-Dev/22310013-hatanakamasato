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
    public partial class FormAns : Form
    {
        Shoukai s;
        public FormAns(Shoukai shoukai)
        {
            InitializeComponent();
            s = shoukai;
        }

        private void FormAns_Load(object sender, EventArgs e)
        {
            labelKijiName.Text = s.getOsusumeName();
            labelShoukai.Text = s.getShoukaiStg();
            pictureBoxAns.Image = s.getImg();
            pictureBoxAns.SizeMode = PictureBoxSizeMode.Zoom;

        }
    }
}
