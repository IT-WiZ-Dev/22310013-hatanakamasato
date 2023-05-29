
namespace sozaihantei
{
    partial class FormAns
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelKijiName = new System.Windows.Forms.Label();
            this.labelShoukai = new System.Windows.Forms.Label();
            this.pictureBoxAns = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAns)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("ＭＳ 明朝", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(218, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(822, 56);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "あなたに合っている服の生地は";
            // 
            // labelKijiName
            // 
            this.labelKijiName.AutoSize = true;
            this.labelKijiName.Font = new System.Drawing.Font("ＭＳ 明朝", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelKijiName.ForeColor = System.Drawing.Color.White;
            this.labelKijiName.Location = new System.Drawing.Point(474, 84);
            this.labelKijiName.Name = "labelKijiName";
            this.labelKijiName.Size = new System.Drawing.Size(252, 56);
            this.labelKijiName.TabIndex = 1;
            this.labelKijiName.Text = "生地名前";
            // 
            // labelShoukai
            // 
            this.labelShoukai.AutoSize = true;
            this.labelShoukai.Font = new System.Drawing.Font("ＭＳ 明朝", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelShoukai.ForeColor = System.Drawing.Color.White;
            this.labelShoukai.Location = new System.Drawing.Point(50, 639);
            this.labelShoukai.Name = "labelShoukai";
            this.labelShoukai.Padding = new System.Windows.Forms.Padding(0, 0, 0, 200);
            this.labelShoukai.Size = new System.Drawing.Size(164, 248);
            this.labelShoukai.TabIndex = 2;
            this.labelShoukai.Text = "紹介文\r\n";
            // 
            // pictureBoxAns
            // 
            this.pictureBoxAns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxAns.Location = new System.Drawing.Point(279, 181);
            this.pictureBoxAns.Name = "pictureBoxAns";
            this.pictureBoxAns.Size = new System.Drawing.Size(711, 400);
            this.pictureBoxAns.TabIndex = 3;
            this.pictureBoxAns.TabStop = false;
            // 
            // FormAns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1256, 1050);
            this.Controls.Add(this.pictureBoxAns);
            this.Controls.Add(this.labelShoukai);
            this.Controls.Add(this.labelKijiName);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormAns";
            this.Text = "紹介";
            this.Load += new System.EventHandler(this.FormAns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelKijiName;
        private System.Windows.Forms.Label labelShoukai;
        private System.Windows.Forms.PictureBox pictureBoxAns;
    }
}