using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clearwox.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string AuthorName { get; set; }

        public string ArticleCategory{ get; set; }

        public string ArticleTitle{ get; set; }
        public string Article { get; set; }
        public DateTime PublishDate { get; set; }

        
    }
}
