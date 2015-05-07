using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PZW_4.Model
{
    public class User
    {
        public User(string name, int id, string filePath)
        {
            this.Name = name;
            this.Id = id;
            this.FilePath = filePath;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public string FilePath { get; set; }
    }
}
