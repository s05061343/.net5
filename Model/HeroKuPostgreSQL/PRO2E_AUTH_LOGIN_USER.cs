﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Model.HeroKuPostgreSQL
{
    public partial class PRO2E_AUTH_LOGIN_USER
    {
        public PRO2E_AUTH_LOGIN_USER()
        {

        }
        [Key]
        public string UserId { get; set; }
        public int Version { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Comment { get; set; }
        public DateTime? CreateDate { get; set; }
        public string FullNameInChinese { get; set; }
        public string FullNameInEnglish { get; set; }
        public string Sex { get; set; }
        public string ContactAddress { get; set; }
        public string ContactZipCode { get; set; }
        public string HousePhoneAreaCode { get; set; }
        public string HousePhone { get; set; }
        public string HouseOtherPhone { get; set; }
        public string Email { get; set; }
        public string SSID { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public string Blood { get; set; }
        public string JobTitle { get; set; }
        public string Mobile { get; set; }
        public DateTime? ArrivedDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string EmergencyContactPerson { get; set; }
        public string EmergencyRelationship { get; set; }
        public string EmergencyPhone { get; set; }
        public string EmergencyAddress { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? IsAlive { get; set; }
        public int? IsLogin { get; set; }
        public string DisplayOrder { get; set; }
        public int? SecurityLevel { get; set; }
        public int? IsCheckIP { get; set; }
        public string AssignBranchNo { get; set; }
        public DateTime? InvaildDate { get; set; }
        public int? JobTitleId { get; set; }
        public int? JobLevelId { get; set; }
        public int? IdTypeId { get; set; }
        public int Is_MoreThan183Days { get; set; }
        public int? IncomeCountryId { get; set; }
        public int? TaxAgreementId { get; set; }
        public int Is_Married { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? EducationId { get; set; }
        public string School { get; set; }
        public string Specialty { get; set; }
        public string Fax { get; set; }
        public int? Is_ClockIn { get; set; }
        public string CardNo { get; set; }
        public decimal? WorkingHourPerDay { get; set; }
        public int? EmployeeTypeId { get; set; }
        public DateTime? LeaveWithoutPayDate { get; set; }
        public string CustomedField1 { get; set; }
        public string CustomedField2 { get; set; }
        public DateTime? HealthCheckupDate { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string StandardNo { get; set; }
        public string PassportNo { get; set; }
        public int? Is_Foreign { get; set; }
        public int? SubsidyId { get; set; }
        public int? InsuranceIdentityId { get; set; }
        public string HCSpecialIdentity { get; set; }
        public string LISpecialIdentity { get; set; }
        public string LaborRetireSpecialIdentity { get; set; }
        public string LINo { get; set; }
        public string HCNo { get; set; }
        public string HCNoWithholding { get; set; }
        public int? Is_PayRemittanceFee { get; set; }
        public int? En_EDINotification { get; set; }
        public int? DepartmentId { get; set; }
        public int? SalaryDepartmentId { get; set; }
        public int? p_SalarySubject { get; set; }
        public string EnglishJobTitle { get; set; }
        public int? p_SalaryPayMethod { get; set; }
        public int? p_SalaryCaculateMethod { get; set; }
        public int? BasicSalary { get; set; }
        public int? p_TaxType { get; set; }
        public decimal? TaxRate { get; set; }
        public int? LastEmployerContribution { get; set; }
        public int? LastWorkerContribution { get; set; }
        public int? Is_PaySalary { get; set; }
        public int? Is_AttendanceBonus { get; set; }
        public int? AttendanceBonus { get; set; }
        public int? Is_MealAllowance { get; set; }
        public int? MealAllowance { get; set; }
        public int? Is_OverTimePay { get; set; }
        public int? OverTimePayId { get; set; }
        public int? Is_Welfare { get; set; }
        public decimal? WelfareRate { get; set; }
        public int? p_EmployeeStatus { get; set; }
        public string DeputyId { get; set; }
        public string Pic { get; set; }
        public DateTime? NextAnnualLeaveAddingDate { get; set; }
        public int? p_HourPayBase { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Is_ReceiveFlowNotify { get; set; }
        public int InitOutDays { get; set; }
        public string SalaryBranchNo { get; set; }
        public DateTime? ArrivedDateForPrint { get; set; }
        public string PhysicianSpecialist { get; set; }
        public string PhysicianCertificate { get; set; }
        public int PersonalAnnualLeaveType { get; set; }
        public string Signature { get; set; }
        public string DrLicNo { get; set; }
        public string DrLicDrugNo { get; set; }
        public string DrLicExclusiveNo { get; set; }
        public string EducationDepartment { get; set; }
        public string EducationStart { get; set; }
        public string EducationEnd { get; set; }
        public int? EducationId2 { get; set; }
        public string EducationSchool2 { get; set; }
        public string EducationDepartment2 { get; set; }
        public string EducationStart2 { get; set; }
        public string EducationEnd2 { get; set; }
        public string ExperienceCompany1 { get; set; }
        public string ExperienceTitle1 { get; set; }
        public string ExperienceContent1 { get; set; }
        public string ExperienceStart1 { get; set; }
        public string ExperienceEnd1 { get; set; }
        public string ExperienceCompany2 { get; set; }
        public string ExperienceTitle2 { get; set; }
        public string ExperienceContent2 { get; set; }
        public string ExperienceStart2 { get; set; }
        public string ExperienceEnd2 { get; set; }
        public string ExperienceCompany3 { get; set; }
        public string ExperienceTitle3 { get; set; }
        public string ExperienceContent3 { get; set; }
        public string ExperienceStart3 { get; set; }
        public string ExperienceEnd3 { get; set; }
        public string LicenseName1 { get; set; }
        public string LicenseNo1 { get; set; }
        public string LicenseName2 { get; set; }
        public string LicenseNo2 { get; set; }
        public string LicenseName3 { get; set; }
        public string LicenseNo3 { get; set; }
        public int DependentsCount { get; set; }
        public int InsuranceAmount { get; set; }
        public int Is_ElasticalHour { get; set; }

    }
}
