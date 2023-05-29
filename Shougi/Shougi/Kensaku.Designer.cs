
namespace Shougi
{
    partial class Kensaku
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
            this.labelSearchName = new System.Windows.Forms.Label();
            this.labelSenkei = new System.Windows.Forms.Label();
            this.comboBoxSenkei = new System.Windows.Forms.ComboBox();
            this.labelKakoi = new System.Windows.Forms.Label();
            this.comboBoxKakoi = new System.Windows.Forms.ComboBox();
            this.labelFarstSecond = new System.Windows.Forms.Label();
            this.comboBoxFS = new System.Windows.Forms.ComboBox();
            this.comboBoxOutcome = new System.Windows.Forms.ComboBox();
            this.labelOutcome = new System.Windows.Forms.Label();
            this.buttonSagasu = new System.Windows.Forms.Button();
            this.comboBoxKakoiEnemy = new System.Windows.Forms.ComboBox();
            this.labelKakoiEnemy = new System.Windows.Forms.Label();
            this.comboBoxSenkeiEnemy = new System.Windows.Forms.ComboBox();
            this.labelSenkeiEnemy = new System.Windows.Forms.Label();
            this.labelMy = new System.Windows.Forms.Label();
            this.labelEnemy = new System.Windows.Forms.Label();
            this.labelTrouble = new System.Windows.Forms.Label();
            this.comboTrouble = new System.Windows.Forms.ComboBox();
            this.comboBoxFSEnemy = new System.Windows.Forms.ComboBox();
            this.labelFarstSecondEnemy = new System.Windows.Forms.Label();
            this.labelOutcomeEnemy = new System.Windows.Forms.Label();
            this.comboBoxOutcomeEnemy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.labelSearchName.Location = new System.Drawing.Point(162, 51);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(320, 52);
            this.labelSearchName.TabIndex = 0;
            this.labelSearchName.Text = "🔍　棋譜検索";
            // 
            // labelSenkei
            // 
            this.labelSenkei.AutoSize = true;
            this.labelSenkei.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSenkei.ForeColor = System.Drawing.Color.White;
            this.labelSenkei.Location = new System.Drawing.Point(44, 220);
            this.labelSenkei.Name = "labelSenkei";
            this.labelSenkei.Size = new System.Drawing.Size(87, 36);
            this.labelSenkei.TabIndex = 1;
            this.labelSenkei.Text = "戦型";
            // 
            // comboBoxSenkei
            // 
            this.comboBoxSenkei.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxSenkei.FormattingEnabled = true;
            this.comboBoxSenkei.Location = new System.Drawing.Point(50, 259);
            this.comboBoxSenkei.Name = "comboBoxSenkei";
            this.comboBoxSenkei.Size = new System.Drawing.Size(274, 28);
            this.comboBoxSenkei.TabIndex = 5;
            // 
            // labelKakoi
            // 
            this.labelKakoi.AutoSize = true;
            this.labelKakoi.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelKakoi.ForeColor = System.Drawing.Color.White;
            this.labelKakoi.Location = new System.Drawing.Point(44, 310);
            this.labelKakoi.Name = "labelKakoi";
            this.labelKakoi.Size = new System.Drawing.Size(87, 36);
            this.labelKakoi.TabIndex = 6;
            this.labelKakoi.Text = "囲い";
            // 
            // comboBoxKakoi
            // 
            this.comboBoxKakoi.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxKakoi.FormattingEnabled = true;
            this.comboBoxKakoi.Location = new System.Drawing.Point(50, 349);
            this.comboBoxKakoi.Name = "comboBoxKakoi";
            this.comboBoxKakoi.Size = new System.Drawing.Size(274, 28);
            this.comboBoxKakoi.TabIndex = 7;
            // 
            // labelFarstSecond
            // 
            this.labelFarstSecond.AutoSize = true;
            this.labelFarstSecond.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelFarstSecond.ForeColor = System.Drawing.Color.White;
            this.labelFarstSecond.Location = new System.Drawing.Point(44, 400);
            this.labelFarstSecond.Name = "labelFarstSecond";
            this.labelFarstSecond.Size = new System.Drawing.Size(195, 36);
            this.labelFarstSecond.TabIndex = 8;
            this.labelFarstSecond.Text = "先手or後手";
            // 
            // comboBoxFS
            // 
            this.comboBoxFS.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxFS.FormattingEnabled = true;
            this.comboBoxFS.Location = new System.Drawing.Point(50, 439);
            this.comboBoxFS.Name = "comboBoxFS";
            this.comboBoxFS.Size = new System.Drawing.Size(274, 28);
            this.comboBoxFS.TabIndex = 9;
            this.comboBoxFS.TextChanged += new System.EventHandler(this.comboBoxFS_TextChanged);
            // 
            // comboBoxOutcome
            // 
            this.comboBoxOutcome.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxOutcome.FormattingEnabled = true;
            this.comboBoxOutcome.Location = new System.Drawing.Point(50, 529);
            this.comboBoxOutcome.Name = "comboBoxOutcome";
            this.comboBoxOutcome.Size = new System.Drawing.Size(274, 28);
            this.comboBoxOutcome.TabIndex = 10;
            this.comboBoxOutcome.TextChanged += new System.EventHandler(this.comboBoxOutcome_TextChanged);
            // 
            // labelOutcome
            // 
            this.labelOutcome.AutoSize = true;
            this.labelOutcome.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelOutcome.ForeColor = System.Drawing.Color.White;
            this.labelOutcome.Location = new System.Drawing.Point(44, 490);
            this.labelOutcome.Name = "labelOutcome";
            this.labelOutcome.Size = new System.Drawing.Size(87, 36);
            this.labelOutcome.TabIndex = 11;
            this.labelOutcome.Text = "勝敗";
            // 
            // buttonSagasu
            // 
            this.buttonSagasu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSagasu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSagasu.FlatAppearance.BorderSize = 0;
            this.buttonSagasu.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSagasu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.buttonSagasu.Location = new System.Drawing.Point(208, 716);
            this.buttonSagasu.Name = "buttonSagasu";
            this.buttonSagasu.Size = new System.Drawing.Size(269, 75);
            this.buttonSagasu.TabIndex = 12;
            this.buttonSagasu.Text = "検索";
            this.buttonSagasu.UseVisualStyleBackColor = false;
            this.buttonSagasu.Click += new System.EventHandler(this.buttonSagasu_Click);
            // 
            // comboBoxKakoiEnemy
            // 
            this.comboBoxKakoiEnemy.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxKakoiEnemy.FormattingEnabled = true;
            this.comboBoxKakoiEnemy.Location = new System.Drawing.Point(396, 349);
            this.comboBoxKakoiEnemy.Name = "comboBoxKakoiEnemy";
            this.comboBoxKakoiEnemy.Size = new System.Drawing.Size(274, 28);
            this.comboBoxKakoiEnemy.TabIndex = 16;
            // 
            // labelKakoiEnemy
            // 
            this.labelKakoiEnemy.AutoSize = true;
            this.labelKakoiEnemy.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelKakoiEnemy.ForeColor = System.Drawing.Color.White;
            this.labelKakoiEnemy.Location = new System.Drawing.Point(390, 310);
            this.labelKakoiEnemy.Name = "labelKakoiEnemy";
            this.labelKakoiEnemy.Size = new System.Drawing.Size(87, 36);
            this.labelKakoiEnemy.TabIndex = 15;
            this.labelKakoiEnemy.Text = "囲い";
            // 
            // comboBoxSenkeiEnemy
            // 
            this.comboBoxSenkeiEnemy.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxSenkeiEnemy.FormattingEnabled = true;
            this.comboBoxSenkeiEnemy.Location = new System.Drawing.Point(396, 259);
            this.comboBoxSenkeiEnemy.Name = "comboBoxSenkeiEnemy";
            this.comboBoxSenkeiEnemy.Size = new System.Drawing.Size(274, 28);
            this.comboBoxSenkeiEnemy.TabIndex = 14;
            // 
            // labelSenkeiEnemy
            // 
            this.labelSenkeiEnemy.AutoSize = true;
            this.labelSenkeiEnemy.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSenkeiEnemy.ForeColor = System.Drawing.Color.White;
            this.labelSenkeiEnemy.Location = new System.Drawing.Point(390, 220);
            this.labelSenkeiEnemy.Name = "labelSenkeiEnemy";
            this.labelSenkeiEnemy.Size = new System.Drawing.Size(87, 36);
            this.labelSenkeiEnemy.TabIndex = 13;
            this.labelSenkeiEnemy.Text = "戦型";
            // 
            // labelMy
            // 
            this.labelMy.AutoSize = true;
            this.labelMy.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMy.ForeColor = System.Drawing.Color.White;
            this.labelMy.Location = new System.Drawing.Point(127, 154);
            this.labelMy.Name = "labelMy";
            this.labelMy.Size = new System.Drawing.Size(97, 40);
            this.labelMy.TabIndex = 21;
            this.labelMy.Text = "自分";
            // 
            // labelEnemy
            // 
            this.labelEnemy.AutoSize = true;
            this.labelEnemy.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelEnemy.ForeColor = System.Drawing.Color.White;
            this.labelEnemy.Location = new System.Drawing.Point(480, 154);
            this.labelEnemy.Name = "labelEnemy";
            this.labelEnemy.Size = new System.Drawing.Size(97, 40);
            this.labelEnemy.TabIndex = 22;
            this.labelEnemy.Text = "相手";
            // 
            // labelTrouble
            // 
            this.labelTrouble.AutoSize = true;
            this.labelTrouble.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTrouble.ForeColor = System.Drawing.Color.White;
            this.labelTrouble.Location = new System.Drawing.Point(44, 580);
            this.labelTrouble.Name = "labelTrouble";
            this.labelTrouble.Size = new System.Drawing.Size(87, 36);
            this.labelTrouble.TabIndex = 26;
            this.labelTrouble.Text = "手数";
            // 
            // comboTrouble
            // 
            this.comboTrouble.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboTrouble.FormattingEnabled = true;
            this.comboTrouble.Location = new System.Drawing.Point(50, 619);
            this.comboTrouble.Name = "comboTrouble";
            this.comboTrouble.Size = new System.Drawing.Size(274, 28);
            this.comboTrouble.TabIndex = 25;
            this.comboTrouble.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboTrouble_KeyPress);
            // 
            // comboBoxFSEnemy
            // 
            this.comboBoxFSEnemy.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxFSEnemy.FormattingEnabled = true;
            this.comboBoxFSEnemy.Location = new System.Drawing.Point(396, 439);
            this.comboBoxFSEnemy.Name = "comboBoxFSEnemy";
            this.comboBoxFSEnemy.Size = new System.Drawing.Size(274, 28);
            this.comboBoxFSEnemy.TabIndex = 28;
            this.comboBoxFSEnemy.TextChanged += new System.EventHandler(this.comboBoxFSEnemy_TextChanged);
            // 
            // labelFarstSecondEnemy
            // 
            this.labelFarstSecondEnemy.AutoSize = true;
            this.labelFarstSecondEnemy.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelFarstSecondEnemy.ForeColor = System.Drawing.Color.White;
            this.labelFarstSecondEnemy.Location = new System.Drawing.Point(390, 400);
            this.labelFarstSecondEnemy.Name = "labelFarstSecondEnemy";
            this.labelFarstSecondEnemy.Size = new System.Drawing.Size(195, 36);
            this.labelFarstSecondEnemy.TabIndex = 27;
            this.labelFarstSecondEnemy.Text = "先手or後手";
            // 
            // labelOutcomeEnemy
            // 
            this.labelOutcomeEnemy.AutoSize = true;
            this.labelOutcomeEnemy.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelOutcomeEnemy.ForeColor = System.Drawing.Color.White;
            this.labelOutcomeEnemy.Location = new System.Drawing.Point(390, 490);
            this.labelOutcomeEnemy.Name = "labelOutcomeEnemy";
            this.labelOutcomeEnemy.Size = new System.Drawing.Size(87, 36);
            this.labelOutcomeEnemy.TabIndex = 30;
            this.labelOutcomeEnemy.Text = "勝敗";
            // 
            // comboBoxOutcomeEnemy
            // 
            this.comboBoxOutcomeEnemy.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxOutcomeEnemy.FormattingEnabled = true;
            this.comboBoxOutcomeEnemy.Location = new System.Drawing.Point(396, 529);
            this.comboBoxOutcomeEnemy.Name = "comboBoxOutcomeEnemy";
            this.comboBoxOutcomeEnemy.Size = new System.Drawing.Size(274, 28);
            this.comboBoxOutcomeEnemy.TabIndex = 29;
            this.comboBoxOutcomeEnemy.TextChanged += new System.EventHandler(this.comboBoxOutcomeEnemy_TextChanged);
            // 
            // Kensaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(728, 824);
            this.Controls.Add(this.labelOutcomeEnemy);
            this.Controls.Add(this.comboBoxOutcomeEnemy);
            this.Controls.Add(this.comboBoxFSEnemy);
            this.Controls.Add(this.labelFarstSecondEnemy);
            this.Controls.Add(this.labelTrouble);
            this.Controls.Add(this.comboTrouble);
            this.Controls.Add(this.labelEnemy);
            this.Controls.Add(this.labelMy);
            this.Controls.Add(this.comboBoxKakoiEnemy);
            this.Controls.Add(this.labelKakoiEnemy);
            this.Controls.Add(this.comboBoxSenkeiEnemy);
            this.Controls.Add(this.labelSenkeiEnemy);
            this.Controls.Add(this.buttonSagasu);
            this.Controls.Add(this.labelOutcome);
            this.Controls.Add(this.comboBoxOutcome);
            this.Controls.Add(this.comboBoxFS);
            this.Controls.Add(this.labelFarstSecond);
            this.Controls.Add(this.comboBoxKakoi);
            this.Controls.Add(this.labelKakoi);
            this.Controls.Add(this.comboBoxSenkei);
            this.Controls.Add(this.labelSenkei);
            this.Controls.Add(this.labelSearchName);
            this.Name = "Kensaku";
            this.Text = "検索";
            this.Load += new System.EventHandler(this.Kensaku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.Label labelSenkei;
        private System.Windows.Forms.ComboBox comboBoxSenkei;
        private System.Windows.Forms.Label labelKakoi;
        private System.Windows.Forms.ComboBox comboBoxKakoi;
        private System.Windows.Forms.Label labelFarstSecond;
        private System.Windows.Forms.ComboBox comboBoxFS;
        private System.Windows.Forms.ComboBox comboBoxOutcome;
        private System.Windows.Forms.Label labelOutcome;
        private System.Windows.Forms.Button buttonSagasu;
        private System.Windows.Forms.ComboBox comboBoxKakoiEnemy;
        private System.Windows.Forms.Label labelKakoiEnemy;
        private System.Windows.Forms.ComboBox comboBoxSenkeiEnemy;
        private System.Windows.Forms.Label labelSenkeiEnemy;
        private System.Windows.Forms.Label labelMy;
        private System.Windows.Forms.Label labelEnemy;
        private System.Windows.Forms.Label labelTrouble;
        private System.Windows.Forms.ComboBox comboTrouble;
        private System.Windows.Forms.ComboBox comboBoxFSEnemy;
        private System.Windows.Forms.Label labelFarstSecondEnemy;
        private System.Windows.Forms.Label labelOutcomeEnemy;
        private System.Windows.Forms.ComboBox comboBoxOutcomeEnemy;
    }
}