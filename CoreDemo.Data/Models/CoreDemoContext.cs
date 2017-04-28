using System;
using CoreDemo.Data.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreDemo.Data.Models
{
    public class CoreDemoContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=rm-wz93fh055oa154dq9o.sqlserver.rds.aliyuncs.com,3433; Database=CoreDemo; User Id=leihong; Password=P@ssw0rd;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}