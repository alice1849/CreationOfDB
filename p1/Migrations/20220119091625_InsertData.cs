using Microsoft.EntityFrameworkCore.Migrations;
using System;
#nullable disable

namespace HomeWork1.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Client",
                columns: new string[] { "ClientId", "FirstName", "LastName" },
                values: new object[] { 1, "Ferenc", "Liszt" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new string[] { "ClientId", "FirstName", "LastName" },
                values: new object[] { 2, "Frederic", "Chopin" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new string[] { "ClientId", "FirstName", "LastName" },
                values: new object[] { 3, "Franz", "Shubert" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new string[] { "ClientId", "FirstName", "LastName" },
                values: new object[] { 4, "Ludwig", "Beethoven" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new string[] { "ClientId", "FirstName", "LastName" },
                values: new object[] { 5, "Felix", "Mendelssohn" });

            migrationBuilder.InsertData(
               table: "Project",
               columns: new string[] { "Name", "Budget", "StartedDate", "ClientId" },
               values: new object[] { "Project1", 100, new DateTime(2020, 3, 2), 1 });

            migrationBuilder.InsertData(
               table: "Project",
               columns: new string[] { "Name", "Budget", "StartedDate", "ClientId" },
               values: new object[] { "Project2", 200, new DateTime(2020, 3, 2), 2});

        migrationBuilder.InsertData(
           table: "Project",
               columns: new string[] { "Name", "Budget", "StartedDate", "ClientId" },
               values: new object[] { "Project3", 300, new DateTime(2020, 3, 2 ), 3});

            migrationBuilder.InsertData(
               table: "Project",
               columns: new string[] { "Name", "Budget", "StartedDate", "ClientId" },
               values: new object[] { "Project4", 400, new DateTime(2020, 3, 2), 4 });

            migrationBuilder.InsertData(
               table: "Project",
               columns: new string[] { "Name", "Budget", "StartedDate", "ClientId" },
               values: new object[] { "Project5", 500, new DateTime(2020, 3, 2), 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Client", true);

            migrationBuilder.Sql("DELETE FROM Project", true);
        }
    }
}

