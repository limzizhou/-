using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Video
    {
        public string title;
        public string author;
        //影片类型只有4种：教育，娱乐，音乐，其他
        private string type;

        public Video(string title, string author, string type)
        {
            this.title = title;
            this.author = author;
            this.type = type;
        }
    }
}
