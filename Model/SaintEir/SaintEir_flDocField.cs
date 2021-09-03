using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_flDocField
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
        public string ParameterType_Name { get; set; }
    }
}
