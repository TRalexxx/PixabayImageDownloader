using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixabayDownloader
{
    public class HitsCollection
    {
        public int total { get; set; }
        public int totalHits { get; set; }
        public ICollection<Hit> hits { get; set; }
    }
}
