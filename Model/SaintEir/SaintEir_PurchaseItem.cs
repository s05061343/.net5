using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_PurchaseItem
    {
        public SaintEir_PurchaseItem()
        {
            MedicalRecordRelatives = new HashSet<MedicalRecordRelative>();
            SaintEir_PurchaseItemStatuses = new HashSet<SaintEir_PurchaseItemStatus>();
            SaintEir_SignDocRelatives = new HashSet<SaintEir_SignDocRelative>();
        }

        public int PurchaseItemNo { get; set; }
        public int? BelongToPurchase { get; set; }
        public int? PurchaseProduct { get; set; }
        public int? PurchasePackage { get; set; }
        public int? Quantity { get; set; }
        public double? DiscountPercentage { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? ItemFee { get; set; }
        public decimal? SoldOutPrice { get; set; }
        public int? IsForFree { get; set; }
        public int? PurchaseItemType { get; set; }
        public int? BelongToCategory { get; set; }
        public decimal? SellPrice { get; set; }

        public virtual SaintEir_Purchase BelongToPurchaseNavigation { get; set; }
        public virtual ICollection<MedicalRecordRelative> MedicalRecordRelatives { get; set; }
        public virtual ICollection<SaintEir_PurchaseItemStatus> SaintEir_PurchaseItemStatuses { get; set; }
        public virtual ICollection<SaintEir_SignDocRelative> SaintEir_SignDocRelatives { get; set; }
    }
}
