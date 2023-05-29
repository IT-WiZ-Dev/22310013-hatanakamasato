
namespace sozaihantei
{
    partial class FormSindan
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.pictureBoxYes = new System.Windows.Forms.PictureBox();
            this.pictureBoxNo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.labelQuestion.ForeColor = System.Drawing.Color.White;
            this.labelQuestion.Location = new System.Drawing.Point(422, 19);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(199, 50);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "question";
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonYes.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.buttonYes.ForeColor = System.Drawing.Color.White;
            this.buttonYes.Location = new System.Drawing.Point(202, 660);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(500, 118);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "はい";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonNo.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.buttonNo.ForeColor = System.Drawing.Color.White;
            this.buttonNo.Location = new System.Drawing.Point(891, 660);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(500, 118);
            this.buttonNo.TabIndex = 2;
            this.buttonNo.Text = "いいえ";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // pictureBoxYes
            // 
            this.pictureBoxYes.Location = new System.Drawing.Point(202, 122);
            this.pictureBoxYes.Name = "pictureBoxYes";
            this.pictureBoxYes.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxYes.TabIndex = 3;
            this.pictureBoxYes.TabStop = false;
            // 
            // pictureBoxNo
            // 
            this.pictureBoxNo.Location = new System.Drawing.Point(891, 122);
            this.pictureBoxNo.Name = "pictureBoxNo";
            this.pictureBoxNo.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxNo.TabIndex = 4;
            this.pictureBoxNo.TabStop = false;
            // 
            // FormSindan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1378, 944);
            this.Controls.Add(this.pictureBoxNo);
            this.Controls.Add(this.pictureBoxYes);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelQuestion);
            this.Name = "FormSindan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "診断";
            this.Load += new System.EventHandler(this.FormSindan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.PictureBox pictureBoxYes;
        private System.Windows.Forms.PictureBox pictureBoxNo;
    }
}