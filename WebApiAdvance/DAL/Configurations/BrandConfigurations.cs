﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;
using WebApiAdvance.Entities;

namespace WebApiAdvance.DAL.Configurations;

public class BrandConfigurations : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.Property(b => b.Name)
            .IsRequired()
            .HasColumnType(SqlDbType.NVarChar.ToString());

        //builder.HasMany(b => b.Products)
        //    .WithMany(p => p.Brands);
            
            
    }
}
