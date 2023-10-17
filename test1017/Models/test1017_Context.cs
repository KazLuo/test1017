using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace test1017.Models
{
    public partial class test1017_Context : DbContext
    {
        public test1017_Context()
            : base("name=test1017_Context")
        {
        }

        public virtual DbSet<Org> Orgs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Members> Members { get; set; }
    }
}