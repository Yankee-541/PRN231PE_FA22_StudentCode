using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class PRN231PE_FA22_StudentCodeContext : DbContext
    {
        public PRN231PE_FA22_StudentCodeContext() { }
        public PRN231PE_FA22_StudentCodeContext(DbContextOptions<PRN231PE_FA22_StudentCodeContext> options)
        : base(options)
        {
        }
        public virtual DbSet<HRStaff> HRStaffs { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<PropertyProfile> PropertyProfiles { get; set; }
        public virtual DbSet<Renting> Renting { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(local); database=PRN231PE_FA22_StudentCode;uid=sa;pwd=NTQ@1234;Trusted_Connection=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HRStaff>().HasKey(t => t.EmailAddress);
            modelBuilder.Entity<Company>().HasKey(t => t.CompanyID);
            modelBuilder.Entity<PropertyProfile>().HasKey(t => t.PropertyProfileID);
            modelBuilder.Entity<Renting>().HasKey(t => new { t.PropertyProfileID, t.CompanyID });
        }
    }
}
