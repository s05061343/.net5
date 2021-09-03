using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Achievement
    {
        public int AchievementNo { get; set; }
        public DateTime? AchieveDate { get; set; }
        public string ProductNo { get; set; }
        public int? Quantity { get; set; }
        public string BelongToBranch { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UserId { get; set; }
        public int? ReservationNo { get; set; }

        public virtual SaintEir_Reservation ReservationNoNavigation { get; set; }
        public virtual PRO2E_AUTH_LOGIN_USER User { get; set; }
    }
}
