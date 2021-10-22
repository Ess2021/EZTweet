using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace EZTweet.Utility {
    class FileUtil {
        public FileUtil() { }

        public static void MakeFile(string path) {
            StreamWriter sw = File.CreateText(path);
            sw.Close();
        }

        public static void WriteTextFile(string path, string text) {
            try {
                string filePath = path;
                Encoding enc = Encoding.GetEncoding("utf-16");
                System.IO.File.AppendAllText(filePath, text, enc);
            } catch (Exception ex) {
                MessageBox.Show($"例外が発生しました\n{ex.ToString()}", "EZTweet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void MakeFolder(string path) {
            Directory.CreateDirectory(path);
        }
    }
}
