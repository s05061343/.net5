using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_flSkipedDocument
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int DocumentId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
