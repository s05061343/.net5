using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class CourseAuth
    {
        public int CourseAuthNo { get; set; }
        public int? BelongToRole { get; set; }
        public int? BelongToCourse { get; set; }
    }
}
