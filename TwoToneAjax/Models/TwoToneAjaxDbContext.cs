using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TwoToneAjax.Models;

namespace TwoToneAjax.Models
{
    public class TwoToneAjaxDbContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }

        public TwoToneAjaxDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=ajax;uid=root;pwd=root;");
        }

        public TwoToneAjaxDbContext(DbContextOptions<TwoToneAjaxDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}