using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shougi
{
    
    public partial class Touroku : Form
    {
        public Touroku()
        {
            InitializeComponent();
        }

        private void buttonTouroku_Click(object sender, EventArgs e)
        {
            StreamReader fileReader = new StreamReader(@"C:\Users\hatam\source\repos\Shougi\gamerecord.txt");
            string text = fileReader.ReadToEnd();
            int kihucnt = int.Parse((text.Substring(text.Length - 3, 1)));
            kihucnt++;
            fileReader.Close();

            Encoding enc = Encoding.GetEncoding("UTF-8");
            // ファイルを開く
            StreamWriter writerKihu = new StreamWriter(@"C:\Users\hatam\source\repos\Shougi\gamerecord.txt", true, enc);
            writerKihu.WriteLine("KihuSearch" + kihucnt);
            writerKihu.WriteLine(textBoxKihu.Text);
            writerKihu.WriteLine("KihuSearch" + kihucnt);
            // ファイルを閉じる
            writerKihu.Close();

            // ファイルを開く
            StreamWriter writerSearch = new StreamWriter(@"C:\Users\hatam\source\repos\Shougi\gamerecordSearch.txt", true, enc);
            writerSearch.WriteLine(textBoxDaimei.Text);
            writerSearch.WriteLine(comboBoxSenkei.Text);
            writerSearch.WriteLine(comboBoxSenkeiEnemy.Text);
            writerSearch.WriteLine(comboBoxKakoi.Text);
            writerSearch.WriteLine(comboBoxKakoiEnemy.Text);
            writerSearch.WriteLine(comboBoxFS.Text);
            writerSearch.WriteLine(comboBoxOutcome.Text);
            writerSearch.WriteLine(comboBoxTrouble.Text);

            writerSearch.Close();





            this.Close();
            
        }

        private void Touroku_Load(object sender, EventArgs e)
        {
            ControllerSet controllerset = new ControllerSet();
            //任意の文字を入れられないようにする
            controllerset.setSenkei(comboBoxSenkei);
            controllerset.setKakoi(comboBoxKakoi);

            controllerset.setFS(comboBoxFS);
            controllerset.setOutcome(comboBoxOutcome);
            controllerset.setTrouble(comboBoxTrouble);

            //相手
            controllerset.setSenkei(comboBoxSenkeiEnemy);
            controllerset.setKakoi(comboBoxKakoiEnemy);




            comboBoxSenkei.SelectedIndex = 0;
            comboBoxKakoi.SelectedIndex = 0;
            comboBoxFS.SelectedIndex = 0;
            comboBoxOutcome.SelectedIndex = 0;
            comboBoxTrouble.SelectedIndex = 0;

            comboBoxSenkeiEnemy.SelectedIndex = 0;
            comboBoxKakoiEnemy.SelectedIndex = 0;


        }
    }
}
