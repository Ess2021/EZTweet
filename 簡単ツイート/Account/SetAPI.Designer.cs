
namespace EZTweet.Account {
    partial class SetAPI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.APIkeyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.APIsecretBox = new System.Windows.Forms.TextBox();
            this.setbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "API Key";
            // 
            // APIkeyBox
            // 
            this.APIkeyBox.Location = new System.Drawing.Point(66, 10);
            this.APIkeyBox.Name = "APIkeyBox";
            this.APIkeyBox.Size = new System.Drawing.Size(406, 23);
            this.APIkeyBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "API Key Secret";
            // 
            // APIsecretBox
            // 
            this.APIsecretBox.Location = new System.Drawing.Point(102, 40);
            this.APIsecretBox.Name = "APIsecretBox";
            this.APIsecretBox.Size = new System.Drawing.Size(370, 23);
            this.APIsecretBox.TabIndex = 3;
            // 
            // setbtn
            // 
            this.setbtn.Location = new System.Drawing.Point(363, 69);
            this.setbtn.Name = "setbtn";
            this.setbtn.Size = new System.Drawing.Size(109, 30);
            this.setbtn.TabIndex = 4;
            this.setbtn.Text = "確定";
            this.setbtn.UseVisualStyleBackColor = true;
            this.setbtn.Click += new System.EventHandler(this.setbtn_Click);
            // 
            // SetAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 106);
            this.Controls.Add(this.setbtn);
            this.Controls.Add(this.APIsecretBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.APIkeyBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 145);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 145);
            this.Name = "SetAPI";
            this.Text = "クライアント設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox APIkeyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox APIsecretBox;
        private System.Windows.Forms.Button setbtn;
    }
}