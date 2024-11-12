using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Code_First_Real.Models
{
    public partial class QLSVDataContext : DbContext
    {
        public QLSVDataContext()
            : base("name=QLSVDataContext")
        {
        }
        // Tạo DbSet
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Diem> diems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
