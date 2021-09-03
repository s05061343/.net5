using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AppPushHistory
    {
        public int AppPushHistoryNo { get; set; }
        public string DeviceToken { get; set; }
        public int? BelongToMember { get; set; }
        public int? BelongToSample { get; set; }
        public int? PushType { get; set; }
        public string OSType { get; set; }
        public string PushTitle { get; set; }
        public string PushContent { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticlePic { get; set; }
        public string ArticleContent { get; set; }
        public DateTime? PushTime { get; set; }
        public int? IsPush { get; set; }
        public DateTime? PushStartDate { get; set; }
        public DateTime? PushEndDate { get; set; }
        public int? IsReadByPush { get; set; }
        public DateTime? ReadTime { get; set; }
        public int? PushCategory { get; set; }
        public int? IsPushSuccess { get; set; }
        public string PushResponse { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
