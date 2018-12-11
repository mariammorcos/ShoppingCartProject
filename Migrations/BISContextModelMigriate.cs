using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace ShoppingProject.Migrations
{
    [DbContext(typeof(Context))]
    partial class BISContextModelMigriate : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity("ShoppingProject.Models.Books", b =>
            {
                b.Property<int>("ProductID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("CategoryProduct");

                b.Property<string>("ProductName")
                    .IsRequired()
                    .HasMaxLength(50);

                b.Property<string>("ProductDescription")
                                .IsRequired();

                b.Property<decimal>("Price")
                                .HasColumnType("decimal(18,2)");

                b.HasKey("ProductID");

                b.ToTable("Products");
            });
        }
    }
}
