using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace dotnetT.Migrations
{
    public partial class initialMigraations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.Sql("INSERT INTO Employees (Name, Age) VALUES ('Emp 1', 24)");
            // migrationBuilder.Sql("INSERT INTO Employees (Name,Age) VALUES ('Emp 2', 28)");
            // migrationBuilder.Sql("INSERT INTO Employees (Name,Age) VALUES ('Emp 3', 30)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.Sql("DELETE FROM Employees");
        }
    }
}
