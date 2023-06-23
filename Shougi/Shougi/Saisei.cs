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
    public partial class Saisei : Form
    {
        public static Management management = new Management();
        KomaManagement komaMane = new KomaManagement();
        Koma[,] field = new Koma[9, 9];//
        int tesuu = 0;
        
       
        public Saisei(string kihu_number)
        {
            StreamReader fileReader = new StreamReader(@"C:\Users\hatam\source\repos\Shougi\gamerecord.txt");
            string textInput = fileReader.ReadToEnd();
            string searchText = "KihuSearch" + kihu_number;

            string extractedText = GetTextBetweenStrings(textInput, searchText, searchText);

            management.testkihu = extractedText;
            management.setKihu();

            fileReader.Close();

            InitializeComponent();
        
        }

        private static string GetTextBetweenStrings(string input, string start, string end)
        {
            int startIndex = input.IndexOf(start);
            if (startIndex == -1) return string.Empty;

            startIndex += start.Length;

            int endIndex = input.IndexOf(end, startIndex);
            if (endIndex == -1) return string.Empty;

            return input.Substring(startIndex, endIndex - startIndex);
        }




        private void Saisei_Load(object sender, EventArgs e)
        {

            //背景を盤と同じ色にする
            this.BackgroundImage = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\haikei.png");

            pictureBoxTatami.Image = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\tatami.jpg");
            pictureBoxShougiban.Image = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\sbn420.jpg");
           
            PictureBox pictureBoxRight = new PictureBox();
            pictureBoxRight.Image = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\right.jpg");
            buttonRight.FlatStyle = FlatStyle.Flat;
            buttonRight.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRight.BackgroundImage = pictureBoxRight.Image;

            PictureBox pictureBoxLeft = new PictureBox();
            pictureBoxLeft.Image = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\left.jpg");
            buttonLeft.FlatStyle = FlatStyle.Flat;
            buttonLeft.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLeft.BackgroundImage = pictureBoxLeft.Image;
            
            //一番最初の画面設定
            //fieldにセット
            komaMane.setFirstKoma(field);
            //画面に表示
            fieldIndication(field);


            
            

        }
        void fieldIndication(Koma[,] field)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!(field[i, j] == null))
                    {
                        this.Controls.Add(field[i, j].getNowPic());
                        field[i, j].getNowPic().BringToFront(); 
                    }
                }
            } 
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if(tesuu < management.maxtesuu)
            {
                komaMane.moveKoma(field, tesuu);
                tesuu++;
            }

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if(tesuu > 0)
            {
                tesuu--;
                komaMane.returnKoma(field, tesuu);
            }

        }

        private void pictureBoxTatami_Click(object sender, EventArgs e)
        {

        }
    }
}
