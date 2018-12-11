using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingProject.Migrations
{
   
        public partial class InitialMigration : Migration
        {
            protected override void Up(MigrationBuilder migrationBuilder)
            {

                migrationBuilder.CreateTable(
                    name: "Books",
                    columns: table => new
                    {
                        BookID = table.Column<int>(nullable: false)
                            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                        BookName = table.Column<string>(maxLength: 50, nullable: false),
                        BookDescription = table.Column<string>(nullable: false),
                        Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                        BookCategory = table.Column<int>(nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Courses", x => x.BookID);
                        table.ForeignKey(
                            name: "FK_Courses_Categories_CategoryId",
                            column: x => x.BookCategory,
                            principalTable: "Categories",
                            principalColumn: "CategoryId",
                            onDelete: ReferentialAction.Cascade);
                    });

            }

            protected override void Down(MigrationBuilder migrationBuilder)
            {

                migrationBuilder.DropTable(
                    name: "Books");    
                
            }
        }
    }

