﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Facebook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edittableLikesN2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isLiked",
                table: "Likes",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isLiked",
                table: "Likes");
        }
    }
}
