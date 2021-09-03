using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_MedicalRecordValue
    {
        public int MedicalRecordValueNo { get; set; }
        public int MedicalRecordNo { get; set; }
        public int? BelongToMember { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string ByDr { get; set; }
        public string ByFollower { get; set; }
        public string ByNurse { get; set; }
        public int? RecordFlag { get; set; }
        public int? RecordStatus { get; set; }
        public int MedicalRecordFormNo { get; set; }
        public string Title { get; set; }
        public int? RecordDisplay { get; set; }
        public int? FormFlag { get; set; }
        public int MedicalRecordGroupNo { get; set; }
        public int? BelongToGroupBy { get; set; }
        public string GroupByName { get; set; }
        public int? GroupFlag { get; set; }
        public int MedicalRecordColumnNo { get; set; }
        public string ColumnId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public string DefaultValue { get; set; }
        public int? ColumnOrderBy { get; set; }
        public int? ColumnFlag { get; set; }
        public int? BelongToRecord { get; set; }
        public int? BelongToColumn { get; set; }
        public string ItemValue { get; set; }
        public string ItemColumn { get; set; }
        public string ItemRow { get; set; }
        public string FullName { get; set; }
        public string UpdateByName { get; set; }
        public string ByDrName { get; set; }
        public string ByFollowerName { get; set; }
        public string ByNurseName { get; set; }
        public string BelongToBranch { get; set; }
        public string BranchName { get; set; }
        public int? RelativeCount { get; set; }
    }
}
