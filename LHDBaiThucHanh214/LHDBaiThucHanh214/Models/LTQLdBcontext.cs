using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LHDBaiThucHanh214.Models
{
    public partial class LTQLdBcontext : DbContext
    {
        public LTQLdBcontext()
            : base("name=LTQLdBcontext")
        {
        }

        
        public virtual DbSet<Student5> Student5s { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<HaiDang> HaiDangs { get; set; }
        public object Employee { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
