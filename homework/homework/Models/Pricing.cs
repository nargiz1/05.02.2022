using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int GB { get; set; }
        public string Recommendation { get; set; }
        public string Text { get; set; }
        public int Price { get; set; }
        public string Link { get; set; }
    }
}
