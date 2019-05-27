using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSM_SOAP_REST_SVC.Migrations
{
    public partial class Enable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketID = table.Column<Guid>(nullable: false),
                    IncidentNumber = table.Column<string>(nullable: true),
                    ServiceType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Severity = table.Column<string>(nullable: true),
                    CustomerFirstName = table.Column<string>(nullable: true),
                    CustomerLastName = table.Column<string>(nullable: true),
                    CustomerMailID = table.Column<string>(nullable: true),
                    IncidentStatus = table.Column<string>(nullable: true),
                    CRMID = table.Column<string>(nullable: true),
                    SSMSPOC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
