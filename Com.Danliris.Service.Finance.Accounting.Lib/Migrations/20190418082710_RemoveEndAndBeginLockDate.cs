﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Danliris.Service.Finance.Accounting.Lib.Migrations
{
    public partial class RemoveEndAndBeginLockDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeginLockDate",
                table: "LockTransactions");

            migrationBuilder.RenameColumn(
                name: "EndLockDate",
                table: "LockTransactions",
                newName: "LockDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LockDate",
                table: "LockTransactions",
                newName: "EndLockDate");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "BeginLockDate",
                table: "LockTransactions",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
