using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Comments { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
    }
}
