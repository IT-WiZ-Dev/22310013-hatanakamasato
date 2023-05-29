using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Shougi
{
    class KomaManagement
    {
        Management management = Saisei.management;
        int[] huP = { 2, 0, 2, 1, 2, 2, 2, 3, 2, 4, 2, 5, 2, 6, 2, 7, 2, 8, 6, 0, 6, 1, 6, 2, 6, 3, 6, 4, 6, 5, 6, 6, 6, 7, 6, 8 };
        int[] kyouP = { 0, 0, 0, 8, 8, 0, 8, 8 };
        int[] keiP = { 0, 1, 0, 7, 8, 1, 8, 7 };
        int[] ginP = { 0, 2, 0, 6, 8, 2, 8, 6 };
        int[] kinP = { 0, 3, 0, 5, 8, 3, 8, 5 };
        int[] kakuP = { 1, 7, 7, 1 };
        int[] hisyaP = { 1, 1, 7, 7 };
        int[] ouP = { 0, 4, 8, 4 };
        public void setFirstKoma(Koma[,] field) {
            for (int i = 0; i < huP.Length; i+=2)
            {
                Image hu = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\hu.png");
                Image to = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\to.png");
                Image rehu = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionhu.png");
                Image reto = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionto.png");
                setPicImage(field, hu, to, rehu, reto,"FU", "TO", huP[i], huP[i + 1]);
            }
            for (int i = 0; i < kyouP.Length; i += 2)
            {
                Image kyou = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\kyou.png");
                Image nkyou = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\narikyou.png");
                Image rekyou = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionkyou.png");
                Image renkyou = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionnarikyou.png");
                setPicImage(field, kyou, nkyou, rekyou, renkyou, "KY", "NY", kyouP[i], kyouP[i + 1]);
            }
            for (int i = 0; i < keiP.Length; i += 2)
            {
                Image kei = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\kei.png");
                Image nkei = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\narikei.png");
                Image rekei = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionkei.png");
                Image renkei = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionnarikei.png");
                setPicImage(field, kei, nkei, rekei, renkei, "KE", "NK", keiP[i], keiP[i + 1]);
            }
            for (int i = 0; i < ginP.Length; i += 2)
            {
                Image gin = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\gin.png");
                Image ngin = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\narigin.png");
                Image regin = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversiongin.png");
                Image rengin = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionnarigin.png");
                setPicImage(field, gin, ngin, regin, rengin, "GI", "NG", ginP[i], ginP[i + 1]);
            }
            for (int i = 0; i < kinP.Length; i += 2)
            {
                Image kin = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\kin.png");
                Image rekin = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionkin.png");
                setPicImage(field, kin, null, rekin, null, "KI", "KI", kinP[i], kinP[i + 1]);
            }
            for (int i = 0; i < kakuP.Length; i += 2)
            {
                Image kaku = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\kaku.png");
                Image uma = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\uma.png");
                Image rekaku = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionkaku.png");
                Image reuma = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionuma.png");
                setPicImage(field, kaku, uma, rekaku, reuma, "KA", "UM", kakuP[i], kakuP[i + 1]);
            }
            for (int i = 0; i < hisyaP.Length; i += 2)
            {
                Image hisya = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\hisya.png");
                Image ryuu = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\ryuu.png");
                Image rehisya = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionhisya.png");
                Image reryuu = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversionryuu.png");
                setPicImage(field, hisya, ryuu, rehisya, reryuu, "HI",  "RY", hisyaP[i], hisyaP[i + 1]);
            }
            for (int i = 0; i < ouP.Length; i += 2)
            {
                Image ou = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\gyoku.png");
                Image reou = Image.FromFile(@"C:\Users\hatam\Pictures\visualstudio\koma\inversiongyoku.png");
                setPicImage(field, ou, null, reou, null, "OU", "OU", ouP[i], ouP[i + 1]);
            }


        }
        void setPicImage(Koma[,] field, Image img, Image promoteImg,
            Image inversioniImg, Image inversionPromoteImg,
            string komaName,string promoteKomaName, int y, int x)
        {
            field[y, x] = new Koma(komaName, promoteKomaName, img, promoteImg, inversioniImg, inversionPromoteImg);
            field[y, x].getNowPic().Width = 29;
            field[y, x].getNowPic().Height = 35;
            field[y, x].getNowPic().BackColor = Color.Transparent;
            field[y, x].getNowPic().SizeMode = PictureBoxSizeMode.StretchImage;
            field[y, x].getNowPic().Location = new Point(x * 41 + 225, y * 45 + 30);
            if (y < 3)
            {
                field[y, x].setImg(field[y, x].getInversionPic());
            }
        }



        public void moveKoma(Koma[,] field, int tesuu) 
        {
            int[,] valueKihu = management.numKihu;
            string moveKomaName = management.komaMoveName[tesuu];

            int nowX = valueKihu[tesuu, 0];
            int nowY = valueKihu[tesuu, 1];
            int afX = valueKihu[tesuu, 2];
            int afY = valueKihu[tesuu, 3];

            if(nowY == -1 && nowX == -1)
            {
                List<Koma> valueList = getList(tesuu);
                
                for(int i = 0; i < valueList.Count; i++)
                {
                    if(valueList[i].getNowKomaName().Equals(moveKomaName))
                    {
                        field[afY, afX] = valueList[i];
                        setPoint(valueList[i], afY, afX);
                        valueList.RemoveAt(i);
                        return;
                    }

                }
                
            }

            //もしafxafyに駒があったら持ち駒へ
            if(field[afY, afX] != null)
            {
                List<Koma> valueList = getList(tesuu);
                valueList.Add(field[afY,afX]);
                setHolding(field[afY, afX], tesuu);
                field[afY, afX] = null;
            }
            //なった駒か成ってない駒が動いたか保持
            if(management.komaBeforeMoveName[tesuu] == null)
            {
                management.komaBeforeMoveName[tesuu] = field[nowY, nowX].getNowKomaName();
            }
            
            Koma koma = field[nowY, nowX];
            field[nowY, nowX] = null;
            field[afY, afX] = koma;

            setPoint(koma, afY, afX);

            //成ったら
            checkPrmote(field[afY, afX], moveKomaName, tesuu);
            
        }



        public void returnKoma(Koma[,] field, int tesuu)
        {
            int[,] valueKihu = management.numKihu;
            string moveBeforeKomaName = management.komaBeforeMoveName[tesuu];

            int afX = valueKihu[tesuu, 0];
            int afY = valueKihu[tesuu, 1];
            int nowX = valueKihu[tesuu, 2];
            int nowY = valueKihu[tesuu, 3];

            if (afX == -1 && afY== -1)
            {
                List<Koma> valueList = getList(tesuu);
                if (tesuu % 2 == 0)
                {
                    field[nowY, nowX].getNowPic().Location = new Point(589 + 41 * (valueList.Count + 1), 400);
                }
                else
                {
                    field[nowY, nowX].getNowPic().Location = new Point(191 - 41 * valueList.Count, 41);
                }
                valueList.Add(field[nowY, nowX]);
                return;
            }
           
            checkReturnPrmote(field[nowY, nowX], moveBeforeKomaName, tesuu);
            
            Koma koma = field[nowY, nowX];
            field[nowY, nowX] = null;
            field[afY, afX] = koma;

            setPoint(koma, afY, afX);

            
            //もし駒を取っていたら
            if(management.holdingKoma[tesuu] != null)
            {
                List<Koma> valueList = getList(tesuu);
                for(int i = 0; i < valueList.Count; i++)
                {
                    if (valueList[i].getKomaName().Equals(management.holdingKomaName[tesuu]) ||
                        valueList[i].getPomoteKomaName().Equals(management.holdingKomaName[tesuu]))
                    {
                        valueList.RemoveAt(i);
                    }
                }
                field[nowY, nowX] = management.holdingKoma[tesuu];
                field[nowY, nowX].setImg(management.holdingKomaImg[tesuu]);
                field[nowY, nowX].setName(management.holdingKomaName[tesuu]);
           
                setPoint(field[nowY, nowX], nowY, nowX);
                
            }            

            
        }


        public void setPoint(Koma k, int y, int x)
        {
            k.getNowPic().Location = new Point(x * 41 + 225, y * 45 + 30);                
        }

        void checkPrmote(Koma koma, string moveKomaName, int tesuu)
        {
            if(!(koma.getNowKomaName().Equals(moveKomaName)))
            {
                koma.setName(koma.getPomoteKomaName());
                if (tesuu % 2 == 0)
                {
                    koma.setImg(koma.getPrmoteImgImg());
                }
                else
                {
                    koma.setImg(koma.getInversionPromotePic());
                }


            }
        }
        void checkReturnPrmote(Koma koma, string moveBeforeKomaName, int tesuu)
        {
            if (!(koma.getNowKomaName().Equals(moveBeforeKomaName)))
            {
                koma.setName(koma.getKomaName());
                if (tesuu % 2 == 0)
                {
                    koma.setImg(koma.getImg());
                }
                else
                {
                    koma.setImg(koma.getInversionPic());
                }

            }
        }
        void setHolding(Koma koma, int tesuu)
        {
            management.holdingKomaName[tesuu] = koma.getNowKomaName();
            management.holdingKomaImg[tesuu] = koma.getNowPic().Image;
            management.holdingKoma[tesuu] = koma;
            List<Koma> valueList = getList(tesuu);
            koma.setImg(koma.getImg());
            koma.setName(koma.getKomaName());

            if (tesuu % 2 == 0)
            {
                koma.setImg(koma.getImg());
                koma.getNowPic().Location = new Point(589 + 41 * valueList.Count, 400);
            }
            else
            {
                koma.setImg(koma.getInversionPic());
                koma.getNowPic().Location = new Point(191 - 41 * valueList.Count, 41);
            }

            
        }

        List<Koma> getList(int tesuu) 
        {
            if (tesuu % 2 == 0) 
            {
                return management.senteHold;
            }else
            {
                return management.goteHold;
            }
        }

    }
}
