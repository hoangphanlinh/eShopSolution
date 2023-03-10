using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).UseIdentityColumn();


            builder.HasOne(x => x.Product).WithMany(x => x.Carts).HasForeignKey(x => x.ProductID);
            builder.HasOne(x => x.AppUser).WithMany(x => x.Carts).HasForeignKey(x => x.UserID);

        }
    }
}
