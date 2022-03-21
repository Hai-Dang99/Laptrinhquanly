using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LHDBaiTapLon214.Models
{
    public partial class QuanLySinhVienDbContex : DbContext
    {
        public QuanLySinhVienDbContex()
            : base("name=QuanLySinhVienDbContex")
        {
        }

        public DbSet<Diem> Diems { get; set; }
        public DbSet<ThongTin> Thongtins { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<LHDBaiTapLon214.Models.Account> Accounts { get; set; }
    }
}
