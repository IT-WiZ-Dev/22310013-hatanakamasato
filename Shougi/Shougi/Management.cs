using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shougi
{
    public class Management
    {
        public string testkihu;
        public int[] numBanKihu;
        public int[,] numKihu;
        public string[] komaMoveName;
        public string[] komaBeforeMoveName;

        public Koma[] holdingKoma;
        public string[] holdingKomaName;
        public Image[] holdingKomaImg;
        public List<Koma> senteHold;
        public List<Koma> goteHold;
        public int maxtesuu;

        //数字だけ取り出す
        public void setKihu() {
            string[] kihuLines = testkihu.Split(new[] { "\n" }, StringSplitOptions.None);
            List<int> kihuList = new List<int>();
            List<string> kihuNameList = new List<string>();
            bool flg = false;
            for (int i = 0; i < kihuLines.Length; i++) {
                if (kihuLines[i].StartsWith("+") || kihuLines[i].StartsWith("-"))
                {
                    if (flg)
                    {
                        kihuList.Add(int.Parse(kihuLines[i].Substring(1, 4)));
                        kihuNameList.Add(kihuLines[i].Substring(5, 2));
                    }else
                    {
                        flg = true;
                    }
                }
            }
            numBanKihu = kihuList.ToArray();
            komaMoveName = kihuNameList.ToArray();

            maxtesuu = numBanKihu.Length;
            komaBeforeMoveName = new string[maxtesuu];
            holdingKoma = new Koma[maxtesuu];
            holdingKomaName = new string[maxtesuu];
            holdingKomaImg = new Image[maxtesuu];
            senteHold = new List<Koma>();
            goteHold = new List<Koma>();
            numKihu = new int[maxtesuu, 4];
            
            for (int i = 0; i < numBanKihu.Length; i++)
            {
                int value = numBanKihu[i];

                int nowX = 9 - value / 1000;
                value = value % 1000;
                int nowY = value / 100 - 1;
                value = value % 100;
                int afX = 9 - value / 10;
                value = value % 10;
                int afY = value - 1;

                //もし持ち駒から指したら
                if (numBanKihu[i] < 100)
                {
                    nowX = -1;
                    nowY = -1;
                }
                
                numKihu[i, 0] = nowX;
                numKihu[i, 1] = nowY;
                numKihu[i, 2] = afX;
                numKihu[i, 3] = afY;
            }

        }


    }
}
