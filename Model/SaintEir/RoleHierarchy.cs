using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class RoleHierarchy
    {
        public int Id { get; set; }
        public int? SuperiorRole { get; set; }
        public int? InferiorRole { get; set; }
        public string Keyword { get; set; }
        public int? MenuFunc { get; set; }
    }
}
