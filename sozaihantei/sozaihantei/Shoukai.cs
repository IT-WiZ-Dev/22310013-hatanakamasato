using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sozaihantei
{
    public class Shoukai
    {
        string osusumeName;
        string shoukaiStg;
        Image img;
        public Shoukai(string _osusuemName, string _shoukaiStg, Image _img)
        {
            shoukaiStg = _shoukaiStg;
            osusumeName = _osusuemName;
            img = _img;
        }
        public string getOsusumeName()
        {
            return osusumeName;
        }
        public string getShoukaiStg()
        {
            return shoukaiStg;
        }
        public Image getImg()
        {
            return img;
        }
    }
}
