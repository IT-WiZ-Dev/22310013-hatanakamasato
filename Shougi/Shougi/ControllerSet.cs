using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shougi
{
    class ControllerSet
    {
        public void setSenkei(ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Add("選択しない");
            comboBox.Items.Add("居飛車");
            comboBox.Items.Add("袖飛車");
            comboBox.Items.Add("右四間飛車");
            comboBox.Items.Add("中飛車");
            comboBox.Items.Add("四間飛車");
            comboBox.Items.Add("三間飛車");
            comboBox.Items.Add("向かい飛車");
            comboBox.Items.Add("棒銀");
        }

        public void setKakoi(ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Add("選択しない");
            comboBox.Items.Add("金矢倉");
            comboBox.Items.Add("穴熊");
            comboBox.Items.Add("美濃囲い");
        }

        public void setFS(ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Add("選択しない");
            comboBox.Items.Add("先手");
            comboBox.Items.Add("後手");
        }

        public void setOutcome(ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Add("選択しない");
            comboBox.Items.Add("勝ち");
            comboBox.Items.Add("負け");
        }

        public void setTrouble(ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Add("選択しない");
            comboBox.Items.Add("60手～69手");
            comboBox.Items.Add("70手～79手");
            comboBox.Items.Add("80手～89手");
            comboBox.Items.Add("90手～99手");
            comboBox.Items.Add("100手以上");
        }


    }
}
