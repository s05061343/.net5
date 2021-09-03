using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_AppToken
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Token { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
