using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aytass.Model
{
    public class ContentModel
    {
        public int ContentID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string MetaK { get; set; }
        public string MetaD { get; set; }
        public string Picture { get; set; }
        public string LongDescription { get; set; }
        public string Tag { get; set; } 
    }
}
