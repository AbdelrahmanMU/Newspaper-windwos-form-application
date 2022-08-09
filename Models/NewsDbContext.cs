using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day2.Models
{
    public class NewsDbContext: DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<News> news { get; set; }
        public virtual DbSet<NewsDetail> NewsDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=News;Trusted_Connection=True;");
        }

    }
}
