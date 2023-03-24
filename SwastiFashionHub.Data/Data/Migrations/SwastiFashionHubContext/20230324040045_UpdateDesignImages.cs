﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwastiFashionHub.Data.Data.Migrations.SwastiFashionHubContext
{
    /// <inheritdoc />
    public partial class UpdateDesignImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DesignImages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DesignImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DesignId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DesignImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignImages_Designs_DesignId",
                        column: x => x.DesignId,
                        principalTable: "Designs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DesignImages_DesignId",
                table: "DesignImages",
                column: "DesignId");
        }
    }
}