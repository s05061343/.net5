using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_TakeOffApplicationAttachement
    {
        public int Id { get; set; }
        public int MainId { get; set; }
        public DateTime CreateDate { get; set; }
        public string OriginalFileName { get; set; }
        public string StoreFileName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CeratorUserId { get; set; }
        public string RemoverUserId { get; set; }
    }
}
