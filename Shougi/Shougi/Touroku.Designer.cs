
namespace Shougi
{
    partial class Touroku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxKihu = new System.Windows.Forms.TextBox();
            this.buttonTouroku = new System.Windows.Forms.Button();
            this.labelEnemy = new System.Windows.Forms.Label();
            this.labelMy = new System.Windows.Forms.Label();
            this.comboBoxKakoiEnemy = new System.Windows.Forms.ComboBox();
            this.labelKakoiEnemy = new System.Windows.Forms.Label();
            this.comboBoxSenkeiEnemy = new System.Windows.Forms.ComboBox();
            this.labelSenkeiEnemy = new System.Windows.Forms.Label();
            this.comboBoxFS = new System.Windows.Forms.ComboBox();
            this.comboBoxKakoi = new System.Windows.Forms.ComboBox();
            this.labelKakoi = new System.Windows.Forms.Label();
            this.comboBoxSenkei = new System.Windows.Forms.ComboBox();
            this.labelSenkei = new System.Windows.Forms.Label();
            this.labelFarstSecond = new System.Windows.Forms.Label();
            this.comboBoxOutcome = new System.Windows.Forms.ComboBox();
            this.labelOutcome = new System.Windows.Forms.Label();
            this.labelKihu = new System.Windows.Forms.Label();
            this.labelDaimei = new System.Windows.Forms.Label();
            this.textBoxDaimei = new System.Windows.Forms.TextBox();
            this.labelTrouble = new System.Windows.Forms.Label();
            this.comboBoxTrouble = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxKihu
            // 
            this.textBoxKihu.Location = new System.Drawing.Point(95, 604);
            this.textBoxKihu.Multiline = true;
            this.textBoxKihu.Name = "textBoxKihu";
            this.textBoxKihu.Size = new System.Drawing.Size(274, 25);
            this.textBoxKihu.TabIndex = 0;
            // 
            // buttonTouroku
            // 
            this.buttonTouroku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonTouroku.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonTouroku.ForeColor = System.Drawing.Color.White;
            this.buttonTouroku.Location = new System.Drawing.Point(280, 677);
            this.buttonTouroku.Name = "buttonTouroku";
            this.buttonTouroku.Size = new System.Drawing.Size(224, 84);
            this.buttonTouroku.TabIndex = 1;
            this.buttonTouroku.Text = "棋譜登録";
            this.buttonTouroku.UseVisualStyleBackColor = false;
            this.buttonTouroku.Click += new System.EventHandler(this.buttonTouroku_Click);
            // 
            // labelEnemy
            // 
            this.labelEnemy.AutoSize = true;
            this.labelEnemy.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelEnemy.ForeColor = System.Drawing.Color.White;
            this.labelEnemy.Location = new System.Drawing.Point(517, 37);
            this.labelEnemy.Name = "labelEnemy";
            this.labelEnemy.Size = new System.Drawing.Size(97, 40);
            this.labelEnemy.TabIndex = 45;
            this.labelEnemy.Text = "相手";
            // 
            // labelMy
            // 
            this.labelMy.AutoSize = true;
            this.labelMy.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMy.ForeColor = System.Drawing.Color.White;
            this.labelMy.Location = new System.Drawing.Point(172, 37);
            this.labelMy.Name = "labelMy";
            this.labelMy.Size = new System.Drawing.Size(97, 40);
            this.labelMy.TabIndex = 44;
            this.labelMy.Text = "自分";
            // 
            // comboBoxKakoiEnemy
            // 
            this.comboBoxKakoiEnemy.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxKakoiEnemy.FormattingEnabled = true;
            this.comboBoxKakoiEnemy.Location = new System.Drawing.Point(441, 232);
            this.comboBoxKakoiEnemy.Name = "comboBoxKakoiEnemy";
            this.comboBoxKakoiEnemy.Size = new System.Drawing.Size(274, 28);
            this.comboBoxKakoiEnemy.TabIndex = 43;
            // 
            // labelKakoiEnemy
            // 
            this.labelKakoiEnemy.AutoSize = true;
            this.labelKakoiEnemy.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelKakoiEnemy.ForeColor = System.Drawing.Color.White;
            this.labelKakoiEnemy.Location = new System.Drawing.Point(435, 193);
            this.labelKakoiEnemy.Name = "labelKakoiEnemy";
            this.labelKakoiEnemy.Size = new System.Drawing.Size(87, 36);
            this.labelKakoiEnemy.TabIndex = 42;
            this.labelKakoiEnemy.Text = "囲い";
            // 
            // comboBoxSenkeiEnemy
            // 
            this.comboBoxSenkeiEnemy.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxSenkeiEnemy.FormattingEnabled = true;
            this.comboBoxSenkeiEnemy.Location = new System.Drawing.Point(441, 142);
            this.comboBoxSenkeiEnemy.Name = "comboBoxSenkeiEnemy";
            this.comboBoxSenkeiEnemy.Size = new System.Drawing.Size(274, 28);
            this.comboBoxSenkeiEnemy.TabIndex = 41;
            // 
            // labelSenkeiEnemy
            // 
            this.labelSenkeiEnemy.AutoSize = true;
            this.labelSenkeiEnemy.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSenkeiEnemy.ForeColor = System.Drawing.Color.White;
            this.labelSenkeiEnemy.Location = new System.Drawing.Point(435, 103);
            this.labelSenkeiEnemy.Name = "labelSenkeiEnemy";
            this.labelSenkeiEnemy.Size = new System.Drawing.Size(87, 36);
            this.labelSenkeiEnemy.TabIndex = 40;
            this.labelSenkeiEnemy.Text = "戦型";
            // 
            // comboBoxFS
            // 
            this.comboBoxFS.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxFS.FormattingEnabled = true;
            this.comboBoxFS.Location = new System.Drawing.Point(95, 322);
            this.comboBoxFS.Name = "comboBoxFS";
            this.comboBoxFS.Size = new System.Drawing.Size(274, 28);
            this.comboBoxFS.TabIndex = 36;
            // 
            // comboBoxKakoi
            // 
            this.comboBoxKakoi.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxKakoi.FormattingEnabled = true;
            this.comboBoxKakoi.Location = new System.Drawing.Point(95, 232);
            this.comboBoxKakoi.Name = "comboBoxKakoi";
            this.comboBoxKakoi.Size = new System.Drawing.Size(274, 28);
            this.comboBoxKakoi.TabIndex = 34;
            // 
            // labelKakoi
            // 
            this.labelKakoi.AutoSize = true;
            this.labelKakoi.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelKakoi.ForeColor = System.Drawing.Color.White;
            this.labelKakoi.Location = new System.Drawing.Point(89, 193);
            this.labelKakoi.Name = "labelKakoi";
            this.labelKakoi.Size = new System.Drawing.Size(87, 36);
            this.labelKakoi.TabIndex = 33;
            this.labelKakoi.Text = "囲い";
            // 
            // comboBoxSenkei
            // 
            this.comboBoxSenkei.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxSenkei.FormattingEnabled = true;
            this.comboBoxSenkei.Location = new System.Drawing.Point(95, 142);
            this.comboBoxSenkei.Name = "comboBoxSenkei";
            this.comboBoxSenkei.Size = new System.Drawing.Size(274, 28);
            this.comboBoxSenkei.TabIndex = 32;
            // 
            // labelSenkei
            // 
            this.labelSenkei.AutoSize = true;
            this.labelSenkei.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSenkei.ForeColor = System.Drawing.Color.White;
            this.labelSenkei.Location = new System.Drawing.Point(89, 103);
            this.labelSenkei.Name = "labelSenkei";
            this.labelSenkei.Size = new System.Drawing.Size(87, 36);
            this.labelSenkei.TabIndex = 31;
            this.labelSenkei.Text = "戦型";
            // 
            // labelFarstSecond
            // 
            this.labelFarstSecond.AutoSize = true;
            this.labelFarstSecond.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelFarstSecond.ForeColor = System.Drawing.Color.White;
            this.labelFarstSecond.Location = new System.Drawing.Point(89, 283);
            this.labelFarstSecond.Name = "labelFarstSecond";
            this.labelFarstSecond.Size = new System.Drawing.Size(195, 36);
            this.labelFarstSecond.TabIndex = 35;
            this.labelFarstSecond.Text = "先手or後手";
            // 
            // comboBoxOutcome
            // 
            this.comboBoxOutcome.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxOutcome.FormattingEnabled = true;
            this.comboBoxOutcome.Location = new System.Drawing.Point(95, 412);
            this.comboBoxOutcome.Name = "comboBoxOutcome";
            this.comboBoxOutcome.Size = new System.Drawing.Size(274, 28);
            this.comboBoxOutcome.TabIndex = 37;
            // 
            // labelOutcome
            // 
            this.labelOutcome.AutoSize = true;
            this.labelOutcome.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelOutcome.ForeColor = System.Drawing.Color.White;
            this.labelOutcome.Location = new System.Drawing.Point(89, 373);
            this.labelOutcome.Name = "labelOutcome";
            this.labelOutcome.Size = new System.Drawing.Size(87, 36);
            this.labelOutcome.TabIndex = 38;
            this.labelOutcome.Text = "勝敗";
            // 
            // labelKihu
            // 
            this.labelKihu.AutoSize = true;
            this.labelKihu.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelKihu.ForeColor = System.Drawing.Color.White;
            this.labelKihu.Location = new System.Drawing.Point(89, 565);
            this.labelKihu.Name = "labelKihu";
            this.labelKihu.Size = new System.Drawing.Size(87, 36);
            this.labelKihu.TabIndex = 46;
            this.labelKihu.Text = "棋譜";
            // 
            // labelDaimei
            // 
            this.labelDaimei.AutoSize = true;
            this.labelDaimei.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDaimei.ForeColor = System.Drawing.Color.White;
            this.labelDaimei.Location = new System.Drawing.Point(435, 565);
            this.labelDaimei.Name = "labelDaimei";
            this.labelDaimei.Size = new System.Drawing.Size(87, 36);
            this.labelDaimei.TabIndex = 48;
            this.labelDaimei.Text = "題名";
            // 
            // textBoxDaimei
            // 
            this.textBoxDaimei.Location = new System.Drawing.Point(441, 604);
            this.textBoxDaimei.Multiline = true;
            this.textBoxDaimei.Name = "textBoxDaimei";
            this.textBoxDaimei.Size = new System.Drawing.Size(274, 25);
            this.textBoxDaimei.TabIndex = 47;
            this.textBoxDaimei.Text = "題名";
            // 
            // labelTrouble
            // 
            this.labelTrouble.AutoSize = true;
            this.labelTrouble.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTrouble.ForeColor = System.Drawing.Color.White;
            this.labelTrouble.Location = new System.Drawing.Point(89, 464);
            this.labelTrouble.Name = "labelTrouble";
            this.labelTrouble.Size = new System.Drawing.Size(87, 36);
            this.labelTrouble.TabIndex = 50;
            this.labelTrouble.Text = "手数";
            // 
            // comboBoxTrouble
            // 
            this.comboBoxTrouble.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTrouble.FormattingEnabled = true;
            this.comboBoxTrouble.Location = new System.Drawing.Point(95, 503);
            this.comboBoxTrouble.Name = "comboBoxTrouble";
            this.comboBoxTrouble.Size = new System.Drawing.Size(274, 28);
            this.comboBoxTrouble.TabIndex = 49;
            // 
            // Touroku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 797);
            this.Controls.Add(this.labelTrouble);
            this.Controls.Add(this.comboBoxTrouble);
            this.Controls.Add(this.labelDaimei);
            this.Controls.Add(this.textBoxDaimei);
            this.Controls.Add(this.labelKihu);
            this.Controls.Add(this.labelEnemy);
            this.Controls.Add(this.labelMy);
            this.Controls.Add(this.comboBoxKakoiEnemy);
            this.Controls.Add(this.labelKakoiEnemy);
            this.Controls.Add(this.comboBoxSenkeiEnemy);
            this.Controls.Add(this.labelSenkeiEnemy);
            this.Controls.Add(this.labelOutcome);
            this.Controls.Add(this.comboBoxOutcome);
            this.Controls.Add(this.comboBoxFS);
            this.Controls.Add(this.labelFarstSecond);
            this.Controls.Add(this.comboBoxKakoi);
            this.Controls.Add(this.labelKakoi);
            this.Controls.Add(this.comboBoxSenkei);
            this.Controls.Add(this.labelSenkei);
            this.Controls.Add(this.buttonTouroku);
            this.Controls.Add(this.textBoxKihu);
            this.Name = "Touroku";
            this.Text = "登録";
            this.Load += new System.EventHandler(this.Touroku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKihu;
        private System.Windows.Forms.Button buttonTouroku;
        private System.Windows.Forms.Label labelEnemy;
        private System.Windows.Forms.Label labelMy;
        private System.Windows.Forms.ComboBox comboBoxKakoiEnemy;
        private System.Windows.Forms.Label labelKakoiEnemy;
        private System.Windows.Forms.ComboBox comboBoxSenkeiEnemy;
        private System.Windows.Forms.Label labelSenkeiEnemy;
        private System.Windows.Forms.ComboBox comboBoxFS;
        private System.Windows.Forms.ComboBox comboBoxKakoi;
        private System.Windows.Forms.Label labelKakoi;
        private System.Windows.Forms.ComboBox comboBoxSenkei;
        private System.Windows.Forms.Label labelSenkei;
        private System.Windows.Forms.Label labelFarstSecond;
        private System.Windows.Forms.ComboBox comboBoxOutcome;
        private System.Windows.Forms.Label labelOutcome;
        private System.Windows.Forms.Label labelKihu;
        private System.Windows.Forms.Label labelDaimei;
        private System.Windows.Forms.TextBox textBoxDaimei;
        private System.Windows.Forms.Label labelTrouble;
        private System.Windows.Forms.ComboBox comboBoxTrouble;
    }
}