using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactsYouCanNotLookUp.Models
{
    public class Fact
    {
        public int FactId { get; set; }
        public string BingoId { get; set; }
        public string Value { get; set; }
        public bool isOprah { get; set; }
        public DateTime Updated { get; set; }
    }
}
