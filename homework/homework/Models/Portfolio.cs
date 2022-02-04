using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
