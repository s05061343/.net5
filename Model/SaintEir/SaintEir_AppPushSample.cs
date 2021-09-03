using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AppPushSample
    {
        public int AppPushSampleNo { get; set; }
        public int? PushType { get; set; }
        public string PushTitle { get; set; }
        public string PushContent { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticlePic { get; set; }
        public string ArticleContent { get; set; }
        public DateTime? PushTime { get; set; }
        public DateTime? PushStartDate { get; set; }
        public DateTime? PushEndDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? PushCategory { get; set; }
    }
}
