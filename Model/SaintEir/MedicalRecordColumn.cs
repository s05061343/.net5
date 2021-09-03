using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class MedicalRecordColumn
    {
        public int MedicalRecordColumnNo { get; set; }
        public int? BelongToForm { get; set; }
        public string ColumnId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public int? OrderBy { get; set; }
        public int? GroupBy { get; set; }
        public string DefaultValue { get; set; }
        public int? Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int ColumnWidth { get; set; }
        public int ColumnHeight { get; set; }
        public int ColumnX { get; set; }
        public int ColumnY { get; set; }
        public string ColumnPlaceholder { get; set; }
        public string ColumnNote { get; set; }
        public int? SubGroupBy { get; set; }
    }
}
