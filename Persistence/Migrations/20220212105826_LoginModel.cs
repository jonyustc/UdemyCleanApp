using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class LoginModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "BM_SecUser",
            //    columns: table => new
            //    {
            //        BM_UserID = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        HR_DeptID = table.Column<int>(type: "int", nullable: true),
            //        HR_DesgID = table.Column<int>(type: "int", nullable: true),
            //        LoanAdvanceStart = table.Column<bool>(type: "bit", nullable: true),
            //        LoanAdvanceFinalized = table.Column<bool>(type: "bit", nullable: true),
            //        LogUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        Inactive = table.Column<bool>(type: "bit", nullable: true),
            //        BM_BranchID = table.Column<int>(type: "int", nullable: true),
            //        Flag = table.Column<byte>(type: "tinyint", nullable: true),
            //        PunchCardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Sex_BM_ItemID = table.Column<int>(type: "int", nullable: true),
            //        Relegion_BM_ItemID = table.Column<int>(type: "int", nullable: true),
            //        Priority = table.Column<int>(type: "int", nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmailPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmailForward = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        MACAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        SignaturePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmailCreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        EmailDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        HR_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        PasswordVerified = table.Column<int>(type: "int", nullable: true),
            //        AcceptPolicy = table.Column<int>(type: "int", nullable: true),
            //        AcceptERPAgreement = table.Column<int>(type: "int", nullable: true),
            //        FailedAttempts = table.Column<int>(type: "int", nullable: true),
            //        FailedAttemptsTime = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BM_SecUser", x => x.BM_UserID);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BM_SecUser");
        }
    }
}
