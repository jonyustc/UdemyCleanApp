using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BM_SecUser
    {
        public decimal BM_UserID { get; set; }

        public string UserName { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string MobileNo { get; set; }

        public string Address { get; set; }

        public int? HR_DeptID { get; set; }

        public int? HR_DesgID { get; set; }

        public bool? LoanAdvanceStart { get; set; }

        public bool? LoanAdvanceFinalized { get; set; }

        public string LogUserID { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public bool? Inactive { get; set; }

        public int? BM_BranchID { get; set; }

        public byte? Flag { get; set; }

        public string PunchCardNo { get; set; }

        public int? Sex_BM_ItemID { get; set; }

        public int? Relegion_BM_ItemID { get; set; }

        public int? Priority { get; set; }

        public string Email { get; set; }

        public string EmailPassword { get; set; }

        public string EmailForward { get; set; }

        public string IP { get; set; }

        public string MACAddress { get; set; }

        public string SignaturePath { get; set; }

        public DateTime? EmailCreateDate { get; set; }

        public DateTime? EmailDeleteDate { get; set; }

        public decimal? HR_EmployeeID { get; set; }

        public int? PasswordVerified { get; set; }

        public int? AcceptPolicy { get; set; }

        public int? AcceptERPAgreement { get; set; }

        public int? FailedAttempts { get; set; }

        public DateTime? FailedAttemptsTime { get; set; }
        //public decimal AppUserId { get; set; }
        //public AppUser AppUser { get; set; }

    }
}
