﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSM_SOAP_REST_SVC.Models;

namespace SSM_SOAP_REST_SVC.Migrations
{
    [DbContext(typeof(SSM_SOAP_REST_SVCContext))]
    partial class SSM_SOAP_REST_SVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SSM_SOAP_REST_SVC.Model.Ticket", b =>
                {
                    b.Property<Guid>("TicketID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CRMID");

                    b.Property<string>("CustomerFirstName");

                    b.Property<string>("CustomerLastName");

                    b.Property<string>("CustomerMailID");

                    b.Property<string>("Description");

                    b.Property<string>("IncidentNumber");

                    b.Property<string>("IncidentStatus");

                    b.Property<string>("SSMSPOC");

                    b.Property<string>("ServiceType");

                    b.Property<string>("Severity");

                    b.HasKey("TicketID");

                    b.ToTable("Ticket");
                });
#pragma warning restore 612, 618
        }
    }
}