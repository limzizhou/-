using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// getter setter
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
            Type = type;
        }

        public string Type
        {
            get { return type; }
            set { 
                if (value == "教育" || value == "娱乐"  || value == "音乐"  || value == "其他")
                {
                    type = value;
                }
                else
                {
                    type = "其他";
                }
            }
        }

    }
}
