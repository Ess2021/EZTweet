using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EZTweet.Utility;

namespace EZTweet {
    static class EZTweet {
        static Path path = new Path();
        
        /// <summary>
        ///  最初に実行するやつ
        /// </summary>
        [STAThread]
        static void Main() {
            if (!Directory.Exists(path.FOLDER)) {
                FileUtil.MakeFolder(path.FOLDER);
            }

            if (!File.Exists(path.CONFIG)) {
                FileUtil.MakeFile(path.CONFIG);
                FileUtil.WriteTextFile(path.CONFIG, Resource.config_default);
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
