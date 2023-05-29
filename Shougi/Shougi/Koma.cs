using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shougi
{
    public class Koma
    {
        string nowKomaName;
        string komaName;
        string promoteKomaName;

        PictureBox nowPic;
        Image img;
        Image prmoteImg;
        Image inversionImg;
        Image inversionPromoteImg;



        public Koma(string komaName, string promoteKomaName,
            Image img, Image prmoteImg, Image inversionImg, Image inversionPromoteImg)
        {
            nowPic = new PictureBox();
            this.komaName = komaName;
            this.promoteKomaName = promoteKomaName;

            nowKomaName = komaName;

            this.img = img;
            this.prmoteImg = prmoteImg;
            this.inversionImg = inversionImg;
            this.inversionPromoteImg = inversionPromoteImg;

            nowPic.Image = img;
        
        }

        public PictureBox getNowPic()
        {
            return nowPic;
        }
        public string getNowKomaName()
        {
            return nowKomaName;
        }
        public string getKomaName()
        {
            return komaName;
        }
        public string getPomoteKomaName()
        {
            return promoteKomaName;
        }

        public Image getImg()
        {
            return img;
        }
        public Image getPrmoteImgImg()
        {
            return prmoteImg;
        }
        public Image getInversionPic()
        {
            return inversionImg;
        }
        public Image getInversionPromotePic()
        {
            return inversionPromoteImg;
        }



        public void setImg(Image img)
        {
            nowPic.Image = img;
        }
        public void setName(string stg)
        {
            nowKomaName = stg;
        }


    }
}
