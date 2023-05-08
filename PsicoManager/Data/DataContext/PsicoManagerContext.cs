using Microsoft.EntityFrameworkCore;
using PsicoManager.Models;
using System.Data.SqlClient;

namespace PsicoManager.Data.DataContext
{
    public class PsicoManagerContext : DbContext
        {
            public PsicoManagerContext(DbContextOptions<PsicoManagerContext> options) : base(options)
            {
            }

            public DbSet<Appointments> Appointments { get; set; }
            public DbSet<Psychologist> Psychologist { get; set; }
            public DbSet<Patients> Patients { get; set; }
            public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointments>().ToTable("Appointment");
            modelBuilder.Entity<Psychologist>().ToTable("Psychologist");
            modelBuilder.Entity<Patients>().ToTable("Patient");
            modelBuilder.Entity<Users>().ToTable("User");
        }

        //private static bool IsServerConnected(string connectionString)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            return true;
        //        }
        //        catch (SqlException)
        //        {
        //            return false;
        //        }
        //    }
        //}
    }
    
}
