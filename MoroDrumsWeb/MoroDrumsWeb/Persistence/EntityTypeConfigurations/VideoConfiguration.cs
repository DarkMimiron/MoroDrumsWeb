using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoroDrumsWeb.Models;

namespace MoroDrumsWeb.Persistence.EntityTypeConfigurations{
    public class VideoConfiguration : IEntityTypeConfiguration<Video>{
        public void Configure(EntityTypeBuilder<Video> builder){
            builder.ToTable("Video");

            builder.Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(v => v.Description)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(v => v.VideoUrl)
                .IsRequired()
                .HasMaxLength(2500);
        }
    }
}