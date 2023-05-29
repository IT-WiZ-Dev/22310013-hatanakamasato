using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sozaihantei
{
    class Question
    {
        string questionStg;
        string btnYesStg;
        string btnNoStg;
        Image picYesImg;
        Image picNoImg;
        Shoukai shoukai;

        public Question(string _questionStg, string _btnYesStg, string _btnNoStg,
           Image _picYesImg, Image _picNoImg, Shoukai _shoukai)
        {
            questionStg = _questionStg;
            btnYesStg = _btnYesStg;
            btnNoStg = _btnNoStg;
            picYesImg = _picYesImg;
            picNoImg = _picNoImg;
            shoukai = _shoukai;
        }

        public string getQuestionStg()
        {
            return questionStg;
        }
        public string getBtnYesStg()
        {
            return btnYesStg;
        }

        public string getBtnNoStg()
        {
            return btnNoStg;
        }

        public Image getPicYesImg()
        {
            return picYesImg;
        }

        public Image getPicNoImg()
        {
            return picNoImg;
        }
        public Shoukai getShoukai()
        {
            return shoukai;
        }


    }

}
