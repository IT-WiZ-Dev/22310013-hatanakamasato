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
    public partial class Hitkihu : Form
    {

        string[] textArr;
        List<int> agerrment;
        int[] agerrment_num;
        string[] title = { "題名：", "自分の戦型　", "相手の戦型　", "自分の囲い　", "相手の囲い　", "", "", "手数　" };
        public Hitkihu(string[] _textArr, List<int> _agreement)
        {
            textArr = _textArr;
            agerrment = _agreement;
            agerrment_num = new int[agerrment.Count];
            for(int i = 0; i < agerrment.Count; i++)
            {
                agerrment_num[i] = agerrment[i] / 8 + 1;
            }
            InitializeComponent();
        }

        private void Hitkihu_Load(object sender, EventArgs e)
        {
            int point = 0;
            int agerrmentCnt = agerrment.Count;
            for(int i = 0; i < agerrmentCnt; i++)
            {
                int num = agerrment[0];
                Button b = new Button();
                setText(b, num);
                b.ForeColor = Color.White;
                b.Font = new Font("Arial",14, FontStyle.Bold);
                b.BackColor = Color.FromArgb(240, 150, 0);
                b.Location = new Point(0, point);
                point += 220;
                b.Size = new Size(430, 200);
                b.Tag = agerrment_num[i];
                b.Click += new EventHandler(button_Click_Play);
                this.Controls.Add(b);
                agerrment.RemoveAt(0);
            }

        }
        void setText(Button b, int num)
        {
            for(int i = -1; i < 7; i++)
            {
                if(textArr[num + i].Equals("選択しない"))
                {
                    b.Text += (title[i + 1] + "未設定" + "\n");
                }
                else 
                {
                    b.Text += (title[i + 1] + textArr[num + i] + "\n");
                }
                
            }
        }

        private void button_Click_Play(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string kihu_number = clickedButton.Tag.ToString();
            Saisei s = new Saisei(kihu_number);
            s.Show();
        }
    }
}
