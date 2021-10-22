using System;
using System.Collections.Generic;
using System.Text;
using CoreTweet;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace EZTweet.Utility {
    class TweetUtil {
        private readonly string ConsumerKey;
        private readonly string ConsumerSecret;
        private readonly string AccessToken;
        private readonly string AccessSecret;

        static Path path = new Path();

        public TweetUtil(string ConsumerKey, string ConsumerSecret, string AccessToken, string AccessSecret) {
            this.ConsumerKey = ConsumerKey;
            this.ConsumerSecret = ConsumerSecret;
            this.AccessToken = AccessToken;
            this.AccessSecret = AccessSecret;
        }

        /// <summary>
        /// 任意のURLを既定のブラウザで開きます
        /// </summary>
        private static Process OpenUrl(string url) {
            ProcessStartInfo pi = new ProcessStartInfo() {
                FileName = url,
                UseShellExecute = true,
            };
            return Process.Start(pi);
        }

        /// <summary>
        /// OAuthを利用してwebブラウザからトークンを取得します
        /// </summary>
        public static Tokens OAuth(string ConsumerKey, string ConsumerSecret) {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            XmlUtil xml = new XmlUtil(path.CONFIG);

            while (true) {
                InputBox ib = new InputBox("認証番号入力");
                try {
                    var session = CoreTweet.OAuth.Authorize(ConsumerKey, ConsumerSecret);
                    var url = session.AuthorizeUri;
                    OpenUrl(url.ToString());
                    ib.ShowDialog();
                    return CoreTweet.OAuth.GetTokens(session, ib.inputText);
                } catch (Exception ex) {
                    MessageBox.Show($"例外が発生しました\n{ex.ToString()}\n\nAPIの設定をやり直してください。", "EZTweet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Account.SetAPI setAPI = new Account.SetAPI();
                    setAPI.ShowDialog();
                    ConsumerKey = xml.GetElements("API", "Key");
                    ConsumerSecret = xml.GetElements("API", "Secret");
                }
            }
        }

        /// <summary>
        /// OAuthで得たtokensをAccessToken[0]とAccessSecret[1]に分割します
        /// </summary>
        public static string[] DivideTokens(string rawToken) {
            string accessToken = rawToken.Split('&')[0].Replace("oauth_token=", "");
            string accessSecret = rawToken.Split('&')[1].Replace("oauth_token_secret=", "");
            return new string[] { accessToken, accessSecret };
        }

        /// <summary>
        /// ツイートします
        /// </summary>
        public void Tweet(string content) {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            try {
                Tokens tokens = Tokens.Create(ConsumerKey, ConsumerSecret, AccessToken, AccessSecret);
                Status status = tokens.Statuses.Update(new { status = content });
            } catch (Exception ex) {
                MessageBox.Show($"例外が発生しました\n{ex.ToString()}", "EZTweet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
