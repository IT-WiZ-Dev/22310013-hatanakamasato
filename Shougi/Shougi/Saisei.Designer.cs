
namespace Shougi
{
    partial class Saisei
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
            this.pictureBoxTatami = new System.Windows.Forms.PictureBox();
            this.pictureBoxShougiban = new System.Windows.Forms.PictureBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTatami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShougiban)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTatami
            // 
            this.pictureBoxTatami.BackColor = System.Drawing.Color.White;
            this.pictureBoxTatami.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxTatami.Name = "pictureBoxTatami";
            this.pictureBoxTatami.Size = new System.Drawing.Size(2000, 1000);
            this.pictureBoxTatami.TabIndex = 0;
            this.pictureBoxTatami.TabStop = false;
            // 
            // pictureBoxShougiban
            // 
            this.pictureBoxShougiban.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxShougiban.Location = new System.Drawing.Point(327, 0);
            this.pictureBoxShougiban.Name = "pictureBoxShougiban";
            this.pictureBoxShougiban.Size = new System.Drawing.Size(695, 660);
            this.pictureBoxShougiban.TabIndex = 1;
            this.pictureBoxShougiban.TabStop = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.White;
            this.buttonLeft.Location = new System.Drawing.Point(462, 696);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(200, 100);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.White;
            this.buttonRight.Location = new System.Drawing.Point(668, 696);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(200, 100);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // Saisei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 1050);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.pictureBoxShougiban);
            this.Controls.Add(this.pictureBoxTatami);
            this.Name = "Saisei";
            this.Text = "再生";
            this.Load += new System.EventHandler(this.Saisei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTatami)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShougiban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTatami;
        private System.Windows.Forms.PictureBox pictureBoxShougiban;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
    }
}