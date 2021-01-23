using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymBnb.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Caption { get; set; }
        public Ad Ad { get; set; }
    }
}
