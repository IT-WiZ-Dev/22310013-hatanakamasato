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
    public partial class Kensaku : Form
    {
        public Kensaku()
        {
            InitializeComponent();
        }


        private void buttonSagasu_Click(object sender, EventArgs e)
        {
            StreamReader fileReader = new StreamReader(@"C:\Users\hatam\source\repos\Shougi\gamerecordSearch.txt");
            string textNR = fileReader.ReadToEnd();
            string text = textNR.Replace("\r", "");
            string[] dbTextArr = text.Split(new string[] { "\n" }, StringSplitOptions.None);
            string[] searchTextArr = {(string)comboBoxSenkei.SelectedItem, (string)comboBoxSenkeiEnemy.SelectedItem,
                                      (string)comboBoxKakoi.SelectedItem, (string)comboBoxKakoiEnemy.SelectedItem,
                                      (string)comboBoxFS.SelectedItem, (string)comboBoxOutcome.SelectedItem,
                                      (string)comboTrouble.SelectedItem};
            List<int> agreement = new List<int>();
            for (int i = 1; i < dbTextArr.Length - 1; i += 8)
            {
                if(isSearch(dbTextArr, i, searchTextArr))
                {
                    agreement.Add(i);
                }
            }
            fileReader.Close();
            Hitkihu hk = new Hitkihu(dbTextArr, agreement);
            hk.Show();
        }

        bool isSearch(string[] dbTextArr, int idx, string[] searchTextArr)
        {
            for(int i = 0; i < searchTextArr.Length; i++)
            {
                string searchText = searchTextArr[i];
                if (searchText.Equals("選択しない"))
                {
                    continue;
                }
                if(!dbTextArr[idx + i].Equals(searchText))
                {
                    return false;
                }   
            }
            return true;
        }



        //手数に数字しか入れられなくする
        private void comboTrouble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //時期に数字しか入れられなくする
        private void comboSason_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Kensaku_Load(object sender, EventArgs e)
        {
            ControllerSet controllerset = new ControllerSet();

            controllerset.setSenkei(comboBoxSenkei);
            controllerset.setKakoi(comboBoxKakoi);
            controllerset.setFS(comboBoxFS);
            controllerset.setOutcome(comboBoxOutcome);
            controllerset.setTrouble(comboTrouble);

            //相手
            controllerset.setSenkei(comboBoxSenkeiEnemy);
            controllerset.setKakoi(comboBoxKakoiEnemy);
            controllerset.setFS(comboBoxFSEnemy);
            controllerset.setOutcome(comboBoxOutcomeEnemy);

            comboBoxSenkei.SelectedIndex = 0;
            comboBoxKakoi.SelectedIndex = 0;
            comboBoxFS.SelectedIndex = 0;
            comboBoxOutcome.SelectedIndex = 0;
            comboTrouble.SelectedIndex = 0;

            comboBoxSenkeiEnemy.SelectedIndex = 0;
            comboBoxKakoiEnemy.SelectedIndex = 0;
            comboBoxFSEnemy.SelectedIndex = 0;
            comboBoxOutcomeEnemy.SelectedIndex = 0;
            





        }




        //もし自分が先手を選んだら相手を後手に変える
        private void comboBoxFS_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxFS.SelectedIndex)
            {
                case 0:
                    comboBoxFSEnemy.SelectedIndex = 0;
                    break;
                case 1:
                    comboBoxFSEnemy.SelectedIndex = 2;
                    break;
                case 2:
                    comboBoxFSEnemy.SelectedIndex = 1;
                    break;
            }
        }
        private void comboBoxFSEnemy_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxFSEnemy.SelectedIndex)
            {
                case 0:
                    comboBoxFS.SelectedIndex = 0;
                    break;
                case 1:
                    comboBoxFS.SelectedIndex = 2;
                    break;
                case 2:
                    comboBoxFS.SelectedIndex = 1;
                    break;
            }
        }
        //もし自分が勝ちを選んだら相手を負けに変える
        private void comboBoxOutcome_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxOutcome.SelectedIndex)
            {
                case 0:
                    comboBoxOutcomeEnemy.SelectedIndex = 0;
                    break;
                case 1:
                    comboBoxOutcomeEnemy.SelectedIndex = 2;
                    break;
                case 2:
                    comboBoxOutcomeEnemy.SelectedIndex = 1;
                    break;
            }
        }

        private void comboBoxOutcomeEnemy_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxOutcomeEnemy.SelectedIndex)
            {
                case 0:
                    comboBoxOutcome.SelectedIndex = 0;
                    break;
                case 1:
                    comboBoxOutcome.SelectedIndex = 2;
                    break;
                case 2:
                    comboBoxOutcome.SelectedIndex = 1;
                    break;
            }
        }



    }
}
