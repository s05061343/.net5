using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_flDocField
    {
        public int Id { get; set; }
        public int DocRowId { get; set; }
        public string Title { get; set; }
        public int En_Type { get; set; }
        public string Is_Enable { get; set; }
        public string Is_Deleted { get; set; }
        public int Heigh { get; set; }
        public int? ParameterType_Id { get; set; }
        public string Options { get; set; }
        public int En_DataType { get; set; }
        public int? RowSeq { get; set; }
        public string Is_RowDeleted { get; set; }
        public int? En_RowType { get; set; }
        public int? DocTypeId { get; set; }
        public string DocTypeName { get; set; }
        public string ParameterType_Name { get; set; }
        public string TypeName { get; set; }
        public string DataTypeName { get; set; }
    }
}
