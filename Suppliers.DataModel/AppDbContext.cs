using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Suppliers.DataModel
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        
        //protected override void OnConfiguring(
        //    DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=CHRIIISCOMP\\SQLEXPRESS;" +
        //        "Database=Merano_DatabaseNew;" +
        //        "Integrated Security=SSPI;" +
        //    "TrustServerCertificate=true");
        //    }
        //}

        
        
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-EDG1IN1\\SQLEXPRESS;" +
                "Database=eisensy_csbentprog;" +
                "UID = eisensy_student;" +
                "PWD = Benilde@2020;" +
                "TrustServerCertificate = true");
            }
        }

        //protected override void OnConfiguring(
        //    DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=ATRIUM-ISLAB19;" +
        //            "Database=TestDB69;UID=sa;PWD=stbenilde;" +
        //            "TrustServerCertificate=true");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Supplier>().ToTable("SuppliersINV");

            //modelBuilder.Entity<Supplier>()
            //    .HasNoKey();

            modelBuilder.Entity<Supplier>()
        .HasKey(e => e.SupplierID);

            modelBuilder.Entity<Supplier>().Property(p => p.SupplierID).HasColumnName("SupplierID");
            modelBuilder.Entity<Supplier>().Property(p => p.CompanyName).HasColumnName("CompanyName");
            modelBuilder.Entity<Supplier>().Property(p => p.CompanyName).HasColumnType("nvarchar(MAX)");
            modelBuilder.Entity<Supplier>().Property(p => p.Address).HasColumnName("Address");
            modelBuilder.Entity<Supplier>().Property(p => p.Address).HasColumnType("nvarchar(MAX)");
            modelBuilder.Entity<Supplier>().Property(p => p.Representative).HasColumnName("Representative");
            modelBuilder.Entity<Supplier>().Property(p => p.Representative).HasColumnType("nvarchar(MAX)");
            modelBuilder.Entity<Supplier>().Property(p => p.ContactNo).HasColumnName("ContactNo");
            modelBuilder.Entity<Supplier>().Property(p => p.ContactNo).HasColumnType("nvarchar(MAX)");
            modelBuilder.Entity<Supplier>().Property(p => p.DateAdded).HasColumnName("DateAdded");
            modelBuilder.Entity<Supplier>().Property(p => p.DateAdded).HasColumnType("DateTime2(7)");
            modelBuilder.Entity<Supplier>().Property(p => p.DateModified).HasColumnType("DateTime2(7)");

            base.OnModelCreating(modelBuilder);

        }

        



        public DbSet<Supplier> SuppliersINV { get; set; }
        public DbSet<Product> ProductsINV { get; set; }

        //public DbSet<IdentityUser> AspNetUsers { get; set; }


    }

}

