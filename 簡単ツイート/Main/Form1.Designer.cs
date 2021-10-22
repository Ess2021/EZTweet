
namespace EZTweet {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.contentbox = new System.Windows.Forms.TextBox();
            this.tweetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contentbox
            // 
            this.contentbox.Location = new System.Drawing.Point(13, 13);
            this.contentbox.Multiline = true;
            this.contentbox.Name = "contentbox";
            this.contentbox.Size = new System.Drawing.Size(359, 107);
            this.contentbox.TabIndex = 0;
            // 
            // tweetbtn
            // 
            this.tweetbtn.Location = new System.Drawing.Point(13, 126);
            this.tweetbtn.Name = "tweetbtn";
            this.tweetbtn.Size = new System.Drawing.Size(359, 34);
            this.tweetbtn.TabIndex = 1;
            this.tweetbtn.Text = "ツイート";
            this.tweetbtn.UseVisualStyleBackColor = true;
            this.tweetbtn.Click += new System.EventHandler(this.tweetbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 167);
            this.Controls.Add(this.tweetbtn);
            this.Controls.Add(this.contentbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 206);
            this.MinimumSize = new System.Drawing.Size(400, 206);
            this.Name = "Form1";
            this.Text = "ツイートする";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contentbox;
        private System.Windows.Forms.Button tweetbtn;
    }
}

