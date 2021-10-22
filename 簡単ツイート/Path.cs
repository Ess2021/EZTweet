using System;
using System.Collections.Generic;
using System.Text;

namespace EZTweet {
    class Path {
        public string FOLDER;
        public string CONFIG;

        public Path() {
            this.FOLDER = @"config";
            this.CONFIG = @"config/config.xml";
        }
    }
}
