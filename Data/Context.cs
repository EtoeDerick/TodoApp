using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Object.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Context : DbContext
    {
        //private readonly Options _options;
        private readonly ILoggerFactory _loggerFactory;

        public Context(DbContextOptions<Context> options, ILoggerFactory loggerFactory)
            : base(options)
        {
            _loggerFactory = loggerFactory;

        }
        

        public DbSet<Item>? Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Item>(item =>
            {
                item.ToTable("todo_T_Item");
                item.HasKey(i => i.Id);
            });

            base.OnModelCreating(builder);
        }

    }
}
