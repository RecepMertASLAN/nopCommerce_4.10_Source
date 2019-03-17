using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Core.Domain.Catalog;

namespace Nop.Data.Mapping.Catalog
{
	public class MyNewEntityMap : NopEntityTypeConfiguration<MyNewEntity>
	{
		public override void Configure(EntityTypeBuilder<MyNewEntity> builder)
		{
			builder.ToTable(nameof(MyNewEntity));
			builder.HasKey(mynewentity => mynewentity.Id);

			builder.Property(mynewentity => mynewentity.MyEntityName).HasMaxLength(100).IsRequired();
			builder.Property(mynewentity => mynewentity.MyEntitySurname).HasMaxLength(100);




			base.Configure(builder);
		}
	}
}
