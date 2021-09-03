using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_BodyMeasurement
    {
        public int BodyMeasurementNo { get; set; }
        public int? BelongToMember { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public decimal? BodyFat { get; set; }
        public int? BodyAge { get; set; }
        public decimal? BMI { get; set; }
        public int? RM { get; set; }
        public decimal? VFat { get; set; }
        public decimal? SFatBody { get; set; }
        public decimal? SFatTrunk { get; set; }
        public decimal? SFatLegs { get; set; }
        public decimal? SFatArms { get; set; }
        public decimal? MuscleBody { get; set; }
        public decimal? MuscleTrunk { get; set; }
        public decimal? MuscleLegs { get; set; }
        public decimal? MuscleArms { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
