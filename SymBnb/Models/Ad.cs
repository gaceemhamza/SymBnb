using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymBnb.Models
{
    public class Ad
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string price { get; set; }
        public string Content { get; set; }
        public string Cover_Image { get; set; }
        public int Romms { get; set; }
        public User User{ get; set; }
    }
}
