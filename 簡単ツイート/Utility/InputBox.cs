using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EZTweet.Utility {
    public partial class InputBox : Form {
        public string inputText;

        /// <summary>
        /// 簡易入力ダイアログ
        /// </summary>
        /// <param name="title"></param>
        public InputBox(string title) {
            InitializeComponent(title);
        }

        private void sendBtn_Click(object sender, EventArgs e) {
            inputText = textBox1.Text;
            this.Close();
        }
    }
}
