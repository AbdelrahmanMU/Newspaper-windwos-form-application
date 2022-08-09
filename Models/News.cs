using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class News
    {

        public int id { get; set; }
        public string? title { get; set; }
        public string? brief { get; set; }
        public DateTime date { get; set; }
  
        [ForeignKey("author")]
        public int author_id { get; set; }

        public virtual Author? author { get; set; }
        public virtual NewsDetail? NewsDetail { get; set; }
    }
}
