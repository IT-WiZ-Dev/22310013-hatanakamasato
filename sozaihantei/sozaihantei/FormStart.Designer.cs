
namespace sozaihantei
{
    partial class start
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSindan = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSubtitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSindan
            // 
            this.buttonSindan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonSindan.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSindan.ForeColor = System.Drawing.Color.White;
            this.buttonSindan.Location = new System.Drawing.Point(2, 314);
            this.buttonSindan.Name = "buttonSindan";
            this.buttonSindan.Size = new System.Drawing.Size(774, 117);
            this.buttonSindan.TabIndex = 0;
            this.buttonSindan.Text = "診断する";
            this.buttonSindan.UseVisualStyleBackColor = false;
            this.buttonSindan.Click += new System.EventHandler(this.buttonSindan_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(47, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1049, 66);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "自分におすすめの服の繊維を診断しましょう！";
            // 
            // buttonSubtitle
            // 
            this.buttonSubtitle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSubtitle.Location = new System.Drawing.Point(95, 112);
            this.buttonSubtitle.Name = "buttonSubtitle";
            this.buttonSubtitle.Size = new System.Drawing.Size(599, 175);
            this.buttonSubtitle.TabIndex = 5;
            this.buttonSubtitle.Text = "繊維選びにも自分なりのこだわりがあるかもしれません。\r\n\r\nそこで、このアプリではあなたのパーソナルな好みやライフスタイルに合わせた繊維を診断します。\r\n\r\n自分" +
    "に合った服を着ることで、気分も上がり、自信もつくはず。\r\n\r\nさあ、あなたにぴったりな繊維を診断しましょう！\r\n";
            this.buttonSubtitle.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(778, 433);
            this.Controls.Add(this.buttonSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSindan);
            this.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "start";
            this.Text = "start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSindan;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSubtitle;
    }
}

