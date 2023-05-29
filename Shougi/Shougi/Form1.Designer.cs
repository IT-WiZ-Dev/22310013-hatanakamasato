
namespace Shougi
{
    partial class Form1
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
            this.buttonKensaku = new System.Windows.Forms.Button();
            this.buttonTouroku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKensaku
            // 
            this.buttonKensaku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonKensaku.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonKensaku.ForeColor = System.Drawing.Color.White;
            this.buttonKensaku.Location = new System.Drawing.Point(233, 117);
            this.buttonKensaku.Name = "buttonKensaku";
            this.buttonKensaku.Size = new System.Drawing.Size(238, 73);
            this.buttonKensaku.TabIndex = 0;
            this.buttonKensaku.Text = "検索";
            this.buttonKensaku.UseVisualStyleBackColor = false;
            this.buttonKensaku.Click += new System.EventHandler(this.buttonkensaku_Click);
            // 
            // buttonTouroku
            // 
            this.buttonTouroku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonTouroku.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonTouroku.ForeColor = System.Drawing.Color.White;
            this.buttonTouroku.Location = new System.Drawing.Point(233, 290);
            this.buttonTouroku.Name = "buttonTouroku";
            this.buttonTouroku.Size = new System.Drawing.Size(238, 73);
            this.buttonTouroku.TabIndex = 1;
            this.buttonTouroku.Text = "登録";
            this.buttonTouroku.UseVisualStyleBackColor = false;
            this.buttonTouroku.Click += new System.EventHandler(this.buttonTouroku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(728, 557);
            this.Controls.Add(this.buttonTouroku);
            this.Controls.Add(this.buttonKensaku);
            this.Name = "Form1";
            this.Text = "スタート画面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKensaku;
        private System.Windows.Forms.Button buttonTouroku;
    }
}

