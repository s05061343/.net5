using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Favorite
    {
        public int FavoriteId { get; set; }
        public string UserId { get; set; }
        public int? MenuFuncId { get; set; }
    }
}
