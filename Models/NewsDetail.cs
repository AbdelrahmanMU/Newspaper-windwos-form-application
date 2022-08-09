using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class NewsDetail
    {
        public NewsDetail()
        {
         
        }
        public int id { get; set; }
        public string? desc { get; set; }
        public string? pdf { get; set; }
        public string? photo { get; set; }
        public string? reference { get; set; }

        [ForeignKey("news")]
        public int news_id { get; set; }
        public virtual News? news { get; set; }
    }
}
