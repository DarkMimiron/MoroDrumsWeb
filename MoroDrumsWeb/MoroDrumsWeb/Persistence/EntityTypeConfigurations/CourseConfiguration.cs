using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoroDrumsWeb.Models;

namespace MoroDrumsWeb.Persistence.EntityTypeConfigurations{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>{
        public void Configure(EntityTypeBuilder<Course> builder){
            builder.ToTable("Course");

            builder.Property(c => c.CourseURL)
                .IsRequired()
                .HasMaxLength(2500);
            
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasMany(c => c.Videos)
                .WithOne(v => v.Course)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}