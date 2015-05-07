using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PZW_4.Model
{
    public class Post
    {
        public Post(string userName, string userImagePath, string time, string text)
        {
            this.UserName = userName;
            this.UserImagePath = userImagePath;
            this.Time = time;
            this.Text = text;
        }
        public string UserName { get; set; }
        public string UserImagePath { get; set; }
        public string Time { get; set; }
        public string Text { get; set; }
    }
}
