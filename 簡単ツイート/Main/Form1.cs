using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreTweet;
using EZTweet.Utility;

namespace EZTweet {
    public partial class Form1 : Form {
        private static Path path = new Path();
        private static XmlUtil xml = new XmlUtil(path.CONFIG);

        public Form1() {
            InitializeComponent();
            if (xml.GetElements("API", "Key") == "null" || xml.GetElements("API", "Secret") == "null") {
                MessageBox.Show("APIの設定が見つかりません。\n入力してください。");
                Account.SetAPI setAPI = new Account.SetAPI();
                setAPI.ShowDialog();
            }

            if (xml.GetElements("Access", "Token") == "null" || xml.GetElements("Access", "Secret") == "null") {
                MessageBox.Show("トークンの設定が見つかりません。\nログインしてください。");
                string tokens = TweetUtil.OAuth(xml.GetElements("API", "Key"), xml.GetElements("API", "Secret")).ToString();
                string AccessToken = TweetUtil.DivideTokens(tokens)[0];
                string AccessSecret = TweetUtil.DivideTokens(tokens)[1];
                xml.UpdateElements("Access", "Token", AccessToken);
                xml.UpdateElements("Access", "Secret", AccessSecret);
            }
        }

        private static TweetUtil tweet = new TweetUtil(xml.GetElements("API", "Key"), xml.GetElements("API", "Secret"), xml.GetElements("Access", "Token"), xml.GetElements("Access", "Secret"));

        private void tweetbtn_Click(object sender, EventArgs e) {
            string content = contentbox.Text;
            tweet.Tweet(content);
        }
    }
}
