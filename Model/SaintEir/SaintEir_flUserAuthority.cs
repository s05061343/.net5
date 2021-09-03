using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_flUserAuthority
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int DocTypeId { get; set; }
        public int Is_ReadDepartment { get; set; }
        public int Is_ReadAll { get; set; }
        public int Is_UpdateDepartment { get; set; }
        public int Is_UpdateAll { get; set; }
        public int Is_AllPass { get; set; }
        public int Is_ReadSelf { get; set; }
        public int Is_UpdateSelf { get; set; }
    }
}
