using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vtitbid.ISP20.Strizhak.Ex.Entities;

namespace Vtitbid.ISP20.Strizhak.Ex.Configurations
{
	public class PriceEntityTypeConfiguration : IEntityTypeConfiguration<Price>
	{
		public void Configure(EntityTypeBuilder<Price> builder)
		{
			builder.HasKey(p => p.Id)
				.HasName("PK_Prices_Id");

			builder.Property(p => p.ProductName)
				.HasColumnType("nvarchar")
				.HasMaxLength(256)
				.IsRequired();

			builder.Property(p => p.ShopName)
				.HasColumnType("nvarchar")
				.HasMaxLength(256)
				.IsRequired();

			builder.Property(p => p.Cost)
				.HasColumnType("money")
				.IsRequired();
		}
	}
}
