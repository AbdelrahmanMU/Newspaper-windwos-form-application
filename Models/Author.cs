using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Models
{
    public class Author
    {
        public Author()
        {
            news = new List<News>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }    
        public DateTime hireDate { get; set; }


        public virtual List<News> news { get; set; }
    }
}
