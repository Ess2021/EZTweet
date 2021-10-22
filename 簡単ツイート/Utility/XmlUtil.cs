using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using System.Windows.Forms;

namespace EZTweet.Utility {
    class XmlUtil {
        private readonly string path;
        public XmlUtil(string Path) { this.path = Path; }

        /// <summary>
        /// xmlファイルの任意のタグ内の値を読み込みます
        /// </summary>
        public string GetElements(string index1, string index2) {
            try {
                XElement xml = XElement.Load(@path);
                IEnumerable<string> values = from item in xml.Elements(index1).Elements(index2)
                                             select item.Value;               
                return values.ToArray()[0];
            } catch (Exception ex) {
                MessageBox.Show($"例外が発生しました\n{ex.ToString()}", "EZTweet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// xmlファイルの任意のタグ内の値を更新します
        /// </summary>
        public void UpdateElements(string index1, string index2, string value) {
            try {
                XElement xml = XElement.Load(@path);
                XElement info = (from item in xml.Elements(index1).Elements(index2)
                                 select item).Single();
                info.Value = value;
                xml.Save(@path);
            } catch (Exception ex) {
                MessageBox.Show($"例外が発生しました\n{ex.ToString()}", "EZTweet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
