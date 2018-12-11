using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace ShoppingProject.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20181207182543_InitialMigration")]
    partial class InitialMigration
    {           
            protected override void BuildTargetModel(ModelBuilder modelBuilder)
            {
#pragma warning disable 612, 618
                modelBuilder
                    .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                    .HasAnnotation("Relational:MaxIdentifierLength", 128)
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
                                
                modelBuilder.Entity("ShoppingProject.Models.Books", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookID");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("BookDescription")
                        .IsRequired();

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BookID");

                    b.HasIndex("DescriptionID");

                    b.ToTable("Books");
                });                         
#pragma warning restore 502, 808
            }
        }
    }


