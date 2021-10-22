using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EZTweet.Utility;

namespace EZTweet.Account {
    public partial class SetAPI : Form {
        public SetAPI() {
            InitializeComponent();
        }

        static Path path = new Path();
        private XmlUtil xml = new XmlUtil(path.CONFIG);
        private void setbtn_Click(object sender, EventArgs e) {
            string API_Key = APIkeyBox.Text;
            string API_Secret = APIsecretBox.Text;
            xml.UpdateElements("API", "Key", API_Key);
            xml.UpdateElements("API", "Secret", API_Secret);
            this.Close();
        }
    }
}
