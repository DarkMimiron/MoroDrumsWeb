using Microsoft.EntityFrameworkCore;
using MoroDrumsWeb.Models;
using MoroDrumsWeb.Persistence.EntityTypeConfigurations;

namespace MoroDrumsWeb.Persistence{
    public class MoroDrumsContext : DbContext{
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Video> Videos{ get; set; }
        
        public MoroDrumsContext(DbContextOptions options)
        : base(options){
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new VideoConfiguration());
        }
    }
}