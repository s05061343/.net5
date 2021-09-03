using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Member
    {
        public SaintEir_Member()
        {
            SaintEir_CallHistories = new HashSet<SaintEir_CallHistory>();
            SaintEir_InProcessServices = new HashSet<SaintEir_InProcessService>();
            WhereToGetInfoOtherLists = new HashSet<WhereToGetInfoOtherList>();
        }

        public int MemberNo { get; set; }
        public string AnamnesisNo { get; set; }
        public decimal? PrePayMoney { get; set; }
        public string FullName { get; set; }
        public decimal? RemainCredit { get; set; }
        public string SSID { get; set; }
        public string Birthday { get; set; }
        public string Sex { get; set; }
        public string Marriage { get; set; }
        public string ChildBoys { get; set; }
        public string ChildGirls { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BloodType { get; set; }
        public string Attendant { get; set; }
        public string Attendant2 { get; set; }
        public string History { get; set; }
        public string Hypersensitive { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string Tel_O_AreaCode { get; set; }
        public string Tel_O_Number { get; set; }
        public string Tel_H_AreaCode { get; set; }
        public string Tel_H_Number { get; set; }
        public string Mobile_1 { get; set; }
        public string Mobile_2 { get; set; }
        public string JobType { get; set; }
        public string CallTime { get; set; }
        public string MedicalHistory { get; set; }
        public string Skin { get; set; }
        public string Spot { get; set; }
        public string WhereToGetInfo { get; set; }
        public string CureHistory { get; set; }
        public string Introducer { get; set; }
        public string Transportation { get; set; }
        public string Note { get; set; }
        public string ExpectImporvedItemsFacial { get; set; }
        public string ExpectImporvedItemsBody { get; set; }
        public string BelongToBranch { get; set; }
        public string IsConfirmAccount { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? IsEmployee { get; set; }
        public int? IsSms { get; set; }
        public int? IsPhone { get; set; }
        public int? IsEmail { get; set; }
        public string Constellation { get; set; }
        public int? currentAge { get; set; }
        public string IskuvaEmployee { get; set; }
        public string KuvaMemberID { get; set; }
        public string KVNumber { get; set; }
        public string SkinType { get; set; }
        public string Pigment { get; set; }
        public string Freckles { get; set; }
        public string Pimples { get; set; }
        public string Wrinkle { get; set; }
        public string Acne { get; set; }
        public string Scar { get; set; }
        public string Cellulite { get; set; }
        public string Bud { get; set; }
        public string Allergy { get; set; }
        public string OtherReason { get; set; }
        public string MaintainShopName { get; set; }
        public string MaintainProductName { get; set; }
        public string MaintainProgramName { get; set; }
        public string MaintainDailyProductName { get; set; }
        public string MaintainChangeReason { get; set; }
        public string IsPurposeToDr { get; set; }
        public string DoctorType { get; set; }
        public string ConsultSuggestion { get; set; }
        public string NervousSystem { get; set; }
        public string RespiratorySystem { get; set; }
        public string CirculatorySystem { get; set; }
        public string ReproductionSystem { get; set; }
        public string DigestiveSystem { get; set; }
        public string MuscleSystem { get; set; }
        public string UrinarySystem { get; set; }
        public string ImmuneSystem { get; set; }
        public string FaceAnalysis { get; set; }
        public string MassageLevel { get; set; }
        public string MemberLevel { get; set; }
        public string BelongToGroup { get; set; }
        public string IsCompleted { get; set; }
        public string MemberType { get; set; }
        public int? IsVIP { get; set; }
        public string CardNum { get; set; }
        public string Income { get; set; }
        public string MaintainHabit { get; set; }
        public string ExpectImporvedItems { get; set; }
        public string Education { get; set; }
        public int? ParentId { get; set; }
        public int? AttendantCheck { get; set; }
        public int? AttendantCheck2 { get; set; }
        public string FSSID { get; set; }
        public string FamilyHistory { get; set; }
        public string Surgery { get; set; }
        public string HyaluronanBrand { get; set; }
        public string LiposuctionSite { get; set; }
        public string SelfFatLipFaceCreamSite { get; set; }
        public string AdverseReactions { get; set; }
        public string CustomerHabit { get; set; }
        public string Country { get; set; }
        public string LineID { get; set; }
        public string WeChatID { get; set; }
        public string ConsultOther { get; set; }
        public string CureHistoryOther { get; set; }
        public string LanguageCode { get; set; }

        public virtual ICollection<SaintEir_CallHistory> SaintEir_CallHistories { get; set; }
        public virtual ICollection<SaintEir_InProcessService> SaintEir_InProcessServices { get; set; }
        public virtual ICollection<WhereToGetInfoOtherList> WhereToGetInfoOtherLists { get; set; }
    }
}
