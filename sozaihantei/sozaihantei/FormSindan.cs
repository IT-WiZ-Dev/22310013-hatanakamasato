using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sozaihantei
{
    public partial class FormSindan : Form
    {
        int quesNum = 2;
        Question[] quesArr = new Question[500];
        
        public FormSindan()
        {
            InitializeComponent();
        }

        

        private void FormSindan_Load(object sender, EventArgs e)
        {
            this.Height = 600;
            this.Width = 950;

            Question riyoseru = new Question(null, null, null, null, null, new Shoukai("リヨセル",
                "ユーカリなどの木材のパルプで作られて\n" +
                "環境に良いとしても知られています\n"+
                "\n特徴\n"+
                "・吸湿性・速乾性に優れている\n" +
                "・静電気が起きにくい\n" +
                "・光沢感がある\n" +
                "・洗濯でも縮みにくい",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\riyoseru.jpg")));

            Question reeyon = new Question(null, null, null, null, null, new Shoukai("レーヨン",
                "特殊な溶剤を使用し、ユーカリの木材を溶かし\n" +
                "作られている\n"+
                "\n特徴\n"+
                "・シルクのような光沢がある\n" +
                "・肌触りもやわらかい\n"+
                "・吸湿性と速乾性に優れている\n"+
                "・吸湿性が高いことから、静電気が起きにくい",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\reeyon.jpg")));

            Question rinen = new Question(null, null, null, null, null, new Shoukai("リネン",
                "リネンはあま科の植物から作られていて\n" +
                "天然繊維の中でもっとも強靭な素材\n" +
                "だといわれている\n"+
                "\n特徴\n" +
                "・通気性に優れている\n" +
                "・コットンに比べると約4倍の吸収性がある\n" +
                "・汚れがついても落ちやすい",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\rinen.jpg")));

            Question kotton = new Question(null, null, null, null, null, new Shoukai("コットン",
                "ワタの種子から取れる繊維で\n"+
                "作られている\n" +
                "\n特徴\n" +
                "・吸水性・通気性に優れている\n" +
                "・耐熱性に優れている\n"+
                "・柔らかな肌触り\n"+
                "・染色しやすい",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\kotton.jpg")));

            Question akuriru = new Question(null, null, null, null, null, new Shoukai("アクリル",
                "石油から取れるアクリロニトリルが\n" +
                "原料の合成繊維\n" +
                "\n特徴\n" +
                "・柔らかくてボリュームがあり\n" +
                "・保温性に優れている\n" +
                "・ウールの代用品として使われることが多い\n" +
                "・ウールには出せないツヤ感や光沢感もある",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\akuriru2.jpg"))) ;

            Question porinoji = new Question(null, null, null, null, null, new Shoukai("ポリノジック",
                "木材パルプを使用して作られた再生繊維\n" +
                "\n特徴\n" +
                "・親水性なので油汚れがすぐに落ちる\n" +
                "・シルクのような光沢があり優雅\n"+
                "・生地が柔らかい\n" +
                "・色落ちしにくい",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\porino.jpg")));

            Question poriuretan = new Question(null, null, null, null, null, new Shoukai("ポリウレタン",
                "天然ゴムの代替品として開発された\n"+
                "合成ゴムの一種類\n"+
                "\n特徴\n" +
                "・伸縮性に優れる\n" +
                "・シワになりにくい\n"+
                "・軽くて衝撃につよくちぎれにくい\n"+
                "・乾きやすい",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\poriuretan.jpg")));

            Question aseteto = new Question(null, null, null, null, null, new Shoukai("アセテート",
                "アセチルセルロースから作られる繊維\n"+
                "\n特徴\n" +
                "・シルクに似た美しい光沢がある\n" +
                "・撥水性があり汚れに強い\n"+
                "・染色性がよくキレイに染まる\n"+
                "・弾力性によってシワができにくい",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\aseteto.jpg")));

            Question toriaseteto = new Question(null, null, null, null, null, new Shoukai("トリアセテート",
                "アセチルセルロースより作られる繊維\n" +
                "\n特徴\n" +
                "・さらりとした風合い\n" +
                "・耐熱性が高い\n"+
                "・弾力性がある\n"+
                "・シワになりにくい\n"+
                "・撥水性が高い",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\toriaseteto.jpg")));

            Question uuru = new Question(null, null, null, null, null, new Shoukai("ウール",
                "ウールとは、主にメリノ種の羊から取れる毛\n" +
                "\n特徴\n" +
                "・暖かくて保温性がある\n"+
                "・吸湿性に優れている\n"+
                "・伸縮性がある\n"+
                "・シワになりにくい\n"+
                "・汚れがつきにくい",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\uuru.jpg")));

            Question siruku = new Question(null, null, null, null, null, new Shoukai("シルク",
                "シルクは蚕の繭から作られる\n" +
                "タンパク質の天然繊維です\n" +
                "\n特徴\n" +
                "・上品な光沢となめらかな肌触り\n"+
                "・素肌に優しい\n"+
                "・吸湿性・放湿性に優れる\n"+
                "・静電気を起こしにくい\n"+
                "・紫外線から肌を守る\n",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\siruku.jpg")));

            Question mohea = new Question(null, null, null, null, null, new Shoukai("モヘア",
                "モヘアとは、アンゴラヤギから取れる毛\n" +
                "\n特徴\n" +
                "絹のようなつややかな光沢\n" +
                "柔らかな手触り\n" +
                "吸湿性に優れている\n" +
                "丈夫で耐久性があり、弾力性もある\n" +
                "シワになりにくい軽量\n" +
                "優れた保温性と断熱性を有している\n",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\mohea.jpg")));


            Question angora = new Question(null, null, null, null, null, new Shoukai("アンゴラ",
                "アンゴラとは、アンゴラウサギから取れる毛\n" +
                "\n特徴\n" +
                "・保温性・保湿性が高い\n" +
                "・高級感がある\n"+
                "・肌触りが良い\n" +
                "・綺麗なパステルカラーに染めやすい\n" +
                "・絹やモヘヤを上回る美しいツヤ\n" +
                "・ふんわりと軽い\n",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\angora.jpg")));

            Question arupaka = new Question(null, null, null, null, null, new Shoukai("アルパカ",
                "アルパカから作られた繊維でアンデスの宝石\n" +
                "とも呼ばれている\n"+
                "\n特徴\n" +
                "・毛玉が出にくいのでお手入れがラク\n" +
                "・カシミヤをしのぐと言われる高い保温性\n" +
                "・滑らかでやわらかい感触\n" +
                "・丈夫なので何十年も着られる\n"+
                "・軽くて着ていても疲れにくい",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\arupaka.jpg")));

            Question kyameru = new Question(null, null, null, null, null, new Shoukai("キャメル",
                "キャメルとは、ラクダから取れる毛のことをいい\n" +
                "主にフタコブラクダの毛が使われている\n"+
                "\n特徴\n" +
                "・吸湿性に優れる\n" +
                "・放湿力が高い\n" +
                "・柔らかく軽い暖かく保温性に優れる\n" +
                "・汚れにくくへたりにくい",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\kyameru.jpg")));

            Question kasimiya = new Question(null, null, null, null, null, new Shoukai("カシミヤ",
                "カシミヤとは、カシミヤヤギから取れる毛で\n" +
                "繊維の宝石とも呼ばれてる\n"+
                "\n特徴\n" +
                "・上品な光沢感\n" +
                "・ツヤが美しい\n"+
                "・薄手でやわらかい\n"+
                "・保温性・保湿性に優れている",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\kasimiya.jpg")));




            //質問作成
            Question tuukisei = new Question("通気性が高い方が好みですか？", "はい", "いいえ",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\tuuki.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\nottuuki.jpg"), null);            
            Question sinsyuku = new Question("伸縮性があった方がいいですか？", "はい", "いいえ",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\sin.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\notsin.jpg"), null);
            Question hadazawari = new Question("肌触りの好みはどちらですか？", "柔らかい", "固い",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\hada.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\nothada.jpg"), null);


            Question nagai = new Question("服は長く使いたいですか？", "はい", "いいえ",
               Image.FromFile(@"C:\Users\hatam\Pictures\visual\nagai.jpg"),
               Image.FromFile(@"C:\Users\hatam\Pictures\visual\notnagai.jpg"), null);
            Question natuscie = new Question("天然繊維か化学繊維どちらが好みか？", "天然繊維", "化学繊維",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\doubutu.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\kagaku.jpg"), null);
            Question natuhuyu = new Question("夏と冬どちらで着たいですか？", "夏", "冬",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\natu.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\huyu.jpg"), null);
            Question mizuarai = new Question("水洗いしやすい方がいいですか？", "はい", "いいえ",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\mizu.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\notmizu.jpg"), null);
            Question vegan = new Question("あなたはヴィ―ガンですか？", "はい", "いいえ",
               Image.FromFile(@"C:\Users\hatam\Pictures\visual\vegan.jpg"),
               Image.FromFile(@"C:\Users\hatam\Pictures\visual\notvegan.jpg"), null);
            Question kankyou = new Question("環境に優しい服を着たいですか？", "はい", "そうでもない",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\kan.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\kankyou.jpg"), null);
            Question kagashoku = new Question("化学繊維か植物繊維どちらが好みか？", "化学繊維", "植物繊維",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\kagaku.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\shokubutu.jpg"), null);
            Question natuakiharu = new Question("夏と秋、春どちらで着たいですか？", "夏", "秋か春",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\natu.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\aki.jpg"), null);
            Question koutaku = new Question("光沢があった方がいいですか？", "はい", "いいえ",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\koutaku.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\notkoutaku.jpg"), null);
            Question hoonsei = new Question("保温性があった方がいいですか？", "はい", "普通",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\hoon.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\nothoon.jpg"), null);
            Question kyuusui = new Question("吸水性は高い方がいいですか？", "高い", "普通",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\kyuusui.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\notkyuusui.jpg"), null);
            Question hudangi = new Question("どちらのシーンで着たいですか？", "普段着", "特別な日",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\hudangi.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\tokubetu.jpg"), null);
            Question zooshoku = new Question("動物繊維と植物繊維どちらが好みか？", "動物繊維", "植物繊維",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\doubutu.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\shokubutu.jpg"), null);
            Question hadanameraka = new Question("肌触りはどちらが好みか？", "なめらか", "毛足が長い",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\hadayawa.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\keasi.jpg"), null);
            Question arupakarakuda = new Question("どちらの毛が好みですか？", "左", "右",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\aru.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\rakuda.jpg"), null);
            Question hadahunwariyawaraka = new Question("肌触りはどちらが好みか？", "ふんわり", "柔らかい",
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\hunwari.jpg"),
                Image.FromFile(@"C:\Users\hatam\Pictures\visual\yawarakai.jpg"), null);



            //質問をセット
            quesArr[2] = vegan;
            quesArr[4] = kankyou;
            quesArr[5] = natuscie; 
            quesArr[8] = kagashoku;
            quesArr[9] = hoonsei;
            quesArr[10] = hudangi;
            quesArr[11] = hoonsei;
            quesArr[16] = mizuarai;
            quesArr[17] = natuakiharu;
            quesArr[18] = koutaku;
            quesArr[19] = kyuusui;
            quesArr[20] = zooshoku;
            quesArr[21] = hadanameraka;
            quesArr[22] = koutaku;
            quesArr[23] = kankyou;
            quesArr[32] = riyoseru;
            quesArr[33] = reeyon;
            quesArr[34] = rinen;
            quesArr[35] = kotton;
            quesArr[36] = mizuarai;
            quesArr[37] = nagai;
            quesArr[38] = aseteto;
            quesArr[39] = toriaseteto;
            quesArr[40] = uuru;  
            quesArr[41] = natuakiharu;
            quesArr[42] = natuhuyu;
            quesArr[43] = hoonsei;
            quesArr[44] = mizuarai;
            quesArr[45] = nagai;
            quesArr[46] = mizuarai;
            quesArr[47] = kyuusui;
            quesArr[72] = akuriru;
            quesArr[73] = porinoji;
            quesArr[74] = mizuarai;
            quesArr[75] = poriuretan;
            quesArr[82] = rinen;
            quesArr[83] = kotton;
            quesArr[84] = siruku;
            quesArr[85] = koutaku;
            quesArr[86] = arupakarakuda;
            quesArr[87] = kasimiya;
            quesArr[88] = hadahunwariyawaraka;
            quesArr[89] = porinoji;
            quesArr[90] = mizuarai;
            quesArr[91] = poriuretan;
            quesArr[92] = riyoseru;
            quesArr[93] = reeyon;
            quesArr[94] = aseteto;
            quesArr[95] = toriaseteto;
            quesArr[148] = akuriru;
            quesArr[149] = porinoji;
            quesArr[170] = mohea;
            quesArr[171] = angora;
            quesArr[172] = arupaka;
            quesArr[173] = kyameru;
            quesArr[176] = akuriru;
            quesArr[177] = riyoseru;
            quesArr[180] = hadahunwariyawaraka;
            quesArr[181] = porinoji;
            quesArr[360] = akuriru;
            quesArr[361] = riyoseru;

            //一番目の質問を反映
            reflection(quesArr[quesNum]);
        }
        void reflection(Question ques)
        {
            labelQuestion.Text = ques.getQuestionStg();
            buttonYes.Text = ques.getBtnYesStg();
            buttonNo.Text = ques.getBtnNoStg();
            pictureBoxYes.Image = ques.getPicYesImg();
            pictureBoxNo.Image = ques.getPicNoImg();

            pictureBoxYes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxNo.SizeMode = PictureBoxSizeMode.Zoom;

        }
        private void buttonYes_Click(object sender, EventArgs e)
        {
            quesNum = quesNum * 2;
            checkShow(quesArr[quesNum]);
            
            
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            quesNum = quesNum * 2 + 1;
            checkShow(quesArr[quesNum]);
        }

        private void checkShow(Question q)
        {
            if (q.getShoukai() == null)
            {
                reflection(q);
            }
            else
            {
                FormAns formAns = new FormAns(q.getShoukai());
                formAns.Show();
            }
        }

    }
}
