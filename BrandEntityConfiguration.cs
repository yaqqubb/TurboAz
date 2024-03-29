﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ2.Entities;

namespace Turbo.Az.Models.Configurations
{
    public class BrandEntityConfiguration : IEntityTypeConfiguration<Brendler>
    {
        public void Configure(EntityTypeBuilder<Brendler> builder)
        {

            builder.Property(m => m.Id).HasColumnType("int").IsRequired();
            builder.Property(m => m.CreatedBy).HasColumnType("int");
            builder.Property(m => m.CreatedAt).HasColumnType("datetime");
            builder.Property(m => m.LastModifiedBy).HasColumnType("int");
            builder.Property(m => m.LastModifiedAt).HasColumnType("datetime");
            builder.Property(m => m.DeletedBy).HasColumnType("int");
            builder.Property(m => m.DeletedAt).HasColumnType("datetime");


            builder.HasKey(m => m.Id);
            builder.ToTable("Brand");




        }
    }
}