using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ2.Entities;

namespace Turbo.Az.Models.Configurations
{
    public class AnnouncementsConfiguration : IEntityTypeConfiguration<Elan>
    {
        public void Configure(EntityTypeBuilder<Elan> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int");
            builder.Property(m => m.ModelId).HasColumnType("int");
            builder.Property(m => m.March).HasColumnType("int");
            builder.Property(m => m.Price).HasColumnType("decimal").HasPrecision(18, 2);
            builder.Property(m => m.Banlar).HasColumnType("int");
            builder.Property(m => m.Yanacaqlar).HasColumnType("int");
            builder.Property(m => m.SuretQutusu).HasColumnType("int");
            builder.Property(m => m.Transmission).HasColumnType("int");
            builder.Property(m => m.CreatedBy).HasColumnType("int");
            builder.Property(m => m.CreatedAt).HasColumnType("datetime");
            builder.Property(m => m.LastModifiedBy).HasColumnType("int");
            builder.Property(m => m.LastModifiedAt).HasColumnType("datetime");
            builder.Property(m => m.DeletedBy).HasColumnType("int");
            builder.Property(m => m.DeletedAt).HasColumnType("datetime");


            builder.HasKey(m => m.Id);
            builder.ToTable("CarAnnouncement");

            builder.HasOne<Modeller>()
               .WithMany()
               .HasForeignKey(m => m.ModelId)
               .HasPrincipalKey(m => m.Id)
               .OnDelete(DeleteBehavior.NoAction);


        }
    }
}