using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LAB03.Models
{
    public partial class DBBook : DbContext
    {
        public DBBook()
            : base("name=DBBook2")
        {
        }

        public virtual DbSet<book> books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<book>()
                .Property(e => e.Image)
                .IsUnicode(false);
        }
    }
}
