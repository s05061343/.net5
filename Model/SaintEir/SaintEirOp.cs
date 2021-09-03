using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEirOp : DbContext
    {
        public SaintEirOp()
        {
        }

        public SaintEirOp(DbContextOptions<SaintEirOp> options)
            : base(options)
        {
        }

        public virtual DbSet<BelongToCategory> BelongToCategories { get; set; }
        public virtual DbSet<Consent> Consents { get; set; }
        public virtual DbSet<ConsentSet> ConsentSets { get; set; }
        public virtual DbSet<ControlsDefault> ControlsDefaults { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseAuth> CourseAuths { get; set; }
        public virtual DbSet<CourseCategory> CourseCategories { get; set; }
        public virtual DbSet<CourseMaterial> CourseMaterials { get; set; }
        public virtual DbSet<CourseMaterialRecord> CourseMaterialRecords { get; set; }
        public virtual DbSet<CourseRecord> CourseRecords { get; set; }
        public virtual DbSet<CourseResult> CourseResults { get; set; }
        public virtual DbSet<CurePurpose> CurePurposes { get; set; }
        public virtual DbSet<DailyDealBranch> DailyDealBranches { get; set; }
        public virtual DbSet<DailyDealUser> DailyDealUsers { get; set; }
        public virtual DbSet<DailyDealUserCategory> DailyDealUserCategories { get; set; }
        public virtual DbSet<DailyOperationStatic> DailyOperationStatics { get; set; }
        public virtual DbSet<DrFlotationCost> DrFlotationCosts { get; set; }
        public virtual DbSet<IOBARAPTitleMapping> IOBARAPTitleMappings { get; set; }
        public virtual DbSet<IOBTitleMapping> IOBTitleMappings { get; set; }
        public virtual DbSet<MTagInMember> MTagInMembers { get; set; }
        public virtual DbSet<MedicalFormTag> MedicalFormTags { get; set; }
        public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }
        public virtual DbSet<MedicalRecordColumn> MedicalRecordColumns { get; set; }
        public virtual DbSet<MedicalRecordColumnItem> MedicalRecordColumnItems { get; set; }
        public virtual DbSet<MedicalRecordForm> MedicalRecordForms { get; set; }
        public virtual DbSet<MedicalRecordFormSet> MedicalRecordFormSets { get; set; }
        public virtual DbSet<MedicalRecordGroup> MedicalRecordGroups { get; set; }
        public virtual DbSet<MedicalRecordRelative> MedicalRecordRelatives { get; set; }
        public virtual DbSet<MedicalRecordValue> MedicalRecordValues { get; set; }
        public virtual DbSet<MemberAlbum> MemberAlbums { get; set; }
        public virtual DbSet<MemberAlbumAttribute> MemberAlbumAttributes { get; set; }
        public virtual DbSet<MemberAlbumCategory> MemberAlbumCategories { get; set; }
        public virtual DbSet<MemberAlbumItem> MemberAlbumItems { get; set; }
        public virtual DbSet<MemberAlbumMask> MemberAlbumMasks { get; set; }
        public virtual DbSet<MemberTag> MemberTags { get; set; }
        public virtual DbSet<MemberWhereToGetInfo> MemberWhereToGetInfos { get; set; }
        public virtual DbSet<PRO2E_AUTH_FUNCTION_PATH> PRO2E_AUTH_FUNCTION_PATHs { get; set; }
        public virtual DbSet<PRO2E_AUTH_FUNC_OPT> PRO2E_AUTH_FUNC_OPTs { get; set; }
        public virtual DbSet<PRO2E_AUTH_LOGIN_ROLE> PRO2E_AUTH_LOGIN_ROLEs { get; set; }
        public virtual DbSet<PRO2E_AUTH_LOGIN_USER> PRO2E_AUTH_LOGIN_USERs { get; set; }
        public virtual DbSet<PRO2E_AUTH_MENU_FUNC> PRO2E_AUTH_MENU_FUNCs { get; set; }
        public virtual DbSet<PRO2E_AUTH_OPRT_ACTION> PRO2E_AUTH_OPRT_ACTIONs { get; set; }
        public virtual DbSet<PRO2E_AUTH_ROLE_FUNC> PRO2E_AUTH_ROLE_FUNCs { get; set; }
        public virtual DbSet<PRO2E_AUTH_USER_IN_ROLE> PRO2E_AUTH_USER_IN_ROLEs { get; set; }
        public virtual DbSet<PRO2E_AUTH_USER_PROFILE> PRO2E_AUTH_USER_PROFILEs { get; set; }
        public virtual DbSet<PRO2E_IP_ADDRESSBOOK> PRO2E_IP_ADDRESSBOOKs { get; set; }
        public virtual DbSet<PRO2E_LOG_SYSTEM> PRO2E_LOG_SYSTEMs { get; set; }
        public virtual DbSet<PRO2E_SYSTEM_ITEM_PARAM> PRO2E_SYSTEM_ITEM_PARAMs { get; set; }
        public virtual DbSet<PRO2E_SYSTEM_SYSTEM_PARAM> PRO2E_SYSTEM_SYSTEM_PARAMs { get; set; }
        public virtual DbSet<PhysicalInventory> PhysicalInventories { get; set; }
        public virtual DbSet<PhysicalInventoryItem> PhysicalInventoryItems { get; set; }
        public virtual DbSet<ProductInCCategory> ProductInCCategories { get; set; }
        public virtual DbSet<ProductInSm> ProductInSms { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptItem> ReceiptItems { get; set; }
        public virtual DbSet<RegularVoucher> RegularVouchers { get; set; }
        public virtual DbSet<RegularVoucherItem> RegularVoucherItems { get; set; }
        public virtual DbSet<RoleHierarchy> RoleHierarchies { get; set; }
        public virtual DbSet<SEAP_Certificate> SEAP_Certificates { get; set; }
        public virtual DbSet<SEAP_UserLogin> SEAP_UserLogins { get; set; }
        public virtual DbSet<SaintEir_AccountAssign> SaintEir_AccountAssigns { get; set; }
        public virtual DbSet<SaintEir_AccountBalance> SaintEir_AccountBalances { get; set; }
        public virtual DbSet<SaintEir_AccountBalanceOut> SaintEir_AccountBalanceOuts { get; set; }
        public virtual DbSet<SaintEir_AccountClassify> SaintEir_AccountClassifies { get; set; }
        public virtual DbSet<SaintEir_AccountInWithOut> SaintEir_AccountInWithOuts { get; set; }
        public virtual DbSet<SaintEir_AccountMonetary> SaintEir_AccountMonetaries { get; set; }
        public virtual DbSet<SaintEir_AccountTitleBalance> SaintEir_AccountTitleBalances { get; set; }
        public virtual DbSet<SaintEir_AccountingTitle> SaintEir_AccountingTitles { get; set; }
        public virtual DbSet<SaintEir_Achievement> SaintEir_Achievements { get; set; }
        public virtual DbSet<SaintEir_AchievementDistribution> SaintEir_AchievementDistributions { get; set; }
        public virtual DbSet<SaintEir_AchievementTarget> SaintEir_AchievementTargets { get; set; }
        public virtual DbSet<SaintEir_ActivityGood> SaintEir_ActivityGoods { get; set; }
        public virtual DbSet<SaintEir_ActivityList> SaintEir_ActivityLists { get; set; }
        public virtual DbSet<SaintEir_ActivityMember> SaintEir_ActivityMembers { get; set; }
        public virtual DbSet<SaintEir_AdditionalLeave> SaintEir_AdditionalLeaves { get; set; }
        public virtual DbSet<SaintEir_AdditionalLeaveUsageLog> SaintEir_AdditionalLeaveUsageLogs { get; set; }
        public virtual DbSet<SaintEir_AdvisoryEvent> SaintEir_AdvisoryEvents { get; set; }
        public virtual DbSet<SaintEir_AdvisoryHistory> SaintEir_AdvisoryHistories { get; set; }
        public virtual DbSet<SaintEir_AppBlackList> SaintEir_AppBlackLists { get; set; }
        public virtual DbSet<SaintEir_AppInResCategoryVO> SaintEir_AppInResCategoryVOs { get; set; }
        public virtual DbSet<SaintEir_AppPushHistory> SaintEir_AppPushHistories { get; set; }
        public virtual DbSet<SaintEir_AppPushSample> SaintEir_AppPushSamples { get; set; }
        public virtual DbSet<SaintEir_AppReservation> SaintEir_AppReservations { get; set; }
        public virtual DbSet<SaintEir_AppRule> SaintEir_AppRules { get; set; }
        public virtual DbSet<SaintEir_AppToken> SaintEir_AppTokens { get; set; }
        public virtual DbSet<SaintEir_ApproveHistory> SaintEir_ApproveHistories { get; set; }
        public virtual DbSet<SaintEir_AttendanceRecord> SaintEir_AttendanceRecords { get; set; }
        public virtual DbSet<SaintEir_AttendanceRecord_20210805> SaintEir_AttendanceRecord_20210805s { get; set; }
        public virtual DbSet<SaintEir_AttendantFaultRecord> SaintEir_AttendantFaultRecords { get; set; }
        public virtual DbSet<SaintEir_AttendantFaultRecordAttachment> SaintEir_AttendantFaultRecordAttachments { get; set; }
        public virtual DbSet<SaintEir_AttendantFaultRule> SaintEir_AttendantFaultRules { get; set; }
        public virtual DbSet<SaintEir_AttendantFaultVersion> SaintEir_AttendantFaultVersions { get; set; }
        public virtual DbSet<SaintEir_BHClassify> SaintEir_BHClassifies { get; set; }
        public virtual DbSet<SaintEir_BHMaterial> SaintEir_BHMaterials { get; set; }
        public virtual DbSet<SaintEir_BHMaterialChangeLog> SaintEir_BHMaterialChangeLogs { get; set; }
        public virtual DbSet<SaintEir_BalanceSheet> SaintEir_BalanceSheets { get; set; }
        public virtual DbSet<SaintEir_BodyMeasurement> SaintEir_BodyMeasurements { get; set; }
        public virtual DbSet<SaintEir_Branch> SaintEir_Branches { get; set; }
        public virtual DbSet<SaintEir_BranchAchievement> SaintEir_BranchAchievements { get; set; }
        public virtual DbSet<SaintEir_BranchInCCategory> SaintEir_BranchInCCategories { get; set; }
        public virtual DbSet<SaintEir_BranchOrderSet> SaintEir_BranchOrderSets { get; set; }
        public virtual DbSet<SaintEir_Calendar> SaintEir_Calendars { get; set; }
        public virtual DbSet<SaintEir_CalendarDay> SaintEir_CalendarDays { get; set; }
        public virtual DbSet<SaintEir_CalendarDay_backup_KillAfter20220101> SaintEir_CalendarDay_backup_KillAfter20220101s { get; set; }
        public virtual DbSet<SaintEir_CallHistory> SaintEir_CallHistories { get; set; }
        public virtual DbSet<SaintEir_CashFlowClassify> SaintEir_CashFlowClassifies { get; set; }
        public virtual DbSet<SaintEir_CashFlowForecast> SaintEir_CashFlowForecasts { get; set; }
        public virtual DbSet<SaintEir_CashFlowMapping> SaintEir_CashFlowMappings { get; set; }
        public virtual DbSet<SaintEir_CashFlowStatement> SaintEir_CashFlowStatements { get; set; }
        public virtual DbSet<SaintEir_CashForecast> SaintEir_CashForecasts { get; set; }
        public virtual DbSet<SaintEir_CategoryMappingProduct> SaintEir_CategoryMappingProducts { get; set; }
        public virtual DbSet<SaintEir_CheckInOrder> SaintEir_CheckInOrders { get; set; }
        public virtual DbSet<SaintEir_City> SaintEir_Cities { get; set; }
        public virtual DbSet<SaintEir_Classify> SaintEir_Classifies { get; set; }
        public virtual DbSet<SaintEir_ClinicClassify> SaintEir_ClinicClassifies { get; set; }
        public virtual DbSet<SaintEir_ClockInRecord> SaintEir_ClockInRecords { get; set; }
        public virtual DbSet<SaintEir_ClockInRecordFormat> SaintEir_ClockInRecordFormats { get; set; }
        public virtual DbSet<SaintEir_CompetitionReward> SaintEir_CompetitionRewards { get; set; }
        public virtual DbSet<SaintEir_Compliant> SaintEir_Compliants { get; set; }
        public virtual DbSet<SaintEir_CompliantHistory> SaintEir_CompliantHistories { get; set; }
        public virtual DbSet<SaintEir_ComsumptionHistory> SaintEir_ComsumptionHistories { get; set; }
        public virtual DbSet<SaintEir_Config> SaintEir_Configs { get; set; }
        public virtual DbSet<SaintEir_ConfirmRelative> SaintEir_ConfirmRelatives { get; set; }
        public virtual DbSet<SaintEir_ConfirmRelativeItem> SaintEir_ConfirmRelativeItems { get; set; }
        public virtual DbSet<SaintEir_Consumable> SaintEir_Consumables { get; set; }
        public virtual DbSet<SaintEir_ConversionValue> SaintEir_ConversionValues { get; set; }
        public virtual DbSet<SaintEir_Country> SaintEir_Countries { get; set; }
        public virtual DbSet<SaintEir_Credit> SaintEir_Credits { get; set; }
        public virtual DbSet<SaintEir_CustomCategory> SaintEir_CustomCategories { get; set; }
        public virtual DbSet<SaintEir_DBSetting> SaintEir_DBSettings { get; set; }
        public virtual DbSet<SaintEir_DRConsultationFee> SaintEir_DRConsultationFees { get; set; }
        public virtual DbSet<SaintEir_DRConsultationFeeWeekDay> SaintEir_DRConsultationFeeWeekDays { get; set; }
        public virtual DbSet<SaintEir_DRReward> SaintEir_DRRewards { get; set; }
        public virtual DbSet<SaintEir_DRRewardDaily> SaintEir_DRRewardDailies { get; set; }
        public virtual DbSet<SaintEir_DRService> SaintEir_DRServices { get; set; }
        public virtual DbSet<SaintEir_DRServiceFee> SaintEir_DRServiceFees { get; set; }
        public virtual DbSet<SaintEir_DRServiceLog> SaintEir_DRServiceLogs { get; set; }
        public virtual DbSet<SaintEir_DailyBalance> SaintEir_DailyBalances { get; set; }
        public virtual DbSet<SaintEir_DailyBalanceItem> SaintEir_DailyBalanceItems { get; set; }
        public virtual DbSet<SaintEir_Declare> SaintEir_Declares { get; set; }
        public virtual DbSet<SaintEir_DeclareFile> SaintEir_DeclareFiles { get; set; }
        public virtual DbSet<SaintEir_Department> SaintEir_Departments { get; set; }
        public virtual DbSet<SaintEir_Department_Calendar> SaintEir_Department_Calendars { get; set; }
        public virtual DbSet<SaintEir_DigitalFile> SaintEir_DigitalFiles { get; set; }
        public virtual DbSet<SaintEir_DocRequireHistory> SaintEir_DocRequireHistories { get; set; }
        public virtual DbSet<SaintEir_DoctorRewardConfig> SaintEir_DoctorRewardConfigs { get; set; }
        public virtual DbSet<SaintEir_DoctorSkill> SaintEir_DoctorSkills { get; set; }
        public virtual DbSet<SaintEir_DrOrderQuickWord> SaintEir_DrOrderQuickWords { get; set; }
        public virtual DbSet<SaintEir_DrWorkDay> SaintEir_DrWorkDays { get; set; }
        public virtual DbSet<SaintEir_EMailLog> SaintEir_EMailLogs { get; set; }
        public virtual DbSet<SaintEir_EMailLog_Address> SaintEir_EMailLog_Addresses { get; set; }
        public virtual DbSet<SaintEir_EMailLog_Attachment> SaintEir_EMailLog_Attachments { get; set; }
        public virtual DbSet<SaintEir_EMailWording> SaintEir_EMailWordings { get; set; }
        public virtual DbSet<SaintEir_Edm> SaintEir_Edms { get; set; }
        public virtual DbSet<SaintEir_Education> SaintEir_Educations { get; set; }
        public virtual DbSet<SaintEir_EmployeeType> SaintEir_EmployeeTypes { get; set; }
        public virtual DbSet<SaintEir_EmployeeWorkDay> SaintEir_EmployeeWorkDays { get; set; }
        public virtual DbSet<SaintEir_EventHistory> SaintEir_EventHistories { get; set; }
        public virtual DbSet<SaintEir_FSFileVirtualNode> SaintEir_FSFileVirtualNodes { get; set; }
        public virtual DbSet<SaintEir_Favorite> SaintEir_Favorites { get; set; }
        public virtual DbSet<SaintEir_FlotationCost> SaintEir_FlotationCosts { get; set; }
        public virtual DbSet<SaintEir_GoodsExchange> SaintEir_GoodsExchanges { get; set; }
        public virtual DbSet<SaintEir_GoodsRefund> SaintEir_GoodsRefunds { get; set; }
        public virtual DbSet<SaintEir_GuestIntroduction> SaintEir_GuestIntroductions { get; set; }
        public virtual DbSet<SaintEir_HealthInsuranceAdj> SaintEir_HealthInsuranceAdjs { get; set; }
        public virtual DbSet<SaintEir_HealthInsuranceAmount> SaintEir_HealthInsuranceAmounts { get; set; }
        public virtual DbSet<SaintEir_HealthInsuranceVersion> SaintEir_HealthInsuranceVersions { get; set; }
        public virtual DbSet<SaintEir_Holiday> SaintEir_Holidays { get; set; }
        public virtual DbSet<SaintEir_IOB> SaintEir_IOBs { get; set; }
        public virtual DbSet<SaintEir_IOBItem> SaintEir_IOBItems { get; set; }
        public virtual DbSet<SaintEir_InComeAssign> SaintEir_InComeAssigns { get; set; }
        public virtual DbSet<SaintEir_InProcessService> SaintEir_InProcessServices { get; set; }
        public virtual DbSet<SaintEir_InbodySRecord> SaintEir_InbodySRecords { get; set; }
        public virtual DbSet<SaintEir_InsuranceIdentity> SaintEir_InsuranceIdentities { get; set; }
        public virtual DbSet<SaintEir_Introducer> SaintEir_Introducers { get; set; }
        public virtual DbSet<SaintEir_JobAdjustment> SaintEir_JobAdjustments { get; set; }
        public virtual DbSet<SaintEir_JobAdjustment_SalaryItem> SaintEir_JobAdjustment_SalaryItems { get; set; }
        public virtual DbSet<SaintEir_JobLevel> SaintEir_JobLevels { get; set; }
        public virtual DbSet<SaintEir_JobTitle> SaintEir_JobTitles { get; set; }
        public virtual DbSet<SaintEir_LaborInsuranceAdj> SaintEir_LaborInsuranceAdjs { get; set; }
        public virtual DbSet<SaintEir_LoginUserInBranch> SaintEir_LoginUserInBranches { get; set; }
        public virtual DbSet<SaintEir_MaterialConsumption> SaintEir_MaterialConsumptions { get; set; }
        public virtual DbSet<SaintEir_MaterialSummary> SaintEir_MaterialSummaries { get; set; }
        public virtual DbSet<SaintEir_Member> SaintEir_Members { get; set; }
        public virtual DbSet<SaintEir_MemberAnalysis> SaintEir_MemberAnalyses { get; set; }
        public virtual DbSet<SaintEir_MemberApp> SaintEir_MemberApps { get; set; }
        public virtual DbSet<SaintEir_MemberBlackList> SaintEir_MemberBlackLists { get; set; }
        public virtual DbSet<SaintEir_MemberDrOrder> SaintEir_MemberDrOrders { get; set; }
        public virtual DbSet<SaintEir_MemberMedicalRecord> SaintEir_MemberMedicalRecords { get; set; }
        public virtual DbSet<SaintEir_MemberValue> SaintEir_MemberValues { get; set; }
        public virtual DbSet<SaintEir_MonthlyReport> SaintEir_MonthlyReports { get; set; }
        public virtual DbSet<SaintEir_MonthlyReportCustom> SaintEir_MonthlyReportCustoms { get; set; }
        public virtual DbSet<SaintEir_MsgMapping> SaintEir_MsgMappings { get; set; }
        public virtual DbSet<SaintEir_OperationItem> SaintEir_OperationItems { get; set; }
        public virtual DbSet<SaintEir_OutPeriod> SaintEir_OutPeriods { get; set; }
        public virtual DbSet<SaintEir_OvertimeApplication> SaintEir_OvertimeApplications { get; set; }
        public virtual DbSet<SaintEir_OvertimePayType> SaintEir_OvertimePayTypes { get; set; }
        public virtual DbSet<SaintEir_Package> SaintEir_Packages { get; set; }
        public virtual DbSet<SaintEir_PackageItem> SaintEir_PackageItems { get; set; }
        public virtual DbSet<SaintEir_PackageReward> SaintEir_PackageRewards { get; set; }
        public virtual DbSet<SaintEir_PackageRewardIntro> SaintEir_PackageRewardIntros { get; set; }
        public virtual DbSet<SaintEir_PaidTimeOffSetting> SaintEir_PaidTimeOffSettings { get; set; }
        public virtual DbSet<SaintEir_PaiedHoliday> SaintEir_PaiedHolidays { get; set; }
        public virtual DbSet<SaintEir_Parameter> SaintEir_Parameters { get; set; }
        public virtual DbSet<SaintEir_ParameterControl> SaintEir_ParameterControls { get; set; }
        public virtual DbSet<SaintEir_PayHistory> SaintEir_PayHistories { get; set; }
        public virtual DbSet<SaintEir_PayStatus> SaintEir_PayStatuses { get; set; }
        public virtual DbSet<SaintEir_PayrollSettlementDate> SaintEir_PayrollSettlementDates { get; set; }
        public virtual DbSet<SaintEir_PendingDocument> SaintEir_PendingDocuments { get; set; }
        public virtual DbSet<SaintEir_PersonalReward> SaintEir_PersonalRewards { get; set; }
        public virtual DbSet<SaintEir_PrePayHistory> SaintEir_PrePayHistories { get; set; }
        public virtual DbSet<SaintEir_Product> SaintEir_Products { get; set; }
        public virtual DbSet<SaintEir_ProductInBranch> SaintEir_ProductInBranches { get; set; }
        public virtual DbSet<SaintEir_ProductOrder> SaintEir_ProductOrders { get; set; }
        public virtual DbSet<SaintEir_ProductOrderItem> SaintEir_ProductOrderItems { get; set; }
        public virtual DbSet<SaintEir_ProductPrice> SaintEir_ProductPrices { get; set; }
        public virtual DbSet<SaintEir_ProductReward> SaintEir_ProductRewards { get; set; }
        public virtual DbSet<SaintEir_ProductRewardExtra> SaintEir_ProductRewardExtras { get; set; }
        public virtual DbSet<SaintEir_ProductRewardIntro> SaintEir_ProductRewardIntros { get; set; }
        public virtual DbSet<SaintEir_Province> SaintEir_Provinces { get; set; }
        public virtual DbSet<SaintEir_Purchase> SaintEir_Purchases { get; set; }
        public virtual DbSet<SaintEir_PurchaseItem> SaintEir_PurchaseItems { get; set; }
        public virtual DbSet<SaintEir_PurchaseItemCredit> SaintEir_PurchaseItemCredits { get; set; }
        public virtual DbSet<SaintEir_PurchaseItemStatus> SaintEir_PurchaseItemStatuses { get; set; }
        public virtual DbSet<SaintEir_PurchaseItemSubTotal> SaintEir_PurchaseItemSubTotals { get; set; }
        public virtual DbSet<SaintEir_RegularList> SaintEir_RegularLists { get; set; }
        public virtual DbSet<SaintEir_RegularListItem> SaintEir_RegularListItems { get; set; }
        public virtual DbSet<SaintEir_Remaining> SaintEir_Remainings { get; set; }
        public virtual DbSet<SaintEir_RemainingCheck> SaintEir_RemainingChecks { get; set; }
        public virtual DbSet<SaintEir_RemindParam> SaintEir_RemindParams { get; set; }
        public virtual DbSet<SaintEir_Reminder> SaintEir_Reminders { get; set; }
        public virtual DbSet<SaintEir_ResTimeLock> SaintEir_ResTimeLocks { get; set; }
        public virtual DbSet<SaintEir_Reservation> SaintEir_Reservations { get; set; }
        public virtual DbSet<SaintEir_ReservationCommon> SaintEir_ReservationCommons { get; set; }
        public virtual DbSet<SaintEir_ReservationLimit> SaintEir_ReservationLimits { get; set; }
        public virtual DbSet<SaintEir_ReservationLimitRelate> SaintEir_ReservationLimitRelates { get; set; }
        public virtual DbSet<SaintEir_ResignApplication> SaintEir_ResignApplications { get; set; }
        public virtual DbSet<SaintEir_Resource> SaintEir_Resources { get; set; }
        public virtual DbSet<SaintEir_RetireInsuranceAdj> SaintEir_RetireInsuranceAdjs { get; set; }
        public virtual DbSet<SaintEir_RewardAdditionalItem> SaintEir_RewardAdditionalItems { get; set; }
        public virtual DbSet<SaintEir_RewardBaseSetting> SaintEir_RewardBaseSettings { get; set; }
        public virtual DbSet<SaintEir_RewardDistribution> SaintEir_RewardDistributions { get; set; }
        public virtual DbSet<SaintEir_RewardPaid> SaintEir_RewardPaids { get; set; }
        public virtual DbSet<SaintEir_RewardPaidItem> SaintEir_RewardPaidItems { get; set; }
        public virtual DbSet<SaintEir_SClassify> SaintEir_SClassifies { get; set; }
        public virtual DbSet<SaintEir_SMSSendHistory> SaintEir_SMSSendHistories { get; set; }
        public virtual DbSet<SaintEir_SMSWording> SaintEir_SMSWordings { get; set; }
        public virtual DbSet<SaintEir_Salary> SaintEir_Salaries { get; set; }
        public virtual DbSet<SaintEir_SalaryDetail> SaintEir_SalaryDetails { get; set; }
        public virtual DbSet<SaintEir_SalaryDetail_Log> SaintEir_SalaryDetail_Logs { get; set; }
        public virtual DbSet<SaintEir_SalaryItem> SaintEir_SalaryItems { get; set; }
        public virtual DbSet<SaintEir_Salary_Log> SaintEir_Salary_Logs { get; set; }
        public virtual DbSet<SaintEir_SaleReward> SaintEir_SaleRewards { get; set; }
        public virtual DbSet<SaintEir_SaleValue> SaintEir_SaleValues { get; set; }
        public virtual DbSet<SaintEir_SaleValue_Backup> SaintEir_SaleValue_Backups { get; set; }
        public virtual DbSet<SaintEir_SalesRanking> SaintEir_SalesRankings { get; set; }
        public virtual DbSet<SaintEir_Serial> SaintEir_Serials { get; set; }
        public virtual DbSet<SaintEir_ServiceControl> SaintEir_ServiceControls { get; set; }
        public virtual DbSet<SaintEir_ServiceOrder> SaintEir_ServiceOrders { get; set; }
        public virtual DbSet<SaintEir_ServiceStatic> SaintEir_ServiceStatics { get; set; }
        public virtual DbSet<SaintEir_ShiftApplication> SaintEir_ShiftApplications { get; set; }
        public virtual DbSet<SaintEir_ShiftApplicationDetail> SaintEir_ShiftApplicationDetails { get; set; }
        public virtual DbSet<SaintEir_SignDoc> SaintEir_SignDocs { get; set; }
        public virtual DbSet<SaintEir_SignDocItem> SaintEir_SignDocItems { get; set; }
        public virtual DbSet<SaintEir_SignDocRelative> SaintEir_SignDocRelatives { get; set; }
        public virtual DbSet<SaintEir_Signature> SaintEir_Signatures { get; set; }
        public virtual DbSet<SaintEir_SignatureRelative> SaintEir_SignatureRelatives { get; set; }
        public virtual DbSet<SaintEir_StockType> SaintEir_StockTypes { get; set; }
        public virtual DbSet<SaintEir_Subsidy> SaintEir_Subsidies { get; set; }
        public virtual DbSet<SaintEir_Supplier> SaintEir_Suppliers { get; set; }
        public virtual DbSet<SaintEir_SupplyList> SaintEir_SupplyLists { get; set; }
        public virtual DbSet<SaintEir_TakeOffApplication> SaintEir_TakeOffApplications { get; set; }
        public virtual DbSet<SaintEir_TakeOffApplicationAttachement> SaintEir_TakeOffApplicationAttachements { get; set; }
        public virtual DbSet<SaintEir_TakeOffCategory> SaintEir_TakeOffCategories { get; set; }
        public virtual DbSet<SaintEir_TakeOffSchedule> SaintEir_TakeOffSchedules { get; set; }
        public virtual DbSet<SaintEir_TakeOffType> SaintEir_TakeOffTypes { get; set; }
        public virtual DbSet<SaintEir_TakeOfficeApplication> SaintEir_TakeOfficeApplications { get; set; }
        public virtual DbSet<SaintEir_TakeOfficeApplication_SalaryItem> SaintEir_TakeOfficeApplication_SalaryItems { get; set; }
        public virtual DbSet<SaintEir_TakeOfficeTemplate> SaintEir_TakeOfficeTemplates { get; set; }
        public virtual DbSet<SaintEir_TaxAgreement> SaintEir_TaxAgreements { get; set; }
        public virtual DbSet<SaintEir_TeamReward> SaintEir_TeamRewards { get; set; }
        public virtual DbSet<SaintEir_TempDatum> SaintEir_TempData { get; set; }
        public virtual DbSet<SaintEir_TransferMemberHistory> SaintEir_TransferMemberHistories { get; set; }
        public virtual DbSet<SaintEir_User_Calendar> SaintEir_User_Calendars { get; set; }
        public virtual DbSet<SaintEir_User_SalaryItem> SaintEir_User_SalaryItems { get; set; }
        public virtual DbSet<SaintEir_ValuableCoupon> SaintEir_ValuableCoupons { get; set; }
        public virtual DbSet<SaintEir_Withhold> SaintEir_Withholds { get; set; }
        public virtual DbSet<SaintEir_WorkSheet> SaintEir_WorkSheets { get; set; }
        public virtual DbSet<SaintEir_WorkingCalendar> SaintEir_WorkingCalendars { get; set; }
        public virtual DbSet<SaintEir_WorkingCalendarDay> SaintEir_WorkingCalendarDays { get; set; }
        public virtual DbSet<SaintEir_WorkingDayType> SaintEir_WorkingDayTypes { get; set; }
        public virtual DbSet<SaintEir_WorkingTime> SaintEir_WorkingTimes { get; set; }
        public virtual DbSet<SaintEir_flCoworker> SaintEir_flCoworkers { get; set; }
        public virtual DbSet<SaintEir_flCoworkerMemo> SaintEir_flCoworkerMemos { get; set; }
        public virtual DbSet<SaintEir_flDocDatum> SaintEir_flDocData { get; set; }
        public virtual DbSet<SaintEir_flDocField> SaintEir_flDocFields { get; set; }
        public virtual DbSet<SaintEir_flDocFieldDataType> SaintEir_flDocFieldDataTypes { get; set; }
        public virtual DbSet<SaintEir_flDocFieldType> SaintEir_flDocFieldTypes { get; set; }
        public virtual DbSet<SaintEir_flDocNo> SaintEir_flDocNos { get; set; }
        public virtual DbSet<SaintEir_flDocNoControl> SaintEir_flDocNoControls { get; set; }
        public virtual DbSet<SaintEir_flDocRow> SaintEir_flDocRows { get; set; }
        public virtual DbSet<SaintEir_flDocType> SaintEir_flDocTypes { get; set; }
        public virtual DbSet<SaintEir_flDocTypeVersion> SaintEir_flDocTypeVersions { get; set; }
        public virtual DbSet<SaintEir_flDocument> SaintEir_flDocuments { get; set; }
        public virtual DbSet<SaintEir_flDocumentToken> SaintEir_flDocumentTokens { get; set; }
        public virtual DbSet<SaintEir_flDocument_CurrentSubNode> SaintEir_flDocument_CurrentSubNodes { get; set; }
        public virtual DbSet<SaintEir_flDocument_CurrentSubNode_Role> SaintEir_flDocument_CurrentSubNode_Roles { get; set; }
        public virtual DbSet<SaintEir_flDocument_CurrentSubNode_User> SaintEir_flDocument_CurrentSubNode_Users { get; set; }
        public virtual DbSet<SaintEir_flDocument_CurrentVerifier> SaintEir_flDocument_CurrentVerifiers { get; set; }
        public virtual DbSet<SaintEir_flLog> SaintEir_flLogs { get; set; }
        public virtual DbSet<SaintEir_flNode> SaintEir_flNodes { get; set; }
        public virtual DbSet<SaintEir_flNode_Role> SaintEir_flNode_Roles { get; set; }
        public virtual DbSet<SaintEir_flNode_User> SaintEir_flNode_Users { get; set; }
        public virtual DbSet<SaintEir_flRoleAuthority> SaintEir_flRoleAuthorities { get; set; }
        public virtual DbSet<SaintEir_flSkipedDocument> SaintEir_flSkipedDocuments { get; set; }
        public virtual DbSet<SaintEir_flUserAuthority> SaintEir_flUserAuthorities { get; set; }
        public virtual DbSet<Tmp_SaintEir_DRService> Tmp_SaintEir_DRServices { get; set; }
        public virtual DbSet<UserStatusLog> UserStatusLogs { get; set; }
        public virtual DbSet<V_PRO2E_AUTH_LOGIN_USER> V_PRO2E_AUTH_LOGIN_USERs { get; set; }
        public virtual DbSet<V_PRO2E_AUTH_USER_IN_ROLE> V_PRO2E_AUTH_USER_IN_ROLEs { get; set; }
        public virtual DbSet<V_SaintEir_AdditionalLeave> V_SaintEir_AdditionalLeaves { get; set; }
        public virtual DbSet<V_SaintEir_AdditionalLeaveUsageLog> V_SaintEir_AdditionalLeaveUsageLogs { get; set; }
        public virtual DbSet<V_SaintEir_AllUserInitialAdditionalLeave> V_SaintEir_AllUserInitialAdditionalLeaves { get; set; }
        public virtual DbSet<V_SaintEir_AttendanceRecord> V_SaintEir_AttendanceRecords { get; set; }
        public virtual DbSet<V_SaintEir_ClockInRecord> V_SaintEir_ClockInRecords { get; set; }
        public virtual DbSet<V_SaintEir_ConsumptionConfirm> V_SaintEir_ConsumptionConfirms { get; set; }
        public virtual DbSet<V_SaintEir_Department> V_SaintEir_Departments { get; set; }
        public virtual DbSet<V_SaintEir_DocRecord> V_SaintEir_DocRecords { get; set; }
        public virtual DbSet<V_SaintEir_HealthInsuranceAdj> V_SaintEir_HealthInsuranceAdjs { get; set; }
        public virtual DbSet<V_SaintEir_InitialAdditionalLeave> V_SaintEir_InitialAdditionalLeaves { get; set; }
        public virtual DbSet<V_SaintEir_JobAdjustment> V_SaintEir_JobAdjustments { get; set; }
        public virtual DbSet<V_SaintEir_JobAdjustment_SalaryItem> V_SaintEir_JobAdjustment_SalaryItems { get; set; }
        public virtual DbSet<V_SaintEir_LaborInsuranceAdj> V_SaintEir_LaborInsuranceAdjs { get; set; }
        public virtual DbSet<V_SaintEir_MedicalRecordValue> V_SaintEir_MedicalRecordValues { get; set; }
        public virtual DbSet<V_SaintEir_MemberTotalAmount> V_SaintEir_MemberTotalAmounts { get; set; }
        public virtual DbSet<V_SaintEir_OvertimeApplication> V_SaintEir_OvertimeApplications { get; set; }
        public virtual DbSet<V_SaintEir_Parameter> V_SaintEir_Parameters { get; set; }
        public virtual DbSet<V_SaintEir_Remaining> V_SaintEir_Remainings { get; set; }
        public virtual DbSet<V_SaintEir_ResignApplication> V_SaintEir_ResignApplications { get; set; }
        public virtual DbSet<V_SaintEir_RetireInsuranceAdj> V_SaintEir_RetireInsuranceAdjs { get; set; }
        public virtual DbSet<V_SaintEir_Salary> V_SaintEir_Salaries { get; set; }
        public virtual DbSet<V_SaintEir_Salary_Log> V_SaintEir_Salary_Logs { get; set; }
        public virtual DbSet<V_SaintEir_Salary_WithholdSummary> V_SaintEir_Salary_WithholdSummaries { get; set; }
        public virtual DbSet<V_SaintEir_SalesInformation_productinPackage> V_SaintEir_SalesInformation_productinPackages { get; set; }
        public virtual DbSet<V_SaintEir_ShiftApplication> V_SaintEir_ShiftApplications { get; set; }
        public virtual DbSet<V_SaintEir_ShiftApplicationDetail> V_SaintEir_ShiftApplicationDetails { get; set; }
        public virtual DbSet<V_SaintEir_TakeOffApplication> V_SaintEir_TakeOffApplications { get; set; }
        public virtual DbSet<V_SaintEir_TakeOffSchedule> V_SaintEir_TakeOffSchedules { get; set; }
        public virtual DbSet<V_SaintEir_TakeOfficeApplication> V_SaintEir_TakeOfficeApplications { get; set; }
        public virtual DbSet<V_SaintEir_TargetCustomerPurchaseItem> V_SaintEir_TargetCustomerPurchaseItems { get; set; }
        public virtual DbSet<V_SaintEir_User_SalaryItem> V_SaintEir_User_SalaryItems { get; set; }
        public virtual DbSet<V_SaintEir_Withhold> V_SaintEir_Withholds { get; set; }
        public virtual DbSet<V_SaintEir_WorkingCalendarDay> V_SaintEir_WorkingCalendarDays { get; set; }
        public virtual DbSet<V_SaintEir_flCoWorker> V_SaintEir_flCoWorkers { get; set; }
        public virtual DbSet<V_SaintEir_flDocDatum> V_SaintEir_flDocData { get; set; }
        public virtual DbSet<V_SaintEir_flDocField> V_SaintEir_flDocFields { get; set; }
        public virtual DbSet<V_SaintEir_flDocument> V_SaintEir_flDocuments { get; set; }
        public virtual DbSet<V_SaintEir_flDocument_CurrentSubNode_Role> V_SaintEir_flDocument_CurrentSubNode_Roles { get; set; }
        public virtual DbSet<V_SaintEir_flDocument_CurrentSubNode_User> V_SaintEir_flDocument_CurrentSubNode_Users { get; set; }
        public virtual DbSet<V_SaintEir_flDocument_JobAdjustment> V_SaintEir_flDocument_JobAdjustments { get; set; }
        public virtual DbSet<V_SaintEir_flDocument_OvertimeApplication> V_SaintEir_flDocument_OvertimeApplications { get; set; }
        public virtual DbSet<V_SaintEir_flDocument_ResignApplication> V_SaintEir_flDocument_ResignApplications { get; set; }
        public virtual DbSet<V_SaintEir_flDocument_ShiftApplication> V_SaintEir_flDocument_ShiftApplications { get; set; }
        public virtual DbSet<V_SaintEir_flDocument_TakeOffApplication> V_SaintEir_flDocument_TakeOffApplications { get; set; }
        public virtual DbSet<V_SaintEir_flDocument_TakeOfficeApplication> V_SaintEir_flDocument_TakeOfficeApplications { get; set; }
        public virtual DbSet<V_SaintEir_flLog> V_SaintEir_flLogs { get; set; }
        public virtual DbSet<V_SaintEir_flNode_Role> V_SaintEir_flNode_Roles { get; set; }
        public virtual DbSet<V_SaintEir_flNode_User> V_SaintEir_flNode_Users { get; set; }
        public virtual DbSet<WhereToGetInfoOtherList> WhereToGetInfoOtherLists { get; set; }
        public virtual DbSet<doctor> doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=SaintEirOp;Trusted_Connection=True;user id=sa;password=abc+1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<BelongToCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BelongToCategory");

                entity.Property(e => e.BelongToCateGory1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BelongToCateGory");

                entity.Property(e => e.PurchaseItemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Consent>(entity =>
            {
                entity.HasKey(e => e.ConsentNo);

                entity.ToTable("Consent");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConsentSet>(entity =>
            {
                entity.HasKey(e => e.ConsentSetNo)
                    .HasName("PK_ConsentGroup");

                entity.ToTable("ConsentSet");
            });

            modelBuilder.Entity<ControlsDefault>(entity =>
            {
                entity.ToTable("ControlsDefault");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.ControlsGroup).HasMaxLength(50);

                entity.Property(e => e.ControlsID).HasMaxLength(50);

                entity.Property(e => e.DefaultValue).HasMaxLength(255);

                entity.Property(e => e.Icon)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseNo);

                entity.ToTable("Course");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ExamExpired).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CourseAuth>(entity =>
            {
                entity.HasKey(e => e.CourseAuthNo);

                entity.ToTable("CourseAuth");
            });

            modelBuilder.Entity<CourseCategory>(entity =>
            {
                entity.HasKey(e => e.CourseCategoryNo);

                entity.ToTable("CourseCategory");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CourseMaterial>(entity =>
            {
                entity.HasKey(e => e.CourseMaterialNo);

                entity.ToTable("CourseMaterial");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OrderBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.Path).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CourseMaterialRecord>(entity =>
            {
                entity.HasKey(e => e.CourseMaterialRecordNo);

                entity.ToTable("CourseMaterialRecord");

                entity.Property(e => e.BelongToUser).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CourseRecord>(entity =>
            {
                entity.HasKey(e => e.CourseRecordNo);

                entity.ToTable("CourseRecord");

                entity.Property(e => e.BelongToUser).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CourseResult>(entity =>
            {
                entity.HasKey(e => e.CourseResultNo);

                entity.ToTable("CourseResult");

                entity.Property(e => e.BelongToUser).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CurePurpose>(entity =>
            {
                entity.HasKey(e => e.CurePurposeNo);

                entity.ToTable("CurePurpose");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DailyDealBranch>(entity =>
            {
                entity.HasKey(e => e.DailyDealBranchNo);

                entity.ToTable("DailyDealBranch");

                entity.Property(e => e.BelongToBranch).HasMaxLength(255);

                entity.Property(e => e.CustomerType).HasMaxLength(255);

                entity.Property(e => e.StaticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DailyDealUser>(entity =>
            {
                entity.HasKey(e => e.DailyDealUserNo);

                entity.ToTable("DailyDealUser");

                entity.Property(e => e.BelongToBranch).HasMaxLength(255);

                entity.Property(e => e.BelongToUser).HasMaxLength(255);

                entity.Property(e => e.CustomerType).HasMaxLength(255);

                entity.Property(e => e.StaticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DailyDealUserCategory>(entity =>
            {
                entity.HasKey(e => e.DailyDealUserCategoryNo)
                    .HasName("PK_DailyDealUserCategoryNo");

                entity.ToTable("DailyDealUserCategory");

                entity.Property(e => e.BelongToBranch).HasMaxLength(255);

                entity.Property(e => e.BelongToUser).HasMaxLength(255);

                entity.Property(e => e.CustomerType).HasMaxLength(255);

                entity.Property(e => e.StaticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DailyOperationStatic>(entity =>
            {
                entity.HasKey(e => e.DailyOperationStaticNo);

                entity.ToTable("DailyOperationStatic");

                entity.Property(e => e.BranchNo).HasMaxLength(255);

                entity.Property(e => e.CustomerType).HasMaxLength(255);

                entity.Property(e => e.ServiceUser).HasMaxLength(255);

                entity.Property(e => e.StaticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DrFlotationCost>(entity =>
            {
                entity.HasKey(e => e.DrFlotationCostNo);

                entity.ToTable("DrFlotationCost");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<IOBARAPTitleMapping>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_IOBAPARTitleMapping");

                entity.ToTable("IOBARAPTitleMapping");

                entity.Property(e => e.ARAP).HasMaxLength(255);

                entity.Property(e => e.BelongTOBranch).HasMaxLength(255);

                entity.Property(e => e.BelongToTitle).HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<IOBTitleMapping>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_IOBTitleMapping2");

                entity.ToTable("IOBTitleMapping");

                entity.Property(e => e.BelongToBranch).HasMaxLength(255);

                entity.Property(e => e.BelongToTitle).HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MaterialChangeLogType).HasMaxLength(255);

                entity.Property(e => e.PriceType).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MTagInMember>(entity =>
            {
                entity.HasKey(e => e.MTagInMemberNo);

                entity.ToTable("MTagInMember");
            });

            modelBuilder.Entity<MedicalFormTag>(entity =>
            {
                entity.HasKey(e => e.MedicalFormTagNo)
                    .HasName("PK_ConsentTag");

                entity.ToTable("MedicalFormTag");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PreviewClass)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SignedClass)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MedicalRecord>(entity =>
            {
                entity.HasKey(e => e.MedicalRecordNo)
                    .HasName("PK_MedicalRecord_1");

                entity.ToTable("MedicalRecord");

                entity.Property(e => e.Application)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ByDr).HasMaxLength(50);

                entity.Property(e => e.ByFollower).HasMaxLength(50);

                entity.Property(e => e.ByNurse).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TempIndex).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicalRecordColumn>(entity =>
            {
                entity.HasKey(e => e.MedicalRecordColumnNo);

                entity.ToTable("MedicalRecordColumn");

                entity.Property(e => e.ColumnId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue).HasMaxLength(255);

                entity.Property(e => e.SubGroupBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicalRecordColumnItem>(entity =>
            {
                entity.HasKey(e => e.MedicalRecordColumnItemNo)
                    .HasName("PK_MedicalRecordColumnItemVO");

                entity.ToTable("MedicalRecordColumnItem");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicalRecordForm>(entity =>
            {
                entity.HasKey(e => e.MedicalRecordFormNo)
                    .HasName("PK_MedicalRecord");

                entity.ToTable("MedicalRecordForm");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicalRecordFormSet>(entity =>
            {
                entity.HasKey(e => e.MedicalRecordFormSetNo);

                entity.ToTable("MedicalRecordFormSet");
            });

            modelBuilder.Entity<MedicalRecordGroup>(entity =>
            {
                entity.HasKey(e => e.MedicalRecordGroupNo)
                    .HasName("PK__MedicalR__B8456357E83BA6FA");

                entity.ToTable("MedicalRecordGroup");

                entity.Property(e => e.GroupByName).HasMaxLength(100);
            });

            modelBuilder.Entity<MedicalRecordRelative>(entity =>
            {
                entity.HasKey(e => e.MedicalRecordRelativeNo)
                    .HasName("PK__MedicalR__C04F4514C1CA32A3");

                entity.ToTable("MedicalRecordRelative");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BelongToConsultationNavigation)
                    .WithMany(p => p.MedicalRecordRelatives)
                    .HasForeignKey(d => d.BelongToConsultation)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MedicalRecordRelative_SaintEir_MemberMedicalRecord");

                entity.HasOne(d => d.BelongToConsumptionHistoryNavigation)
                    .WithMany(p => p.MedicalRecordRelatives)
                    .HasForeignKey(d => d.BelongToConsumptionHistory)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MedicalRecordRelative_SaintEir_ComsumptionHistory");

                entity.HasOne(d => d.BelongToMedicalRecordNavigation)
                    .WithMany(p => p.MedicalRecordRelatives)
                    .HasForeignKey(d => d.BelongToMedicalRecord)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MedicalRecordRelative_MedicalRecord");

                entity.HasOne(d => d.BelongToPurchaseItemNavigation)
                    .WithMany(p => p.MedicalRecordRelatives)
                    .HasForeignKey(d => d.BelongToPurchaseItem)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MedicalRecordRelative_SaintEir_PurchaseItem");
            });

            modelBuilder.Entity<MedicalRecordValue>(entity =>
            {
                entity.HasKey(e => e.MedicalRecordValueNo);

                entity.ToTable("MedicalRecordValue");

                entity.Property(e => e.ItemColumn).HasMaxLength(50);

                entity.Property(e => e.ItemRow).HasMaxLength(50);

                entity.Property(e => e.ItemValue).IsUnicode(false);

                entity.HasOne(d => d.BelongToRecordNavigation)
                    .WithMany(p => p.MedicalRecordValues)
                    .HasForeignKey(d => d.BelongToRecord)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MedicalRecordValue_MedicalRecord");
            });

            modelBuilder.Entity<MemberAlbum>(entity =>
            {
                entity.HasKey(e => e.MemberAlbumNo);

                entity.ToTable("MemberAlbum");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.PhotoBy).HasMaxLength(255);

                entity.Property(e => e.PhotoDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MemberAlbumAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeNo);

                entity.ToTable("MemberAlbumAttribute");
            });

            modelBuilder.Entity<MemberAlbumCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryNo);

                entity.ToTable("MemberAlbumCategory");

                entity.Property(e => e.BelongToPosition)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MemberAlbumItem>(entity =>
            {
                entity.HasKey(e => e.MemberAlbumItemNo);

                entity.ToTable("MemberAlbumItem");

                entity.Property(e => e.PhotoPath).HasMaxLength(255);

                entity.Property(e => e.TakenDate).HasColumnType("datetime");

                entity.Property(e => e.ThumbPath).HasMaxLength(255);
            });

            modelBuilder.Entity<MemberAlbumMask>(entity =>
            {
                entity.HasKey(e => e.MaskNo)
                    .HasName("PK__MemberAl__9F1036CF3A42FD7D");

                entity.ToTable("MemberAlbumMask");
            });

            modelBuilder.Entity<MemberTag>(entity =>
            {
                entity.HasKey(e => e.MemberTagNo)
                    .HasName("PK_Description");

                entity.ToTable("MemberTag");

                entity.Property(e => e.Color).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MemberWhereToGetInfo>(entity =>
            {
                entity.HasKey(e => new { e.BelongToMember, e.CategoryNo });

                entity.ToTable("MemberWhereToGetInfo");
            });

            modelBuilder.Entity<PRO2E_AUTH_FUNCTION_PATH>(entity =>
            {
                entity.ToTable("PRO2E_AUTH_FUNCTION_PATH");

                entity.Property(e => e.Path).HasMaxLength(255);

                entity.HasOne(d => d.MenuFunc)
                    .WithMany(p => p.PRO2E_AUTH_FUNCTION_PATHs)
                    .HasForeignKey(d => d.MenuFuncId)
                    .HasConstraintName("FK253044C9B2701529");
            });

            modelBuilder.Entity<PRO2E_AUTH_FUNC_OPT>(entity =>
            {
                entity.ToTable("PRO2E_AUTH_FUNC_OPT");

                entity.HasIndex(e => e.FuncOprtId, "UQ__PRO2E_AUTH_FUNC___4F12BBB9")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.FuncOprt)
                    .WithOne(p => p.PRO2E_AUTH_FUNC_OPT)
                    .HasForeignKey<PRO2E_AUTH_FUNC_OPT>(d => d.FuncOprtId)
                    .HasConstraintName("FKDDA508F7E3CE6C0");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.PRO2E_AUTH_FUNC_OPT)
                    .HasForeignKey<PRO2E_AUTH_FUNC_OPT>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKDDA508F7337881C1");
            });

            modelBuilder.Entity<PRO2E_AUTH_LOGIN_ROLE>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__PRO2E_AUTH_LOGIN__52E34C9D");

                entity.ToTable("PRO2E_AUTH_LOGIN_ROLE");

                entity.Property(e => e.BackgroundColor).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.LoweredRoleName).HasMaxLength(255);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PRO2E_AUTH_LOGIN_USER>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__PRO2E_AUTH_LOGIN__56B3DD81");

                entity.ToTable("PRO2E_AUTH_LOGIN_USER");

                entity.HasIndex(e => e.LoginName, "IDX_PRO2E_AUTH_LOGIN_USER_LoginName");

                entity.HasIndex(e => e.UserId, "IDX_PRO2E_AUTH_LOGIN_USER_UserId");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasComment("員工編號");

                entity.Property(e => e.ArrivedDate)
                    .HasColumnType("datetime")
                    .HasComment("到職日期");

                entity.Property(e => e.ArrivedDateForPrint).HasColumnType("datetime");

                entity.Property(e => e.AssignBranchNo)
                    .HasMaxLength(20)
                    .HasComment("指派店別(部門)");

                entity.Property(e => e.AttendanceBonus).HasComment("全勤獎金(月) 金額");

                entity.Property(e => e.BasicSalary).HasComment("本薪金額");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Blood).HasMaxLength(10);

                entity.Property(e => e.CardNo)
                    .HasMaxLength(50)
                    .HasComment("卡號");

                entity.Property(e => e.ContactAddress).HasMaxLength(500);

                entity.Property(e => e.ContactZipCode).HasMaxLength(10);

                entity.Property(e => e.CountryId).HasComment("所屬國籍");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomedField1).HasComment("自定欄位1");

                entity.Property(e => e.CustomedField2).HasComment("自定欄位2");

                entity.Property(e => e.DepartmentId).HasComment("隸屬部門");

                entity.Property(e => e.DeputyId)
                    .HasMaxLength(255)
                    .HasComment("代理人員工編號");

                entity.Property(e => e.DisplayOrder).HasMaxLength(50);

                entity.Property(e => e.EducationDepartment).HasMaxLength(50);

                entity.Property(e => e.EducationDepartment2).HasMaxLength(50);

                entity.Property(e => e.EducationEnd).HasMaxLength(20);

                entity.Property(e => e.EducationEnd2).HasMaxLength(20);

                entity.Property(e => e.EducationId).HasComment("最高學歷");

                entity.Property(e => e.EducationSchool2).HasMaxLength(50);

                entity.Property(e => e.EducationStart).HasMaxLength(20);

                entity.Property(e => e.EducationStart2).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmergencyAddress)
                    .HasMaxLength(50)
                    .HasComment("緊急聯絡地址");

                entity.Property(e => e.EmergencyContactPerson)
                    .HasMaxLength(50)
                    .HasComment("緊急聯絡人");

                entity.Property(e => e.EmergencyPhone)
                    .HasMaxLength(50)
                    .HasComment("緊急聯絡電話");

                entity.Property(e => e.EmergencyRelationship)
                    .HasMaxLength(50)
                    .HasComment("與聯絡人關係");

                entity.Property(e => e.EmployeeTypeId).HasComment("員工類型");

                entity.Property(e => e.En_EDINotification).HasComment("EDI通知方式: 0：不通知(本行人工處理)，1：E-Mail通知，2：FAX，3：電話，4：EDI入帳通知");

                entity.Property(e => e.EnglishJobTitle)
                    .HasMaxLength(50)
                    .HasComment("英文職稱");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasComment("入境日期");

                entity.Property(e => e.ExperienceCompany1).HasMaxLength(50);

                entity.Property(e => e.ExperienceCompany2).HasMaxLength(50);

                entity.Property(e => e.ExperienceCompany3).HasMaxLength(50);

                entity.Property(e => e.ExperienceContent1).HasMaxLength(128);

                entity.Property(e => e.ExperienceContent2).HasMaxLength(128);

                entity.Property(e => e.ExperienceContent3).HasMaxLength(128);

                entity.Property(e => e.ExperienceEnd1).HasMaxLength(20);

                entity.Property(e => e.ExperienceEnd2).HasMaxLength(20);

                entity.Property(e => e.ExperienceEnd3).HasMaxLength(20);

                entity.Property(e => e.ExperienceStart1).HasMaxLength(20);

                entity.Property(e => e.ExperienceStart2).HasMaxLength(20);

                entity.Property(e => e.ExperienceStart3).HasMaxLength(20);

                entity.Property(e => e.ExperienceTitle1).HasMaxLength(50);

                entity.Property(e => e.ExperienceTitle2).HasMaxLength(50);

                entity.Property(e => e.ExperienceTitle3).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasComment("到期日期");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .HasComment("傳真號碼");

                entity.Property(e => e.FullNameInChinese)
                    .HasMaxLength(50)
                    .HasComment("姓名");

                entity.Property(e => e.FullNameInEnglish).HasMaxLength(50);

                entity.Property(e => e.HCNo)
                    .HasMaxLength(50)
                    .HasComment("健保卡號");

                entity.Property(e => e.HCNoWithholding)
                    .HasMaxLength(50)
                    .HasComment("免扣繳對象");

                entity.Property(e => e.HCSpecialIdentity)
                    .HasMaxLength(50)
                    .HasComment("特殊身份");

                entity.Property(e => e.HealthCheckupDate)
                    .HasColumnType("datetime")
                    .HasComment("體檢日期");

                entity.Property(e => e.HouseOtherPhone).HasMaxLength(20);

                entity.Property(e => e.HousePhone).HasMaxLength(20);

                entity.Property(e => e.HousePhoneAreaCode).HasMaxLength(10);

                entity.Property(e => e.IdTypeId).HasComment("證號別");

                entity.Property(e => e.IncomeCountryId).HasComment("所得國家代碼");

                entity.Property(e => e.InitOutDays).HasComment("初始非在職天數");

                entity.Property(e => e.InsuranceIdentityId).HasComment("保險身份");

                entity.Property(e => e.InvaildDate)
                    .HasColumnType("datetime")
                    .HasComment("失效日");

                entity.Property(e => e.Is_AttendanceBonus).HasComment("全勤獎金(月)");

                entity.Property(e => e.Is_ClockIn).HasComment("要刷卡");

                entity.Property(e => e.Is_ElasticalHour).HasComment("彈性工時");

                entity.Property(e => e.Is_Foreign).HasComment("外籍");

                entity.Property(e => e.Is_Married).HasComment("已婚");

                entity.Property(e => e.Is_MealAllowance).HasComment("伙食津貼");

                entity.Property(e => e.Is_MoreThan183Days).HasComment("本給付年度內按所得人護照入出境章戳日期累計在華已滿183天");

                entity.Property(e => e.Is_OverTimePay).HasComment("加班費用");

                entity.Property(e => e.Is_PayRemittanceFee).HasComment("支付匯費");

                entity.Property(e => e.Is_PaySalary).HasComment("發放薪資");

                entity.Property(e => e.Is_ReceiveFlowNotify)
                    .HasDefaultValueSql("((1))")
                    .HasComment("接收審核流程通知");

                entity.Property(e => e.Is_Welfare).HasComment("代扣福利費");

                entity.Property(e => e.JobLevelId).HasComment("職級編號");

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.JobTitleId).HasComment("職稱編號");

                entity.Property(e => e.LINo)
                    .HasMaxLength(50)
                    .HasComment("勞保卡號");

                entity.Property(e => e.LISpecialIdentity)
                    .HasMaxLength(50)
                    .HasComment("勞基法特殊身份");

                entity.Property(e => e.LaborRetireSpecialIdentity)
                    .HasMaxLength(50)
                    .HasComment("勞退提繳身份");

                entity.Property(e => e.LastEmployerContribution).HasComment("期前雇主提繳金額");

                entity.Property(e => e.LastWorkerContribution).HasComment("期前勞工提繳金額");

                entity.Property(e => e.LeaveDate)
                    .HasColumnType("datetime")
                    .HasComment("離職日期");

                entity.Property(e => e.LeaveWithoutPayDate)
                    .HasColumnType("datetime")
                    .HasComment("留職停薪日期");

                entity.Property(e => e.LicenseName1).HasMaxLength(50);

                entity.Property(e => e.LicenseName2).HasMaxLength(50);

                entity.Property(e => e.LicenseName3).HasMaxLength(50);

                entity.Property(e => e.LicenseNo1).HasMaxLength(50);

                entity.Property(e => e.LicenseNo2).HasMaxLength(50);

                entity.Property(e => e.LicenseNo3).HasMaxLength(50);

                entity.Property(e => e.LoginName).HasMaxLength(50);

                entity.Property(e => e.MealAllowance).HasComment("伙食津貼金額");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.NextAnnualLeaveAddingDate)
                    .HasColumnType("datetime")
                    .HasComment("下次發放特休日期");

                entity.Property(e => e.OverTimePayId).HasComment("加班類別");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(50)
                    .HasComment("護照");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PersonalAnnualLeaveType).HasComment("依部門設定 = 0, 發放特休 = 2, 不發放特休 = -2");

                entity.Property(e => e.PhysicianCertificate).HasMaxLength(255);

                entity.Property(e => e.PhysicianSpecialist).HasMaxLength(255);

                entity.Property(e => e.Pic)
                    .HasMaxLength(255)
                    .HasComment("員工照片");

                entity.Property(e => e.ProvinceId).HasComment("所屬籍貫");

                entity.Property(e => e.SSID).HasMaxLength(20);

                entity.Property(e => e.SalaryBranchNo)
                    .HasMaxLength(20)
                    .HasComment("薪資隸屬公司編號");

                entity.Property(e => e.SalaryDepartmentId).HasComment("薪資隸屬部門");

                entity.Property(e => e.School)
                    .HasMaxLength(50)
                    .HasComment("學校科系");

                entity.Property(e => e.SecurityLevel).HasComment("安全級別");

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.Specialty)
                    .HasMaxLength(50)
                    .HasComment("個人專長");

                entity.Property(e => e.StandardNo)
                    .HasMaxLength(50)
                    .HasComment("標準文號");

                entity.Property(e => e.SubsidyId).HasComment("補助身份");

                entity.Property(e => e.TaxAgreementId).HasComment("所得租稅協定代碼");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("固定稅率");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.WelfareRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("代扣福利費費率");

                entity.Property(e => e.WorkingHourPerDay)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("每日工作時數");

                entity.Property(e => e.p_EmployeeStatus).HasComment("員工狀態");

                entity.Property(e => e.p_HourPayBase).HasComment("時薪計算標準");

                entity.Property(e => e.p_SalaryCaculateMethod).HasComment("計薪方式");

                entity.Property(e => e.p_SalaryPayMethod).HasComment("薪資發放方式");

                entity.Property(e => e.p_SalarySubject).HasComment("薪資科目");

                entity.Property(e => e.p_TaxType).HasComment("課稅方式");
            });

            modelBuilder.Entity<PRO2E_AUTH_MENU_FUNC>(entity =>
            {
                entity.ToTable("PRO2E_AUTH_MENU_FUNC");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DomainName).HasMaxLength(50);

                entity.Property(e => e.MainPath).HasMaxLength(255);

                entity.Property(e => e.MenuFuncName).HasMaxLength(255);

                entity.Property(e => e.Note).HasMaxLength(30);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK66906D96A279818B");
            });

            modelBuilder.Entity<PRO2E_AUTH_OPRT_ACTION>(entity =>
            {
                entity.ToTable("PRO2E_AUTH_OPRT_ACTION");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<PRO2E_AUTH_ROLE_FUNC>(entity =>
            {
                entity.ToTable("PRO2E_AUTH_ROLE_FUNC");

                entity.Property(e => e.ReadAllBranch).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReadAllContent).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReadAllUser).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.MenuFunc)
                    .WithMany(p => p.PRO2E_AUTH_ROLE_FUNCs)
                    .HasForeignKey(d => d.MenuFuncId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2791EF0CB2701529");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PRO2E_AUTH_ROLE_FUNCs)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2791EF0C8DD80949");
            });

            modelBuilder.Entity<PRO2E_AUTH_USER_IN_ROLE>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.UserId });

                entity.ToTable("PRO2E_AUTH_USER_IN_ROLE");

                entity.Property(e => e.UserId).HasMaxLength(255);
            });

            modelBuilder.Entity<PRO2E_AUTH_USER_PROFILE>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__PRO2E_AUTH_USER___5D60DB10");

                entity.ToTable("PRO2E_AUTH_USER_PROFILE");

                entity.Property(e => e.UserId).HasMaxLength(255);

                entity.Property(e => e.Commnet).HasMaxLength(255);

                entity.Property(e => e.Sex).HasMaxLength(255);
            });

            modelBuilder.Entity<PRO2E_IP_ADDRESSBOOK>(entity =>
            {
                entity.ToTable("PRO2E_IP_ADDRESSBOOK");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IpAddress).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRO2E_LOG_SYSTEM>(entity =>
            {
                entity.ToTable("PRO2E_LOG_SYSTEM");

                entity.Property(e => e.Action).HasMaxLength(15);

                entity.Property(e => e.Fucntion).HasMaxLength(50);

                entity.Property(e => e.IpAddress).HasMaxLength(150);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.SubFucntion).HasMaxLength(50);

                entity.Property(e => e.UpdateClassName).HasMaxLength(150);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateId).HasMaxLength(20);
            });

            modelBuilder.Entity<PRO2E_SYSTEM_ITEM_PARAM>(entity =>
            {
                entity.ToTable("PRO2E_SYSTEM_ITEM_PARAM");

                entity.Property(e => e.Classify).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Value).HasMaxLength(1000);
            });

            modelBuilder.Entity<PRO2E_SYSTEM_SYSTEM_PARAM>(entity =>
            {
                entity.ToTable("PRO2E_SYSTEM_SYSTEM_PARAM");

                entity.Property(e => e.Account).HasMaxLength(50);

                entity.Property(e => e.GoodsPicPath).HasMaxLength(255);

                entity.Property(e => e.MailSmtp).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.SendEmail).HasMaxLength(50);
            });

            modelBuilder.Entity<PhysicalInventory>(entity =>
            {
                entity.HasKey(e => e.PhysicalInventoryNo);

                entity.ToTable("PhysicalInventory");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InventoryDate).HasColumnType("datetime");

                entity.Property(e => e.InventoryHelper1).HasMaxLength(255);

                entity.Property(e => e.InventoryHelper2).HasMaxLength(255);

                entity.Property(e => e.ToIOBBy).HasMaxLength(255);

                entity.Property(e => e.ToIOBDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PhysicalInventoryItem>(entity =>
            {
                entity.HasKey(e => e.PhysicalInventoryItemNo);

                entity.ToTable("PhysicalInventoryItem");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.InventoryQuantity).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PresentQuantity).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<ProductInCCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductInCCategory");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ProductInSm>(entity =>
            {
                entity.HasKey(e => e.ProductInSmsNo);
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.HasKey(e => e.BelongToInprocess);

                entity.ToTable("Receipt");

                entity.Property(e => e.BelongToInprocess).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReceiptItem>(entity =>
            {
                entity.HasKey(e => e.ReceiptItemNo);

                entity.ToTable("ReceiptItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(9, 0)");
            });

            modelBuilder.Entity<RegularVoucher>(entity =>
            {
                entity.HasKey(e => e.RegularVoucherNo);

                entity.ToTable("RegularVoucher");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RegularVoucherItem>(entity =>
            {
                entity.HasKey(e => e.RegularVoucherItemNo);

                entity.ToTable("RegularVoucherItem");

                entity.Property(e => e.CashFlowClassify).HasMaxLength(50);

                entity.Property(e => e.ChequeCashDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeNo).HasMaxLength(255);

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptNumber).HasMaxLength(50);

                entity.Property(e => e.Summary).HasMaxLength(255);
            });

            modelBuilder.Entity<RoleHierarchy>(entity =>
            {
                entity.ToTable("RoleHierarchy");

                entity.Property(e => e.Keyword).HasMaxLength(50);
            });

            modelBuilder.Entity<SEAP_Certificate>(entity =>
            {
                entity.ToTable("SEAP_Certificate");

                entity.Property(e => e.ID).HasMaxLength(50);

                entity.Property(e => e.APPMiniVersion).HasMaxLength(50);

                entity.Property(e => e.APPVersion).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<SEAP_UserLogin>(entity =>
            {
                entity.HasKey(e => e.UserLoginNo)
                    .HasName("PK__SEAP_Use__107D7E675CB403D1");

                entity.ToTable("SEAP_UserLogin");

                entity.Property(e => e.CertificateId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('ac01')");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceName).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(100);
            });

            modelBuilder.Entity<SaintEir_AccountAssign>(entity =>
            {
                entity.HasKey(e => e.AccountAssignNo)
                    .HasName("PK_SaintEir_AccountARInAssign");

                entity.ToTable("SaintEir_AccountAssign");

                entity.Property(e => e.AssignARToCredit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignARToIn).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignARToIntravenousDrip).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignARToItemInjection).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignARToItemLaser).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignARToItemOthers).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignARToItemService).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignARToItemSpa).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignARToItemSurgery).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignARToProduct).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignIncomeToCredit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignIncomeToIntravenousDrip).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignIncomeToItemInjection).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignIncomeToItemLaser).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignIncomeToItemOthers).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignIncomeToItemProduct).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignIncomeToItemService).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignIncomeToItemSpa).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignIncomeToItemSurgery).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_AccountBalance>(entity =>
            {
                entity.HasKey(e => e.AccountBalanceNo)
                    .HasName("PK__SaintEir_Account__47C69FAC");

                entity.ToTable("SaintEir_AccountBalance");

                entity.HasIndex(e => new { e.ReceiptDate, e.BelongToBranch, e.Flag, e.BelongToTitle }, "I_SaintEir_Account_1");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToSupplier).HasMaxLength(255);

                entity.Property(e => e.BelongToTitle).HasMaxLength(255);

                entity.Property(e => e.CanelReason).HasMaxLength(255);

                entity.Property(e => e.ChequeCashDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeNo).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptNo).HasMaxLength(255);

                entity.Property(e => e.ReceiptNumber).HasMaxLength(50);

                entity.Property(e => e.Summary).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_AccountBalanceOut>(entity =>
            {
                entity.HasKey(e => e.AccountBalanceNo);

                entity.ToTable("SaintEir_AccountBalanceOut");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToSupplier).HasMaxLength(255);

                entity.Property(e => e.BelongToTitle).HasMaxLength(255);

                entity.Property(e => e.CanelReason).HasMaxLength(255);

                entity.Property(e => e.ChequeCashDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeNo).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptNo).HasMaxLength(255);

                entity.Property(e => e.ReceiptNumber).HasMaxLength(50);

                entity.Property(e => e.Summary).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_AccountClassify>(entity =>
            {
                entity.HasKey(e => e.AccountClassifyNo);

                entity.ToTable("SaintEir_AccountClassify");

                entity.Property(e => e.AccountClassifyName).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_AccountInWithOut>(entity =>
            {
                entity.HasKey(e => e.AccountInWithOutNo);

                entity.ToTable("SaintEir_AccountInWithOut");

                entity.Property(e => e.AccountIn).HasMaxLength(50);

                entity.Property(e => e.AccountOut).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_AccountMonetary>(entity =>
            {
                entity.HasKey(e => e.MonetaryKeyNo)
                    .HasName("PK_SaintEir_Monetary");

                entity.ToTable("SaintEir_AccountMonetary");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.MonetaryNo).HasMaxLength(3);

                entity.Property(e => e.Rate).HasColumnType("decimal(9, 5)");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_AccountTitleBalance>(entity =>
            {
                entity.HasKey(e => e.AccountTitleBalanceNO);

                entity.ToTable("SaintEir_AccountTitleBalance");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.dateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_AccountingTitle>(entity =>
            {
                entity.HasKey(e => e.AccountingTitleNo)
                    .HasName("PK__SaintEir_Account__45DE573A");

                entity.ToTable("SaintEir_AccountingTitle");

                entity.Property(e => e.AccountCode).HasMaxLength(255);

                entity.Property(e => e.AccountTitleCht).HasMaxLength(255);

                entity.Property(e => e.AccountingClassify).HasMaxLength(10);

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToClassify).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsCashFlow).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_Achievement>(entity =>
            {
                entity.HasKey(e => e.AchievementNo)
                    .HasName("PK__SaintEir_Achieve__6501FCD8");

                entity.ToTable("SaintEir_Achievement");

                entity.Property(e => e.AchieveDate).HasColumnType("datetime");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductNo).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(255);

                entity.HasOne(d => d.ReservationNoNavigation)
                    .WithMany(p => p.SaintEir_Achievements)
                    .HasForeignKey(d => d.ReservationNo)
                    .HasConstraintName("FK3FAAAC308D232708");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SaintEir_Achievements)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK3FAAAC301C7BFF32");
            });

            modelBuilder.Entity<SaintEir_AchievementDistribution>(entity =>
            {
                entity.HasKey(e => e.AchievementDisNo);

                entity.ToTable("SaintEir_AchievementDistribution");

                entity.Property(e => e.AchievementData).HasColumnType("datetime");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToUser).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RewardPercent).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_AchievementTarget>(entity =>
            {
                entity.HasKey(e => e.AchievementTargetNo)
                    .HasName("PK_SaintEir_PerformanceTarget");

                entity.ToTable("SaintEir_AchievementTarget");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToClassify).HasMaxLength(30);

                entity.Property(e => e.BelongToUser).HasMaxLength(255);

                entity.Property(e => e.Target).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SaintEir_ActivityGood>(entity =>
            {
                entity.HasKey(e => e.ActivityGoodsNo)
                    .HasName("PK__SaintEir__A97CD7229A639B5D");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductName).HasMaxLength(255);

                entity.Property(e => e.ProductOrPackage).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_ActivityList>(entity =>
            {
                entity.HasKey(e => e.ActivityNo)
                    .HasName("PK__SaintEir__45F48F7E42F52CFD");

                entity.ToTable("SaintEir_ActivityList");

                entity.Property(e => e.ActivityName).HasMaxLength(80);

                entity.Property(e => e.BelongCategory).HasMaxLength(80);

                entity.Property(e => e.Display).HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayDate_EN).HasColumnType("datetime");

                entity.Property(e => e.DisplayDate_ST).HasColumnType("datetime");

                entity.Property(e => e.ExecutionEN).HasColumnType("datetime");

                entity.Property(e => e.ExecutionST).HasColumnType("datetime");

                entity.Property(e => e.HostBranch).HasMaxLength(80);

                entity.Property(e => e.UpdateURL).HasMaxLength(80);
            });

            modelBuilder.Entity<SaintEir_ActivityMember>(entity =>
            {
                entity.HasKey(e => e.ActivityMemberNO);

                entity.ToTable("SaintEir_ActivityMember");

                entity.Property(e => e.ActivityCheckGiftNote).IsUnicode(false);

                entity.Property(e => e.ActivityGiftItem).IsUnicode(false);

                entity.Property(e => e.ActivityGiftName).IsUnicode(false);

                entity.Property(e => e.ActivityGiftRequest).IsUnicode(false);

                entity.Property(e => e.ActivityGiftRequestDate).HasColumnType("date");

                entity.Property(e => e.ActivityMemberID)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.AnamnesisNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BelongToBranch).IsUnicode(false);

                entity.Property(e => e.BranchName).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.FullNameInChinese).IsUnicode(false);

                entity.Property(e => e.Mobile_1).IsUnicode(false);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.RFMStyleCode).IsUnicode(false);

                entity.Property(e => e.RFMTag).IsUnicode(false);

                entity.Property(e => e.SessionId).IsUnicode(false);

                entity.Property(e => e.VIPTag).IsUnicode(false);

                entity.Property(e => e.WhereToGetInfo).IsUnicode(false);

                entity.Property(e => e.sex)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SaintEir_AdditionalLeave>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.p_AdditionalLeaveType, e.SourceId });

                entity.ToTable("SaintEir_AdditionalLeave");

                entity.HasComment("補特休記錄");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasComment("使用者編號");

                entity.Property(e => e.p_AdditionalLeaveType).HasComment("補休或特休");

                entity.Property(e => e.SourceId).HasComment("來源編號(加班單編號)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("datetime")
                    .HasComment("有效期間");

                entity.Property(e => e.Hours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("時數");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsToSalary)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.ToSalaryDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsedHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("已使用的時數");
            });

            modelBuilder.Entity<SaintEir_AdditionalLeaveUsageLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_AdditionalLeaveUsageLog");

                entity.HasComment("補特休使用記錄");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Flag)
                    .HasDefaultValueSql("((1))")
                    .HasComment("標記");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.SourceId).HasComment("來源 Id");

                entity.Property(e => e.TakeOffId).HasComment("請假單 Id");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsedHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("使用的小時數");
            });

            modelBuilder.Entity<SaintEir_AdvisoryEvent>(entity =>
            {
                entity.HasKey(e => e.AdvisoryEventNo)
                    .HasName("PK__SaintEir__E3A2CC07BFF66F7F");

                entity.ToTable("SaintEir_AdvisoryEvent");

                entity.Property(e => e.AdvisoryDate).HasColumnType("datetime");

                entity.Property(e => e.BelongToBranch).HasMaxLength(255);

                entity.Property(e => e.CallTimeSlot).HasMaxLength(255);

                entity.Property(e => e.CommunicateKey).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('zh-tw')");

                entity.Property(e => e.MemberNo).HasDefaultValueSql("('0')");

                entity.Property(e => e.NewestHistoryNo).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.Type).HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<SaintEir_AdvisoryHistory>(entity =>
            {
                entity.HasKey(e => e.AdvisoryHistoryNo)
                    .HasName("PK__SaintEir__C0C2CB7ABAA434FE");

                entity.ToTable("SaintEir_AdvisoryHistory");

                entity.Property(e => e.BelongToAdvisoryEvent).HasMaxLength(255);

                entity.Property(e => e.BelongToAdvisoryHistory).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_AppBlackList>(entity =>
            {
                entity.HasKey(e => e.BlackListNo);

                entity.ToTable("SaintEir_AppBlackList");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.KeyValue).HasMaxLength(50);

                entity.Property(e => e.Reason).HasMaxLength(100);
            });

            modelBuilder.Entity<SaintEir_AppInResCategoryVO>(entity =>
            {
                entity.HasKey(e => e.AppInResCategoryNo);

                entity.ToTable("SaintEir_AppInResCategoryVO");
            });

            modelBuilder.Entity<SaintEir_AppPushHistory>(entity =>
            {
                entity.HasKey(e => e.AppPushHistoryNo);

                entity.ToTable("SaintEir_AppPushHistory");

                entity.Property(e => e.ArticleTitle).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OSType).HasMaxLength(50);

                entity.Property(e => e.PushEndDate).HasColumnType("datetime");

                entity.Property(e => e.PushStartDate).HasColumnType("datetime");

                entity.Property(e => e.PushTime).HasColumnType("datetime");

                entity.Property(e => e.PushTitle).HasMaxLength(100);

                entity.Property(e => e.ReadTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_AppPushSample>(entity =>
            {
                entity.HasKey(e => e.AppPushSampleNo);

                entity.ToTable("SaintEir_AppPushSample");

                entity.Property(e => e.ArticleTitle).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PushEndDate).HasColumnType("datetime");

                entity.Property(e => e.PushStartDate).HasColumnType("datetime");

                entity.Property(e => e.PushTime).HasColumnType("datetime");

                entity.Property(e => e.PushTitle).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_AppReservation>(entity =>
            {
                entity.HasKey(e => e.ReservationNo);

                entity.ToTable("SaintEir_AppReservation");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.ByDr).HasMaxLength(20);

                entity.Property(e => e.CancelReason).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(20);

                entity.Property(e => e.Detail).HasMaxLength(500);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.ResDate).HasColumnType("datetime");

                entity.Property(e => e.ResTime).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_AppRule>(entity =>
            {
                entity.HasKey(e => e.RuleId);

                entity.ToTable("SaintEir_AppRule");

                entity.Property(e => e.RuleId).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_AppToken>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_AppToken");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_ApproveHistory>(entity =>
            {
                entity.HasKey(e => e.ApproveHistoryNo);

                entity.ToTable("SaintEir_ApproveHistory");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_AttendanceRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_AttendanceRecord");

                entity.HasComment("出席記錄");

                entity.HasIndex(e => new { e.UserId, e.YMD }, "IX_SaintEir_AttendanceRecordUserId (ASC), YMD (ASC)")
                    .IsUnique();

                entity.Property(e => e.AdjDate)
                    .HasColumnType("datetime")
                    .HasComment("調整時間");

                entity.Property(e => e.AdjFirst)
                    .HasColumnType("datetime")
                    .HasComment("第一次卡時間_調整值");

                entity.Property(e => e.AdjLast)
                    .HasColumnType("datetime")
                    .HasComment("最後一次卡時間_調整值");

                entity.Property(e => e.AdjOvertimeEnd)
                    .HasColumnType("datetime")
                    .HasComment("加班結束時間_調整值");

                entity.Property(e => e.AdjOvertimeStart)
                    .HasColumnType("datetime")
                    .HasComment("加班開始時間_調整值");

                entity.Property(e => e.AdjUserId)
                    .HasMaxLength(255)
                    .HasComment("調整人");

                entity.Property(e => e.ApprovedOvertimeAppMinutes).HasComment("已核可加班時間_分鐘");

                entity.Property(e => e.ApprovedTakeOffAppMinutes).HasComment("已核可請假時間_分鐘");

                entity.Property(e => e.AttendanceStatus).HasComment("出席狀態說明");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("卡號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DealStatus).HasComment("處理結果說明");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(50)
                    .HasComment("部門代碼");

                entity.Property(e => e.DepartmentId).HasComment("部門編號");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .HasComment("部門名稱");

                entity.Property(e => e.EarlyMinutes).HasComment("早退分鐘數");

                entity.Property(e => e.FinalFirst)
                    .HasColumnType("datetime")
                    .HasComment("第一次卡時間_最後結果");

                entity.Property(e => e.FinalLast)
                    .HasColumnType("datetime")
                    .HasComment("最後一次卡時間_最後結果");

                entity.Property(e => e.FinalOvertimeEnd)
                    .HasColumnType("datetime")
                    .HasComment("加班結束時間_最後結果");

                entity.Property(e => e.FinalOvertimeStart)
                    .HasColumnType("datetime")
                    .HasComment("加班開始時間_最後結果");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImportFirst)
                    .HasColumnType("datetime")
                    .HasComment("第一次卡時間_匯入記錄");

                entity.Property(e => e.ImportLast)
                    .HasColumnType("datetime")
                    .HasComment("最後一次卡時間_匯入記錄");

                entity.Property(e => e.ImportOvertimeEnd)
                    .HasColumnType("datetime")
                    .HasComment("加班結束時間_原始計算結果");

                entity.Property(e => e.ImportOvertimeStart)
                    .HasColumnType("datetime")
                    .HasComment("加班開始時間_原始計算結果");

                entity.Property(e => e.Is_OK)
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否正式或已較正");

                entity.Property(e => e.LateMinutes).HasComment("遲到分鐘數");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasComment("使用者姓名");

                entity.Property(e => e.OverTimeMinutes).HasComment("加班分鐘數");

                entity.Property(e => e.OvertimeAppMinutes).HasComment("已申請加班時間_分鐘");

                entity.Property(e => e.TakeOffAppMinutes).HasComment("已申請請假時間_分鐘");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("使用者編號");

                entity.Property(e => e.WorkingDayEnd)
                    .HasColumnType("datetime")
                    .HasComment("班別之上班結束時間");

                entity.Property(e => e.WorkingDayHour).HasComment("班別之應工作小時數");

                entity.Property(e => e.WorkingDayOvertimeStart)
                    .HasColumnType("datetime")
                    .HasComment("班別之加班開始時間");

                entity.Property(e => e.WorkingDayStart)
                    .HasColumnType("datetime")
                    .HasComment("班別之上班開始時間");

                entity.Property(e => e.WorkingDayTypeCode)
                    .HasMaxLength(50)
                    .HasComment("班別代碼");

                entity.Property(e => e.WorkingDayTypeId).HasComment("班別編碼");

                entity.Property(e => e.WorkingDayTypeName)
                    .HasMaxLength(50)
                    .HasComment("班別名稱");

                entity.Property(e => e.YMD)
                    .HasColumnType("datetime")
                    .HasComment("年月日");
            });

            modelBuilder.Entity<SaintEir_AttendanceRecord_20210805>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_AttendanceRecord_20210805");

                entity.Property(e => e.AdjDate).HasColumnType("datetime");

                entity.Property(e => e.AdjFirst).HasColumnType("datetime");

                entity.Property(e => e.AdjLast).HasColumnType("datetime");

                entity.Property(e => e.AdjOvertimeEnd).HasColumnType("datetime");

                entity.Property(e => e.AdjOvertimeStart).HasColumnType("datetime");

                entity.Property(e => e.AdjUserId).HasMaxLength(255);

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode).HasMaxLength(50);

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.FinalFirst).HasColumnType("datetime");

                entity.Property(e => e.FinalLast).HasColumnType("datetime");

                entity.Property(e => e.FinalOvertimeEnd).HasColumnType("datetime");

                entity.Property(e => e.FinalOvertimeStart).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImportFirst).HasColumnType("datetime");

                entity.Property(e => e.ImportLast).HasColumnType("datetime");

                entity.Property(e => e.ImportOvertimeEnd).HasColumnType("datetime");

                entity.Property(e => e.ImportOvertimeStart).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WorkingDayEnd).HasColumnType("datetime");

                entity.Property(e => e.WorkingDayOvertimeStart).HasColumnType("datetime");

                entity.Property(e => e.WorkingDayStart).HasColumnType("datetime");

                entity.Property(e => e.WorkingDayTypeCode).HasMaxLength(50);

                entity.Property(e => e.WorkingDayTypeName).HasMaxLength(50);

                entity.Property(e => e.YMD).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_AttendantFaultRecord>(entity =>
            {
                entity.HasKey(e => e.AttendantFaultRecordNo)
                    .HasName("PK__SaintEir__068992B8D61EE681");

                entity.ToTable("SaintEir_AttendantFaultRecord");

                entity.Property(e => e.AppealReason).HasMaxLength(255);

                entity.Property(e => e.BelongToBranch)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BelongToUser)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_AttendantFaultRecordAttachment>(entity =>
            {
                entity.ToTable("SaintEir_AttendantFaultRecordAttachment");

                entity.HasOne(d => d.AttendantFaultRecordVO)
                    .WithMany(p => p.SaintEir_AttendantFaultRecordAttachments)
                    .HasForeignKey(d => d.AttendantFaultRecordVO_id)
                    .HasConstraintName("FK_85B0C829");

                entity.HasOne(d => d.FileNode)
                    .WithMany(p => p.SaintEir_AttendantFaultRecordAttachments)
                    .HasForeignKey(d => d.FileNode_id)
                    .HasConstraintName("FK_878A83BB");
            });

            modelBuilder.Entity<SaintEir_AttendantFaultRule>(entity =>
            {
                entity.ToTable("SaintEir_AttendantFaultRule");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FaultContent)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FaultNo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Frequency).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.SaintEir_AttendantFaultRules)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_76ADF0B");
            });

            modelBuilder.Entity<SaintEir_AttendantFaultVersion>(entity =>
            {
                entity.ToTable("SaintEir_AttendantFaultVersion");

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.VersionName).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_BHClassify>(entity =>
            {
                entity.HasKey(e => e.ClassNo);

                entity.ToTable("SaintEir_BHClassify");

                entity.Property(e => e.ClassChtTitle).HasMaxLength(30);

                entity.Property(e => e.ClassCode).HasMaxLength(10);

                entity.Property(e => e.ClassEngTitle).HasMaxLength(30);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_BHMaterial>(entity =>
            {
                entity.HasKey(e => e.MaterialNo)
                    .HasName("PK__SaintEir_BHMateria__7D2E8C24");

                entity.ToTable("SaintEir_BHMaterial");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.ClientPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CombinationQuantity).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Command).HasMaxLength(500);

                entity.Property(e => e.CompanyCost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ConsumptionQuantity).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ConsumptionRatio).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HQClassCode).HasMaxLength(50);

                entity.Property(e => e.MCode).HasMaxLength(20);

                entity.Property(e => e.MaterialID).HasMaxLength(20);

                entity.Property(e => e.PresentQuantity).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PresentSafetyQuantity).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ReplenishUnit).HasMaxLength(20);

                entity.Property(e => e.SafetyQuantity).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_BHMaterialChangeLog>(entity =>
            {
                entity.HasKey(e => e.ChangeLogNo);

                entity.ToTable("SaintEir_BHMaterialChangeLog");

                entity.Property(e => e.ChangeQuantity).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ChangedBy).HasMaxLength(255);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_BalanceSheet>(entity =>
            {
                entity.HasKey(e => e.BalanceSheetNo)
                    .HasName("PK__SaintEir_Balance__6C040022");

                entity.ToTable("SaintEir_BalanceSheet");

                entity.Property(e => e.AccountsPayable).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.AccountsReceivable).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.AccruedExpenses).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.AccumulatedProfitAndLoss).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.Buildings).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.CapitalStock).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Cash).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.CashInBanks).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.CurrentProfitAndLoss).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.DeBuildings).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.DeMachinery).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.DeOtherFixedAssets).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.DeTransportation).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.DueToBanks).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.GuaranteeDepositsPaid).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Inventories).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Land).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Machinery).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.NotesPayable).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.NotesReceivable).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.OtherAccruedExpenses).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.OtherAdvanceReceiptsSalary).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.OtherFixedAssets).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.PettyCash).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.PrepaidExpenses).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.PrepaymentsToSuppliers).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ShareholderAccounts).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.TemporarySaintSin).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Temporaryhan).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Transportation).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.dateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_BodyMeasurement>(entity =>
            {
                entity.HasKey(e => e.BodyMeasurementNo);

                entity.ToTable("SaintEir_BodyMeasurement");

                entity.Property(e => e.BMI).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BodyFat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MuscleArms).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MuscleBody).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MuscleLegs).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MuscleTrunk).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SFatArms).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SFatBody).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SFatLegs).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SFatTrunk).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VFat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SaintEir_Branch>(entity =>
            {
                entity.HasKey(e => e.BranchNo)
                    .HasName("PK__SaintEir_Branch__66EA454A");

                entity.ToTable("SaintEir_Branch");

                entity.Property(e => e.BranchNo).HasMaxLength(20);

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(50)
                    .HasComment("公司簡稱");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasComment("營業地址");

                entity.Property(e => e.AgentCertificateNo)
                    .HasMaxLength(50)
                    .HasComment("代理申報人證書(登錄)字號");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .HasComment("(代理)申報人身分證統一編號");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(50)
                    .HasComment("(代理)申報人姓名");

                entity.Property(e => e.AgentTel)
                    .HasMaxLength(50)
                    .HasComment("(代理)申報人電話");

                entity.Property(e => e.BranchCode).HasMaxLength(20);

                entity.Property(e => e.BranchPic1).HasMaxLength(255);

                entity.Property(e => e.BranchPic2).HasMaxLength(255);

                entity.Property(e => e.BranchPic3).HasMaxLength(255);

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(8)
                    .HasComment("統一編號");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .HasComment("聯絡人員");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasComment("E-Mail");

                entity.Property(e => e.EngName)
                    .HasMaxLength(128)
                    .HasComment("英文名稱");

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.HealthInsuranceNo)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("健康保險證號");

                entity.Property(e => e.HousingTaxID)
                    .HasMaxLength(50)
                    .HasComment("房屋稅籍編號");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceControDate)
                    .HasMaxLength(4)
                    .HasComment("發票控管日期");

                entity.Property(e => e.Is_CombineInOut).HasComment("進銷資料併總公司合併申報");

                entity.Property(e => e.LaborInsuranceNo)
                    .HasMaxLength(50)
                    .HasComment("勞工保險證號");

                entity.Property(e => e.MainCompanyId).HasComment("總機構公司");

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(255)
                    .HasComment("EIP部門主管Id");

                entity.Property(e => e.MediaReportCode)
                    .HasMaxLength(50)
                    .HasComment("媒體申報代號");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.OldBranchNo).HasMaxLength(20);

                entity.Property(e => e.ParentId).HasComment("隸屬部門Id");

                entity.Property(e => e.PostOfficeName)
                    .HasMaxLength(50)
                    .HasComment("郵局名稱");

                entity.Property(e => e.PostOfficeNo)
                    .HasMaxLength(50)
                    .HasComment("郵局局號");

                entity.Property(e => e.Principal)
                    .HasMaxLength(50)
                    .HasComment("負責人");

                entity.Property(e => e.RetirementFundNo)
                    .HasMaxLength(50)
                    .HasComment("勞退提繳證號");

                entity.Property(e => e.TaxCityId).HasComment("稅捐縣市");

                entity.Property(e => e.TaxOfficeNo)
                    .HasMaxLength(50)
                    .HasComment("稽徵機關編號");

                entity.Property(e => e.TaxRegNo)
                    .HasMaxLength(16)
                    .HasComment("稅籍編號");

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.Property(e => e.Web).HasMaxLength(200);

                entity.Property(e => e.ZIP)
                    .HasMaxLength(5)
                    .HasComment("營業郵遞區號");

                entity.Property(e => e.p_DeclareMemo).HasComment("自行或委託辦理申報註記");

                entity.Property(e => e.p_DeclareType).HasComment("申報種類");

                entity.Property(e => e.p_HIBureau).HasComment("健保分局別");

                entity.Property(e => e.p_TotalPay).HasComment("總繳代號");
            });

            modelBuilder.Entity<SaintEir_BranchAchievement>(entity =>
            {
                entity.HasKey(e => e.AchievementDisNo);

                entity.ToTable("SaintEir_BranchAchievement");

                entity.Property(e => e.AchievementAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AchievementDate).HasColumnType("datetime");

                entity.Property(e => e.BelongToBranch).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_BranchInCCategory>(entity =>
            {
                entity.ToTable("SaintEir_BranchInCCategory");

                entity.Property(e => e.BranchNo).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_BranchOrderSet>(entity =>
            {
                entity.HasKey(e => e.BranchOrderSetNo);

                entity.ToTable("SaintEir_BranchOrderSet");

                entity.Property(e => e.BelongToBranch).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_Calendar>(entity =>
            {
                entity.ToTable("SaintEir_Calendar");

                entity.HasComment("日曆主檔");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Is_Holiday).HasComment("例假日必需上班");

                entity.Property(e => e.Is_Weekend).HasComment("週末必需上班");

                entity.Property(e => e.Is_WorkingDay).HasComment("平日必需上班");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("名稱");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_CalendarDay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_CalendarDay");

                entity.HasComment("日曆明細( 單日設定)");

                entity.Property(e => e.CalendarId).HasComment("日曆編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Day)
                    .HasColumnType("date")
                    .HasComment("日期");

                entity.Property(e => e.HolidayName)
                    .HasMaxLength(128)
                    .HasComment("假日名稱");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_Off).HasComment("放假日(1)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WeekDay).HasComment("星期幾(0=sunday)");

                entity.Property(e => e.Year).HasComment("年份");
            });

            modelBuilder.Entity<SaintEir_CalendarDay_backup_KillAfter20220101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_CalendarDay_backup_KillAfter20220101");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Day).HasColumnType("date");

                entity.Property(e => e.HolidayName).HasMaxLength(128);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_CallHistory>(entity =>
            {
                entity.HasKey(e => e.CallHistoryNo)
                    .HasName("PK__SaintEir_CallHis__76B698BF");

                entity.ToTable("SaintEir_CallHistory");

                entity.Property(e => e.BelongToAttendant).HasMaxLength(255);

                entity.Property(e => e.CallDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TreatmentType).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BelongToAttendantNavigation)
                    .WithMany(p => p.SaintEir_CallHistories)
                    .HasForeignKey(d => d.BelongToAttendant)
                    .HasConstraintName("FKBA3353A3C7E73832");

                entity.HasOne(d => d.BelongToMemberNavigation)
                    .WithMany(p => p.SaintEir_CallHistories)
                    .HasForeignKey(d => d.BelongToMember)
                    .HasConstraintName("FKBA3353A3361AFB2D");
            });

            modelBuilder.Entity<SaintEir_CashFlowClassify>(entity =>
            {
                entity.HasKey(e => e.CashFlowClassifyNo);

                entity.ToTable("SaintEir_CashFlowClassify");

                entity.Property(e => e.CashFlowClassifyName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_CashFlowForecast>(entity =>
            {
                entity.HasKey(e => e.CashFlowForecastNo);

                entity.ToTable("SaintEir_CashFlowForecast");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_CashFlowMapping>(entity =>
            {
                entity.HasKey(e => e.CashFlowMappingNo)
                    .HasName("PK_SaintEir_CashFlowMapping_1");

                entity.ToTable("SaintEir_CashFlowMapping");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_CashFlowStatement>(entity =>
            {
                entity.HasKey(e => e.CashFlowStatementNo);

                entity.ToTable("SaintEir_CashFlowStatement");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_CashForecast>(entity =>
            {
                entity.HasKey(e => e.CashFlowForecastNo);

                entity.ToTable("SaintEir_CashForecast");

                entity.Property(e => e.BelongToBranch).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_CategoryMappingProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_CategoryMappingProduct");

                entity.Property(e => e.BelongToBranch).HasMaxLength(128);

                entity.Property(e => e.BelongToCategoryType)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<SaintEir_CheckInOrder>(entity =>
            {
                entity.HasKey(e => e.CheckInOrderNo)
                    .HasName("PK__SaintEir__E507A9A3B8545A30");

                entity.ToTable("SaintEir_CheckInOrder");

                entity.Property(e => e.BelongToUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_City>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_City");

                entity.HasComment("台灣稅捐縣市資料");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EngName)
                    .HasMaxLength(128)
                    .HasComment("英文名稱");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasComment("縣市名稱");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_Classify>(entity =>
            {
                entity.HasKey(e => e.ClassNo);

                entity.ToTable("SaintEir_Classify");

                entity.Property(e => e.ClassChtTitle).HasMaxLength(30);

                entity.Property(e => e.ClassCode).HasMaxLength(10);

                entity.Property(e => e.ClassEngTitle).HasMaxLength(30);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ClinicClassify>(entity =>
            {
                entity.HasKey(e => e.ClinicClassifyNo)
                    .HasName("PK__SaintEir_ClinicC__4D7F7902");

                entity.ToTable("SaintEir_ClinicClassify");

                entity.Property(e => e.ClassifyType).HasMaxLength(255);

                entity.Property(e => e.NameInChinese).HasMaxLength(255);

                entity.Property(e => e.NameInEnglish).HasMaxLength(255);

                entity.Property(e => e.ProductClassify).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_ClockInRecord>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Time });

                entity.ToTable("SaintEir_ClockInRecord");

                entity.HasComment("刷卡記錄");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasComment("使用者編號");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasComment("刷卡時間");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("卡號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.YMD)
                    .HasColumnType("datetime")
                    .HasComment("年月日");
            });

            modelBuilder.Entity<SaintEir_ClockInRecordFormat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_ClockInRecordFormat");

                entity.HasComment("刷卡格式設定");

                entity.Property(e => e.AfterMinutes).HasComment("下班後置時間(分)");

                entity.Property(e => e.BeforeMinutes).HasComment("上班前置時間(分)");

                entity.Property(e => e.CardNoEnd).HasComment("刷卡卡號終止碼數");

                entity.Property(e => e.CardNoStart).HasComment("刷卡卡號起始碼數");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("編號");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DayEnd).HasComment("日期終止碼數");

                entity.Property(e => e.DayStart).HasComment("日期起始碼數");

                entity.Property(e => e.En_YearFormat).HasComment("轉入年制格式");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.HourEnd).HasComment("時終止碼數");

                entity.Property(e => e.HourStart).HasComment("時起始碼數");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InOutStringEnd).HasComment("上/下班字串終止碼數");

                entity.Property(e => e.InOutStringStart).HasComment("上/下班字串起始碼數");

                entity.Property(e => e.InString)
                    .HasMaxLength(50)
                    .HasComment("上班字串");

                entity.Property(e => e.Is_InOutString).HasComment("上/下班字串");

                entity.Property(e => e.Length).HasComment("刷卡資料長度");

                entity.Property(e => e.MinuteEnd).HasComment("分終止碼數");

                entity.Property(e => e.MinuteStart).HasComment("分起始碼數");

                entity.Property(e => e.MonthEnd).HasComment("月份終止碼數");

                entity.Property(e => e.MonthStart).HasComment("月份起始碼數");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasComment("名稱");

                entity.Property(e => e.OrverTimeInString)
                    .HasMaxLength(50)
                    .HasComment("加班上班字串");

                entity.Property(e => e.OutString)
                    .HasMaxLength(50)
                    .HasComment("下班字串");

                entity.Property(e => e.OvertimeOutString)
                    .HasMaxLength(50)
                    .HasComment("加班下班字串");

                entity.Property(e => e.RepeatInterval).HasComment("重覆刷卡");

                entity.Property(e => e.StartLine).HasComment("資料起始列數");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.YearEnd).HasComment("年度終止碼數");

                entity.Property(e => e.YearStart).HasComment("年度起始碼數");
            });

            modelBuilder.Entity<SaintEir_CompetitionReward>(entity =>
            {
                entity.HasKey(e => e.CompetitionRewardNo)
                    .HasName("PK__SaintEir_Competi__4119A21D");

                entity.ToTable("SaintEir_CompetitionReward");

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_Compliant>(entity =>
            {
                entity.HasKey(e => e.CompliantNo);

                entity.ToTable("SaintEir_Compliant");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.ByChecker).HasMaxLength(255);

                entity.Property(e => e.ByDr).HasMaxLength(255);

                entity.Property(e => e.ByFollowerA).HasMaxLength(255);

                entity.Property(e => e.ByFollowerB).HasMaxLength(255);

                entity.Property(e => e.CompliantDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LossAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Responsibility).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_CompliantHistory>(entity =>
            {
                entity.HasKey(e => e.CompliantHistoryNo);

                entity.ToTable("SaintEir_CompliantHistory");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FollowDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ComsumptionHistory>(entity =>
            {
                entity.HasKey(e => e.ConsumptionHistoryNo)
                    .HasName("PK__SaintEir_Comsump__6A85CC04");

                entity.ToTable("SaintEir_ComsumptionHistory");

                entity.HasIndex(e => e.BelongToInProcessService, "IDX_SaintEir_ComsumptionHistory_BelongToInProcessService");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.ByChecker).HasMaxLength(255);

                entity.Property(e => e.ByDr).HasMaxLength(255);

                entity.Property(e => e.ByFollowerA).HasMaxLength(255);

                entity.Property(e => e.ByFollowerB).HasMaxLength(255);

                entity.Property(e => e.ByReminderA).HasMaxLength(50);

                entity.Property(e => e.ByReminderB).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.ConsumptionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.SAamount).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UseUnit).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.BelongToPurchaseNavigation)
                    .WithMany(p => p.SaintEir_ComsumptionHistories)
                    .HasForeignKey(d => d.BelongToPurchase)
                    .HasConstraintName("FK146DB79CE46791E8");
            });

            modelBuilder.Entity<SaintEir_Config>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("SaintEir_Config");

                entity.HasComment("設定表");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasComment("設定名稱");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Value).HasComment("設定值");
            });

            modelBuilder.Entity<SaintEir_ConfirmRelative>(entity =>
            {
                entity.HasKey(e => e.ConfirmRelativeNo)
                    .HasName("PK__SaintEir__C11CF636ABE30FEA");

                entity.ToTable("SaintEir_ConfirmRelative");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ConfirmRelativeItem>(entity =>
            {
                entity.HasKey(e => e.ConfirmRelativeItemNo)
                    .HasName("PK__SaintEir__81040313E8347A9B");

                entity.ToTable("SaintEir_ConfirmRelativeItem");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.ValueType).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_Consumable>(entity =>
            {
                entity.HasKey(e => e.ConsumableNo)
                    .HasName("PK__SaintEir_Consuma__7F16D496");

                entity.ToTable("SaintEir_Consumable");

                entity.Property(e => e.BHConsumableQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.ConsumableQuantity).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SaintEir_ConversionValue>(entity =>
            {
                entity.HasKey(e => e.ConversionValueNo);

                entity.ToTable("SaintEir_ConversionValue");

                entity.Property(e => e.ConversionValueNo).ValueGeneratedNever();

                entity.Property(e => e.UnitCC).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitU).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<SaintEir_Country>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_Country");

                entity.HasComment("國家");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("編號");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EngName)
                    .HasMaxLength(128)
                    .HasComment("英文名稱");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasComment("名稱");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_Credit>(entity =>
            {
                entity.HasKey(e => e.CreditNo);

                entity.ToTable("SaintEir_Credit");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.CardNo).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditDate).HasColumnType("datetime");

                entity.Property(e => e.RemainCredit).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.RetriveBy).HasMaxLength(255);

                entity.Property(e => e.RetriveDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.TotalCredit).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_CustomCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryNo)
                    .HasName("PK_CustomCategory");

                entity.ToTable("SaintEir_CustomCategory");

                entity.Property(e => e.CategoryType).HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ProductClassify).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_DBSetting>(entity =>
            {
                entity.HasKey(e => e.DBSNo);

                entity.ToTable("SaintEir_DBSetting");

                entity.Property(e => e.BelongToBranch).HasMaxLength(50);

                entity.Property(e => e.CategoryTitle).HasMaxLength(100);

                entity.Property(e => e.KeyValue).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_DRConsultationFee>(entity =>
            {
                entity.HasKey(e => e.DRConsultationFeeNo);

                entity.ToTable("SaintEir_DRConsultationFee");

                entity.Property(e => e.BelongToLoginUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeanOfBranch).HasMaxLength(50);

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.HIBranch).HasMaxLength(50);

                entity.Property(e => e.Hour).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.LaborRetirementBranch).HasMaxLength(50);

                entity.Property(e => e.ListingBranch).HasMaxLength(50);

                entity.Property(e => e.ListingFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnitWorkTime).HasColumnType("decimal(18, 1)");
            });

            modelBuilder.Entity<SaintEir_DRConsultationFeeWeekDay>(entity =>
            {
                entity.HasKey(e => e.DRConsultationFeeWeekDayNo);

                entity.ToTable("SaintEir_DRConsultationFeeWeekDay");

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaxWorkTime).HasColumnType("decimal(18, 1)");

                entity.HasOne(d => d.DRConsultationFeeNoNavigation)
                    .WithMany(p => p.SaintEir_DRConsultationFeeWeekDays)
                    .HasForeignKey(d => d.DRConsultationFeeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaintEir_DRConsultationFeeWeekDay_SaintEir_DRConsultationFee");
            });

            modelBuilder.Entity<SaintEir_DRReward>(entity =>
            {
                entity.HasKey(e => e.DRRewardNo);

                entity.ToTable("SaintEir_DRReward");

                entity.Property(e => e.BelongToANo).HasMaxLength(50);

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);

                entity.Property(e => e.ClassifyName).HasMaxLength(50);

                entity.Property(e => e.CostFee).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Expression).HasMaxLength(255);

                entity.Property(e => e.FlotationCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.IntroFee).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RationDate).HasColumnType("datetime");

                entity.Property(e => e.RewardAmout).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RewardDate).HasColumnType("datetime");

                entity.Property(e => e.RewardMoney).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RewardPercentage).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.SoldOutPrice).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_DRRewardDaily>(entity =>
            {
                entity.HasKey(e => e.DRRewardDailyNo);

                entity.ToTable("SaintEir_DRRewardDaily");

                entity.Property(e => e.BelongToBranch).HasMaxLength(50);

                entity.Property(e => e.BelongToLoginUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Bonus).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ConsultationFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.RationDate).HasColumnType("datetime");

                entity.Property(e => e.Result).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SaintEir_DRService>(entity =>
            {
                entity.HasKey(e => e.DRServiceNo);

                entity.ToTable("SaintEir_DRService");

                entity.Property(e => e.BelongToBranch).HasMaxLength(255);

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Expression).HasMaxLength(255);

                entity.Property(e => e.FeeOffDutyTime).HasColumnType("datetime");

                entity.Property(e => e.OffDutyTime).HasColumnType("datetime");

                entity.Property(e => e.OffDutyTimeUpdatedBy).HasMaxLength(255);

                entity.Property(e => e.OnDutyTime).HasColumnType("datetime");

                entity.Property(e => e.OnDutyTimeUpdatedBy).HasMaxLength(255);

                entity.Property(e => e.RationDate).HasColumnType("datetime");

                entity.Property(e => e.ReviseOffDutyTime).HasColumnType("datetime");

                entity.Property(e => e.ReviseOffDutyTimeUpdatedBy).HasMaxLength(255);

                entity.Property(e => e.ReviseOnDutyTime).HasColumnType("datetime");

                entity.Property(e => e.ReviseOnDutyTimeUpdatedBy).HasMaxLength(255);

                entity.Property(e => e.ServiceCount).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceFee).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.TotalServiceFee).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.WorkTime).HasColumnType("decimal(9, 1)");
            });

            modelBuilder.Entity<SaintEir_DRServiceFee>(entity =>
            {
                entity.HasKey(e => e.DRServiceFeeNo);

                entity.ToTable("SaintEir_DRServiceFee");

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceFee).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_DRServiceLog>(entity =>
            {
                entity.ToTable("SaintEir_DRServiceLog");

                entity.Property(e => e.CheckInTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_DailyBalance>(entity =>
            {
                entity.HasKey(e => e.BalanceNo);

                entity.ToTable("SaintEir_DailyBalance");

                entity.Property(e => e.BalanceDate).HasColumnType("datetime");

                entity.Property(e => e.BelongToBranch).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InComeFromOtherB).HasMaxLength(50);

                entity.Property(e => e.OthersInComeB).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_DailyBalanceItem>(entity =>
            {
                entity.HasKey(e => e.BalanceItemNo);

                entity.ToTable("SaintEir_DailyBalanceItem");

                entity.Property(e => e.CateroryTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<SaintEir_Declare>(entity =>
            {
                entity.HasKey(e => e.DeclareNo)
                    .HasName("PK__SaintEir_Declare__6CA31EA0");

                entity.ToTable("SaintEir_Declare");

                entity.Property(e => e.BelongToBranch).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeclareTitle).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.ToDepartment).HasMaxLength(100);

                entity.Property(e => e.ToJobTitle).HasMaxLength(100);

                entity.Property(e => e.ToLoginUser).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_DeclareFile>(entity =>
            {
                entity.HasKey(e => e.DeclareFileNo);

                entity.ToTable("SaintEir_DeclareFile");

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.UploadFileName).HasMaxLength(100);
            });

            modelBuilder.Entity<SaintEir_Department>(entity =>
            {
                entity.ToTable("SaintEir_Department");

                entity.HasComment("部門");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("編號");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentAnnualLeaveType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("發放特休 = 1, 不發放特休 = -1");

                entity.Property(e => e.EngName)
                    .HasMaxLength(128)
                    .HasComment("英文名稱");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Is_BirthdayBonus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);

                entity.Property(e => e.Is_CashSalary)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.LevelCode)
                    .HasMaxLength(50)
                    .HasComment("階層編號");

                entity.Property(e => e.LockedYM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('000000')")
                    .HasComment("鎖定的年月");

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(255)
                    .HasComment("主管會員編號");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasComment("名稱");

                entity.Property(e => e.UpDepartmentId).HasComment("上層部門編號");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.p_ScheduleType)
                    .HasDefaultValueSql("((88))")
                    .HasComment("排班類別");
            });

            modelBuilder.Entity<SaintEir_Department_Calendar>(entity =>
            {
                entity.HasKey(e => new { e.Year, e.DepartmentId });

                entity.ToTable("SaintEir_Department_Calendar");

                entity.HasComment("部門出勤曆");

                entity.Property(e => e.Year).HasComment("年度");

                entity.Property(e => e.DepartmentId).HasComment("部門編號");

                entity.Property(e => e.CalendarId).HasComment("出勤曆編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_DigitalFile>(entity =>
            {
                entity.HasKey(e => e.DigitalFileNo)
                    .HasName("PK__SaintEir__5AA5FEA86AC0D43A");

                entity.ToTable("SaintEir_DigitalFile");

                entity.Property(e => e.Category).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Custom).HasMaxLength(100);

                entity.Property(e => e.FilePath).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UploadFileName).HasMaxLength(100);

                entity.HasOne(d => d.BelongToMedicalRecordNavigation)
                    .WithMany(p => p.SaintEir_DigitalFiles)
                    .HasForeignKey(d => d.BelongToMedicalRecord)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaintEir_DigitalFile_MedicalRecord");

                entity.HasOne(d => d.BelongToSignDocNavigation)
                    .WithMany(p => p.SaintEir_DigitalFiles)
                    .HasForeignKey(d => d.BelongToSignDoc)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaintEir_DigitalFile_SaintEir_SignDoc");
            });

            modelBuilder.Entity<SaintEir_DocRequireHistory>(entity =>
            {
                entity.HasKey(e => e.DocRequireHistoryNo)
                    .HasName("PK__SaintEir__F2DF1D10BE413C9B");

                entity.ToTable("SaintEir_DocRequireHistory");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Source).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BelongToConsumptionHistoryNavigation)
                    .WithMany(p => p.SaintEir_DocRequireHistories)
                    .HasForeignKey(d => d.BelongToConsumptionHistory)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaintEir_DocRequireHistory_SaintEir_ComsumptionHistory");

                entity.HasOne(d => d.BelongToMedicalRecordNavigation)
                    .WithMany(p => p.SaintEir_DocRequireHistories)
                    .HasForeignKey(d => d.BelongToMedicalRecord)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaintEir_DocRequireHistory_MedicalRecord");

                entity.HasOne(d => d.BelongToSignDocNavigation)
                    .WithMany(p => p.SaintEir_DocRequireHistories)
                    .HasForeignKey(d => d.BelongToSignDoc)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaintEir_DocRequireHistory_SaintEir_SignDoc");
            });

            modelBuilder.Entity<SaintEir_DoctorRewardConfig>(entity =>
            {
                entity.HasKey(e => e.DoctorRewardConfigNo);

                entity.ToTable("SaintEir_DoctorRewardConfig");

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);

                entity.Property(e => e.ClassifySetList).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_DoctorSkill>(entity =>
            {
                entity.HasKey(e => e.DcotorSkillNo);

                entity.ToTable("SaintEir_DoctorSkill");

                entity.Property(e => e.BelongToUser).HasMaxLength(20);
            });

            modelBuilder.Entity<SaintEir_DrOrderQuickWord>(entity =>
            {
                entity.HasKey(e => e.QuickWordNo)
                    .HasName("PK_SaintEir_DrOrderQuickWordVO");

                entity.ToTable("SaintEir_DrOrderQuickWord");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.KeyWord).HasMaxLength(50);

                entity.Property(e => e.OrderType).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_DrWorkDay>(entity =>
            {
                entity.HasKey(e => e.DrWorkDayNo);

                entity.ToTable("SaintEir_DrWorkDay");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToUser).HasMaxLength(20);

                entity.Property(e => e.DayOfWeek).HasMaxLength(20);

                entity.Property(e => e.EndHour).HasMaxLength(20);

                entity.Property(e => e.StartHour).HasMaxLength(20);
            });

            modelBuilder.Entity<SaintEir_EMailLog>(entity =>
            {
                entity.ToTable("SaintEir_EMailLog");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_EMailLog_Address>(entity =>
            {
                entity.ToTable("SaintEir_EMailLog_Address");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.EMailLog)
                    .WithMany(p => p.SaintEir_EMailLog_Addresses)
                    .HasForeignKey(d => d.EMailLogID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaintEir_EMailLog_Address_SaintEir_EMailLog");
            });

            modelBuilder.Entity<SaintEir_EMailLog_Attachment>(entity =>
            {
                entity.ToTable("SaintEir_EMailLog_Attachment");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.EMailLog)
                    .WithMany(p => p.SaintEir_EMailLog_Attachments)
                    .HasForeignKey(d => d.EMailLogID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaintEir_EMailLog_Attachment_SaintEir_EMailLog");
            });

            modelBuilder.Entity<SaintEir_EMailWording>(entity =>
            {
                entity.HasKey(e => e.EMailWordingNo)
                    .HasName("PK__SaintEir__A20212B12E8EEDB5");

                entity.ToTable("SaintEir_EMailWording");

                entity.Property(e => e.ContentPath).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LanguageCode).HasMaxLength(50);

                entity.Property(e => e.RelpyUrl).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_Edm>(entity =>
            {
                entity.HasKey(e => e.EdmNo)
                    .HasName("PK__CcaArt_Edm__07F6335A");

                entity.ToTable("SaintEir_Edm");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_Education>(entity =>
            {
                entity.ToTable("SaintEir_Education");

                entity.HasComment("學歷資料");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("學歷編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EngName)
                    .HasMaxLength(50)
                    .HasComment("英文名稱");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("學歷名稱");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_EmployeeType>(entity =>
            {
                entity.ToTable("SaintEir_EmployeeType");

                entity.HasComment("員工類型資料");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("職等編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDay).HasComment("出勤區間結束日");

                entity.Property(e => e.EngName)
                    .HasMaxLength(50)
                    .HasComment("英文名稱");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Is_EndLastMonth).HasComment("出勤區間上個月結束");

                entity.Property(e => e.Is_StartLastMonth).HasComment("出勤區間上個月開始");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("職等名稱");

                entity.Property(e => e.StartDay).HasComment("出勤區間開始日");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_EmployeeWorkDay>(entity =>
            {
                entity.HasKey(e => e.EmployeeWorkDayNo);

                entity.ToTable("SaintEir_EmployeeWorkDay");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToUser).HasMaxLength(20);

                entity.Property(e => e.DayOfWeek).HasMaxLength(20);

                entity.Property(e => e.EndTime).HasMaxLength(20);

                entity.Property(e => e.StartTime).HasMaxLength(20);

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_EventHistory>(entity =>
            {
                entity.HasKey(e => e.EventHistoryNo);

                entity.ToTable("SaintEir_EventHistory");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(30);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_FSFileVirtualNode>(entity =>
            {
                entity.ToTable("SaintEir_FSFileVirtualNode");

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Extension).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.PhysicalPath).HasMaxLength(255);

                entity.Property(e => e.RelativePath).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_Favorite>(entity =>
            {
                entity.HasKey(e => e.FavoriteId);

                entity.ToTable("SaintEir_Favorite");

                entity.Property(e => e.UserId).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_FlotationCost>(entity =>
            {
                entity.HasKey(e => e.FlotationCostsNo);

                entity.Property(e => e.FlotationCostsAmount).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SaintEir_GoodsExchange>(entity =>
            {
                entity.HasKey(e => e.GoodsExchangeNo);

                entity.ToTable("SaintEir_GoodsExchange");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Credit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ExchangeDate).HasColumnType("datetime");

                entity.Property(e => e.ProductWorth).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_GoodsRefund>(entity =>
            {
                entity.HasKey(e => e.GoodsRefundNo);

                entity.ToTable("SaintEir_GoodsRefund");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Credit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ProductWorth).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RefundDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_GuestIntroduction>(entity =>
            {
                entity.ToTable("SaintEir_GuestIntroduction");

                entity.Property(e => e.ConsumptionAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_HealthInsuranceAdj>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_HealthInsuranceAdj");

                entity.HasComment("健保調整記錄");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DeleterId).HasMaxLength(255);

                entity.Property(e => e.Dependent)
                    .HasMaxLength(128)
                    .HasComment("親屬姓名");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasComment("生效日期");

                entity.Property(e => e.En_SubSidy)
                    .HasDefaultValueSql("((0))")
                    .HasComment("補助類別$百分之100=100,百分之75=200,百分之50=300,百分之25=400,定額749=500");

                entity.Property(e => e.En_Type).HasComment("異動類別$加保=100,修改投保薪資=200,退保=300,眷屬加保=400,眷屬退保=500");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdCardNo).HasMaxLength(50);

                entity.Property(e => e.InsuranceDepartment).HasMaxLength(32);

                entity.Property(e => e.Salary).HasComment("投保薪資");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_HealthInsuranceAmount>(entity =>
            {
                entity.ToTable("SaintEir_HealthInsuranceAmount");

                entity.HasOne(d => d.VersionNavigation)
                    .WithMany(p => p.SaintEir_HealthInsuranceAmounts)
                    .HasForeignKey(d => d.Version)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaintEir_HealthInsuranceAmount_SaintEir_HealthInsuranceVersion");
            });

            modelBuilder.Entity<SaintEir_HealthInsuranceVersion>(entity =>
            {
                entity.ToTable("SaintEir_HealthInsuranceVersion");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_Holiday>(entity =>
            {
                entity.ToTable("SaintEir_Holiday");

                entity.HasComment("共用例假日");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Days).HasComment("放假天數");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("假期名稱");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("開始日期(mm-dd)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_IOB>(entity =>
            {
                entity.HasKey(e => e.IOBNo)
                    .HasName("PK_SaintEir_Replenish");

                entity.ToTable("SaintEir_IOB");

                entity.Property(e => e.AfterTaxPrice).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.BeforeTaxPrice).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IOBDate).HasColumnType("datetime");

                entity.Property(e => e.NoteNo).HasMaxLength(255);

                entity.Property(e => e.ReceiptNumber).HasMaxLength(50);

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_IOBItem>(entity =>
            {
                entity.HasKey(e => e.IOBItemNo)
                    .HasName("PK_SaintEir_ReplenishItem");

                entity.ToTable("SaintEir_IOBItem");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_InComeAssign>(entity =>
            {
                entity.HasKey(e => e.AssignNo);

                entity.ToTable("SaintEir_InComeAssign");

                entity.Property(e => e.AssignAR).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AssignInCome).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_InProcessService>(entity =>
            {
                entity.HasKey(e => e.InProcessServiceNo)
                    .HasName("PK__SaintEir_InProce__78D3EB5B");

                entity.ToTable("SaintEir_InProcessService");

                entity.HasIndex(e => e.ByMember, "IDX_SaintEir_InProcessService_ByMember");

                entity.HasIndex(e => e.StartDate, "IDX_SaintEir_InProcessService_StartDate");

                entity.Property(e => e.AuthBy).HasMaxLength(20);

                entity.Property(e => e.AuthCode).HasMaxLength(20);

                entity.Property(e => e.AuthDate).HasColumnType("datetime");

                entity.Property(e => e.AuthLimitDate).HasColumnType("datetime");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToDoctor).HasMaxLength(20);

                entity.Property(e => e.Commant).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ServeBy).HasMaxLength(255);

                entity.Property(e => e.ServeBy2).HasMaxLength(20);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.HasOne(d => d.BelongToSignatureNavigation)
                    .WithMany(p => p.SaintEir_InProcessServices)
                    .HasForeignKey(d => d.BelongToSignature)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaintEir_InProcessService_SaintEir_Signature");

                entity.HasOne(d => d.ByMemberNavigation)
                    .WithMany(p => p.SaintEir_InProcessServices)
                    .HasForeignKey(d => d.ByMember)
                    .HasConstraintName("FKCDD8DC91591B7BFC");
            });

            modelBuilder.Entity<SaintEir_InbodySRecord>(entity =>
            {
                entity.HasKey(e => e.TestID)
                    .HasName("PK__SaintEir__8CC33100C495CA7C");

                entity.ToTable("SaintEir_InbodySRecord");

                entity.Property(e => e.AMC_ArmMuscleCircumference_)
                    .HasMaxLength(255)
                    .HasColumnName("AMC(ArmMuscleCircumference)");

                entity.Property(e => e.Age).HasMaxLength(255);

                entity.Property(e => e.BCM_BodyCellMass_)
                    .HasMaxLength(255)
                    .HasColumnName("BCM(BodyCellMass)");

                entity.Property(e => e.BFMControl).HasMaxLength(255);

                entity.Property(e => e.BFMEvaluation).HasMaxLength(255);

                entity.Property(e => e.BFM_BodyFatMass_)
                    .HasMaxLength(255)
                    .HasColumnName("BFM(BodyFatMass)");

                entity.Property(e => e.BFM_ofLeftArm)
                    .HasMaxLength(255)
                    .HasColumnName("BFM%ofLeftArm");

                entity.Property(e => e.BFM_ofLeftLeg)
                    .HasMaxLength(255)
                    .HasColumnName("BFM%ofLeftLeg");

                entity.Property(e => e.BFM_ofRightArm)
                    .HasMaxLength(255)
                    .HasColumnName("BFM%ofRightArm");

                entity.Property(e => e.BFM_ofRightLeg)
                    .HasMaxLength(255)
                    .HasColumnName("BFM%ofRightLeg");

                entity.Property(e => e.BFM_ofTrunk)
                    .HasMaxLength(255)
                    .HasColumnName("BFM%ofTrunk");

                entity.Property(e => e.BFMofLeftArm).HasMaxLength(255);

                entity.Property(e => e.BFMofLeftLeg).HasMaxLength(255);

                entity.Property(e => e.BFMofRightArm).HasMaxLength(255);

                entity.Property(e => e.BFMofRightLeg).HasMaxLength(255);

                entity.Property(e => e.BFMofTrunk).HasMaxLength(255);

                entity.Property(e => e.BMC_BoneMineralContent_)
                    .HasMaxLength(255)
                    .HasColumnName("BMC(BoneMineralContent)");

                entity.Property(e => e.BMIEvaluation).HasMaxLength(255);

                entity.Property(e => e.BMI_BodyMassIndex_)
                    .HasMaxLength(255)
                    .HasColumnName("BMI(BodyMassIndex)");

                entity.Property(e => e.BMR_BasalMetabolicRate_)
                    .HasMaxLength(255)
                    .HasColumnName("BMR(BasalMetabolicRate)");

                entity.Property(e => e.BelongToMember).HasMaxLength(255);

                entity.Property(e => e.Diastolic).HasMaxLength(255);

                entity.Property(e => e.DryLeanMass).HasMaxLength(255);

                entity.Property(e => e.DryWeight).HasMaxLength(255);

                entity.Property(e => e.ECF_TBF)
                    .HasMaxLength(255)
                    .HasColumnName("ECF/TBF");

                entity.Property(e => e.ECF_TBFofLeftArm)
                    .HasMaxLength(255)
                    .HasColumnName("ECF/TBFofLeftArm");

                entity.Property(e => e.ECF_TBFofLeftLeg)
                    .HasMaxLength(255)
                    .HasColumnName("ECF/TBFofLeftLeg");

                entity.Property(e => e.ECF_TBFofRightArm)
                    .HasMaxLength(255)
                    .HasColumnName("ECF/TBFofRightArm");

                entity.Property(e => e.ECF_TBFofRightLeg)
                    .HasMaxLength(255)
                    .HasColumnName("ECF/TBFofRightLeg");

                entity.Property(e => e.ECF_TBFofTrunk)
                    .HasMaxLength(255)
                    .HasColumnName("ECF/TBFofTrunk");

                entity.Property(e => e.ECW_ExtracellularWater_)
                    .HasMaxLength(255)
                    .HasColumnName("ECW(ExtracellularWater)");

                entity.Property(e => e.ECW_TBW)
                    .HasMaxLength(255)
                    .HasColumnName("ECW/TBW");

                entity.Property(e => e.ECW_TBWofLeftArm)
                    .HasMaxLength(255)
                    .HasColumnName("ECW/TBWofLeftArm");

                entity.Property(e => e.ECW_TBWofLeftLeg)
                    .HasMaxLength(255)
                    .HasColumnName("ECW/TBWofLeftLeg");

                entity.Property(e => e.ECW_TBWofRightArm)
                    .HasMaxLength(255)
                    .HasColumnName("ECW/TBWofRightArm");

                entity.Property(e => e.ECW_TBWofRightLeg)
                    .HasMaxLength(255)
                    .HasColumnName("ECW/TBWofRightLeg");

                entity.Property(e => e.ECW_TBWofTrunk)
                    .HasMaxLength(255)
                    .HasColumnName("ECW/TBWofTrunk");

                entity.Property(e => e.ECWofLeftArm).HasMaxLength(255);

                entity.Property(e => e.ECWofLeftLeg).HasMaxLength(255);

                entity.Property(e => e.ECWofRightArm).HasMaxLength(255);

                entity.Property(e => e.ECWofRightLeg).HasMaxLength(255);

                entity.Property(e => e.ECWofTrunk).HasMaxLength(255);

                entity.Property(e => e.EvaluationofFFM_LBM_ofLeftArm)
                    .HasMaxLength(255)
                    .HasColumnName("EvaluationofFFM(LBM)ofLeftArm");

                entity.Property(e => e.EvaluationofFFM_LBM_ofLeftLeg)
                    .HasMaxLength(255)
                    .HasColumnName("EvaluationofFFM(LBM)ofLeftLeg");

                entity.Property(e => e.EvaluationofFFM_LBM_ofRightArm)
                    .HasMaxLength(255)
                    .HasColumnName("EvaluationofFFM(LBM)ofRightArm");

                entity.Property(e => e.EvaluationofFFM_LBM_ofRightLeg)
                    .HasMaxLength(255)
                    .HasColumnName("EvaluationofFFM(LBM)ofRightLeg");

                entity.Property(e => e.EvaluationofFFM_LBM_ofTrunk)
                    .HasMaxLength(255)
                    .HasColumnName("EvaluationofFFM(LBM)ofTrunk");

                entity.Property(e => e.EvaluationofFatofLeftArm).HasMaxLength(255);

                entity.Property(e => e.EvaluationofFatofLeftLeg).HasMaxLength(255);

                entity.Property(e => e.EvaluationofFatofRightArm).HasMaxLength(255);

                entity.Property(e => e.EvaluationofFatofRightLeg).HasMaxLength(255);

                entity.Property(e => e.EvaluationofFatofTrunk).HasMaxLength(255);

                entity.Property(e => e.FFMI_FatFreeMassIndex_)
                    .HasMaxLength(255)
                    .HasColumnName("FFMI(FatFreeMassIndex)");

                entity.Property(e => e.FFM_FatFreeMass__LBM_LeanBodyMass_)
                    .HasMaxLength(255)
                    .HasColumnName("FFM(FatFreeMass)/LBM(LeanBodyMass)");

                entity.Property(e => e.FFM_LBM_Control)
                    .HasMaxLength(255)
                    .HasColumnName("FFM(LBM)Control");

                entity.Property(e => e.FFM_LBM_ofLeftArm)
                    .HasMaxLength(255)
                    .HasColumnName("FFM(LBM)ofLeftArm");

                entity.Property(e => e.FFM_LBM_ofLeftLeg)
                    .HasMaxLength(255)
                    .HasColumnName("FFM(LBM)ofLeftLeg");

                entity.Property(e => e.FFM_LBM_ofRightArm)
                    .HasMaxLength(255)
                    .HasColumnName("FFM(LBM)ofRightArm");

                entity.Property(e => e.FFM_LBM_ofRightLeg)
                    .HasMaxLength(255)
                    .HasColumnName("FFM(LBM)ofRightLeg");

                entity.Property(e => e.FFM_LBM_ofTrunk)
                    .HasMaxLength(255)
                    .HasColumnName("FFM(LBM)ofTrunk");

                entity.Property(e => e.FFM__LBM__ofLeftArm)
                    .HasMaxLength(255)
                    .HasColumnName("FFM%(LBM%)ofLeftArm");

                entity.Property(e => e.FFM__LBM__ofLeftLeg)
                    .HasMaxLength(255)
                    .HasColumnName("FFM%(LBM%)ofLeftLeg");

                entity.Property(e => e.FFM__LBM__ofRightArm)
                    .HasMaxLength(255)
                    .HasColumnName("FFM%(LBM%)ofRightArm");

                entity.Property(e => e.FFM__LBM__ofRightLeg)
                    .HasMaxLength(255)
                    .HasColumnName("FFM%(LBM%)ofRightLeg");

                entity.Property(e => e.FFM__LBM__ofTrunk)
                    .HasMaxLength(255)
                    .HasColumnName("FFM%(LBM%)ofTrunk");

                entity.Property(e => e.FMI_FatMassIndex_)
                    .HasMaxLength(255)
                    .HasColumnName("FMI(FatMassIndex)");

                entity.Property(e => e.FatEvaluation).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.GrowthScore).HasMaxLength(255);

                entity.Property(e => e.Height).HasMaxLength(255);

                entity.Property(e => e.ICW_IntracellularWater_)
                    .HasMaxLength(255)
                    .HasColumnName("ICW(IntracellularWater)");

                entity.Property(e => e.ICWofLeftArm).HasMaxLength(255);

                entity.Property(e => e.ICWofLeftLeg).HasMaxLength(255);

                entity.Property(e => e.ICWofRightArm).HasMaxLength(255);

                entity.Property(e => e.ICWofRightLeg).HasMaxLength(255);

                entity.Property(e => e.ICWofTrunk).HasMaxLength(255);

                entity.Property(e => e.ID).HasMaxLength(255);

                entity.Property(e => e.InBodyScore).HasMaxLength(255);

                entity.Property(e => e.LowerBodyBalanceEvaluation).HasMaxLength(255);

                entity.Property(e => e.LowerBodyStrengthEvaluation).HasMaxLength(255);

                entity.Property(e => e.LowerLimit_BCMNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(BCMNormalRange)");

                entity.Property(e => e.LowerLimit_BFMNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(BFMNormalRange)");

                entity.Property(e => e.LowerLimit_BMCNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(BMCNormalRange)");

                entity.Property(e => e.LowerLimit_BMINormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(BMINormalRange)");

                entity.Property(e => e.LowerLimit_ECWNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(ECWNormalRange)");

                entity.Property(e => e.LowerLimit_ECWofArmNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(ECWofArmNormalRange)");

                entity.Property(e => e.LowerLimit_ECWofLegNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(ECWofLegNormalRange)");

                entity.Property(e => e.LowerLimit_ECWofTrunkNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(ECWofTrunkNormalRange)");

                entity.Property(e => e.LowerLimit_FFM_LBM_NormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(FFM(LBM)NormalRange)");

                entity.Property(e => e.LowerLimit_FFM_LBM_ofArmNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(FFM(LBM)ofArmNormalRange)");

                entity.Property(e => e.LowerLimit_FFM_LBM_ofLegNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(FFM(LBM)ofLegNormalRange)");

                entity.Property(e => e.LowerLimit_FFM_LBM_ofTrunkNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(FFM(LBM)ofTrunkNormalRange)");

                entity.Property(e => e.LowerLimit_ICWNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(ICWNormalRange)");

                entity.Property(e => e.LowerLimit_ICWofArmNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(ICWofArmNormalRange)");

                entity.Property(e => e.LowerLimit_ICWofLegNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(ICWofLegNormalRange)");

                entity.Property(e => e.LowerLimit_ICWofTrunkNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(ICWofTrunkNormalRange)");

                entity.Property(e => e.LowerLimit_MineralsNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(MineralsNormalRange)");

                entity.Property(e => e.LowerLimit_ObesityDegreeNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(ObesityDegreeNormalRange)");

                entity.Property(e => e.LowerLimit_PBFNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(PBFNormalRange)");

                entity.Property(e => e.LowerLimit_ProteinNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(ProteinNormalRange)");

                entity.Property(e => e.LowerLimit_SLMNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(SLMNormalRange)");

                entity.Property(e => e.LowerLimit_SMMNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(SMMNormalRange)");

                entity.Property(e => e.LowerLimit_TBWNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(TBWNormalRange)");

                entity.Property(e => e.LowerLimit_TBWofArmNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(TBWofArmNormalRange)");

                entity.Property(e => e.LowerLimit_TBWofLegNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(TBWofLegNormalRange)");

                entity.Property(e => e.LowerLimit_TBWofTrunkNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(TBWofTrunkNormalRange)");

                entity.Property(e => e.LowerLimit_WHRNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(WHRNormalRange)");

                entity.Property(e => e.LowerLimit_WeightNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("LowerLimit(WeightNormalRange)");

                entity.Property(e => e.MeanArteryPressure).HasMaxLength(255);

                entity.Property(e => e.MeasuredCircumferenceofAbdomen).HasMaxLength(255);

                entity.Property(e => e.MeasuredCircumferenceofChest).HasMaxLength(255);

                entity.Property(e => e.MeasuredCircumferenceofHip).HasMaxLength(255);

                entity.Property(e => e.MeasuredCircumferenceofLeftArm).HasMaxLength(255);

                entity.Property(e => e.MeasuredCircumferenceofLeftThigh).HasMaxLength(255);

                entity.Property(e => e.MeasuredCircumferenceofNeck).HasMaxLength(255);

                entity.Property(e => e.MeasuredCircumferenceofRightArm).HasMaxLength(255);

                entity.Property(e => e.MeasuredCircumferenceofRightThigh).HasMaxLength(255);

                entity.Property(e => e.MeasuredFatThicknessofAbdomen).HasMaxLength(255);

                entity.Property(e => e.MeasuredFatThicknessofChest).HasMaxLength(255);

                entity.Property(e => e.MeasuredFatThicknessofLeftArm).HasMaxLength(255);

                entity.Property(e => e.MeasuredFatThicknessofLeftThigh).HasMaxLength(255);

                entity.Property(e => e.MeasuredFatThicknessofRightArm).HasMaxLength(255);

                entity.Property(e => e.MeasuredFatThicknessofRightThigh).HasMaxLength(255);

                entity.Property(e => e.MeasuredMuscleCircumferenceofChest).HasMaxLength(255);

                entity.Property(e => e.MeasuredMuscleCircumferenceofHip).HasMaxLength(255);

                entity.Property(e => e.MeasuredMuscleCircumferenceofLeftArm).HasMaxLength(255);

                entity.Property(e => e.MeasuredMuscleCircumferenceofLeftThigh).HasMaxLength(255);

                entity.Property(e => e.MeasuredMuscleCircumferenceofRightArm).HasMaxLength(255);

                entity.Property(e => e.MeasuredMuscleCircumferenceofRightThigh).HasMaxLength(255);

                entity.Property(e => e.Minerals).HasMaxLength(255);

                entity.Property(e => e.MineralsEvaluation).HasMaxLength(255);

                entity.Property(e => e.MobileNumber).HasMaxLength(255);

                entity.Property(e => e.MuscleStrengthEvaluation).HasMaxLength(255);

                entity.Property(e => e.ObesityDegree).HasMaxLength(255);

                entity.Property(e => e.ObesityDegreeofaChild).HasMaxLength(255);

                entity.Property(e => e.PBFEvaluation).HasMaxLength(255);

                entity.Property(e => e.PBF_PercentBodyFat_)
                    .HasMaxLength(255)
                    .HasColumnName("PBF(PercentBodyFat)");

                entity.Property(e => e.PBFofLeftArm).HasMaxLength(255);

                entity.Property(e => e.PBFofLeftLeg).HasMaxLength(255);

                entity.Property(e => e.PBFofRightArm).HasMaxLength(255);

                entity.Property(e => e.PBFofRightLeg).HasMaxLength(255);

                entity.Property(e => e.PBFofTrunk).HasMaxLength(255);

                entity.Property(e => e.Protein).HasMaxLength(255);

                entity.Property(e => e.ProteinEvaluation).HasMaxLength(255);

                entity.Property(e => e.Pulse).HasMaxLength(255);

                entity.Property(e => e.PulsePressure).HasMaxLength(255);

                entity.Property(e => e.RatePressureProduct).HasMaxLength(255);

                entity.Property(e => e.SLMEvaluation).HasMaxLength(255);

                entity.Property(e => e.SLM_SoftLeanMass_)
                    .HasMaxLength(255)
                    .HasColumnName("SLM(SoftLeanMass)");

                entity.Property(e => e.SMM_SkeletalMuscleMass_)
                    .HasMaxLength(255)
                    .HasColumnName("SMM(SkeletalMuscleMass)");

                entity.Property(e => e.ServiceLoingID).HasMaxLength(255);

                entity.Property(e => e.Systolic).HasMaxLength(255);

                entity.Property(e => e.TBW_FFM)
                    .HasMaxLength(255)
                    .HasColumnName("TBW/FFM");

                entity.Property(e => e.TBW_TotalBodyWater_)
                    .HasMaxLength(255)
                    .HasColumnName("TBW(TotalBodyWater)");

                entity.Property(e => e.TBWofLeftArm).HasMaxLength(255);

                entity.Property(e => e.TBWofLeftLeg).HasMaxLength(255);

                entity.Property(e => e.TBWofRightArm).HasMaxLength(255);

                entity.Property(e => e.TBWofRightLeg).HasMaxLength(255);

                entity.Property(e => e.TBWofTrunk).HasMaxLength(255);

                entity.Property(e => e.TargetWeight).HasMaxLength(255);

                entity.Property(e => e.TestDate).HasMaxLength(255);

                entity.Property(e => e.TestDatetime).HasMaxLength(255);

                entity.Property(e => e.TestTime).HasMaxLength(255);

                entity.Property(e => e.UpperBodyBalanceEvaluation).HasMaxLength(255);

                entity.Property(e => e.UpperBodyStrengthEvaluation).HasMaxLength(255);

                entity.Property(e => e.UpperLimit_BCMNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(BCMNormalRange)");

                entity.Property(e => e.UpperLimit_BFMNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(BFMNormalRange)");

                entity.Property(e => e.UpperLimit_BMCNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(BMCNormalRange)");

                entity.Property(e => e.UpperLimit_BMINormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(BMINormalRange)");

                entity.Property(e => e.UpperLimit_ECWNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(ECWNormalRange)");

                entity.Property(e => e.UpperLimit_ECWofArmNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(ECWofArmNormalRange)");

                entity.Property(e => e.UpperLimit_ECWofLegNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(ECWofLegNormalRange)");

                entity.Property(e => e.UpperLimit_ECWofTrunkNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(ECWofTrunkNormalRange)");

                entity.Property(e => e.UpperLimit_FFM_LBM_NormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(FFM(LBM)NormalRange)");

                entity.Property(e => e.UpperLimit_FFM_LBM_ofArmNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(FFM(LBM)ofArmNormalRange)");

                entity.Property(e => e.UpperLimit_FFM_LBM_ofLegNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(FFM(LBM)ofLegNormalRange)");

                entity.Property(e => e.UpperLimit_FFM_LBM_ofTrunkNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(FFM(LBM)ofTrunkNormalRange)");

                entity.Property(e => e.UpperLimit_ICWNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(ICWNormalRange)");

                entity.Property(e => e.UpperLimit_ICWofArmNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(ICWofArmNormalRange)");

                entity.Property(e => e.UpperLimit_ICWofLegNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(ICWofLegNormalRange)");

                entity.Property(e => e.UpperLimit_ICWofTrunkNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(ICWofTrunkNormalRange)");

                entity.Property(e => e.UpperLimit_MineralsNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(MineralsNormalRange)");

                entity.Property(e => e.UpperLimit_ObesityDegreeNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(ObesityDegreeNormalRange)");

                entity.Property(e => e.UpperLimit_PBFNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(PBFNormalRange)");

                entity.Property(e => e.UpperLimit_ProteinNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(ProteinNormalRange)");

                entity.Property(e => e.UpperLimit_SLMNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(SLMNormalRange)");

                entity.Property(e => e.UpperLimit_SMMNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(SMMNormalRange)");

                entity.Property(e => e.UpperLimit_TBWNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(TBWNormalRange)");

                entity.Property(e => e.UpperLimit_TBWofArmNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(TBWofArmNormalRange)");

                entity.Property(e => e.UpperLimit_TBWofLegNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(TBWofLegNormalRange)");

                entity.Property(e => e.UpperLimit_TBWofTrunkNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(TBWofTrunkNormalRange)");

                entity.Property(e => e.UpperLimit_WHRNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(WHRNormalRange)");

                entity.Property(e => e.UpperLimit_WeightNormalRange_)
                    .HasMaxLength(255)
                    .HasColumnName("UpperLimit(WeightNormalRange)");

                entity.Property(e => e.Upper_LowerBodyBalanceEvaluation)
                    .HasMaxLength(255)
                    .HasColumnName("Upper-LowerBodyBalanceEvaluation");

                entity.Property(e => e.VFA_VisceralFatArea_)
                    .HasMaxLength(255)
                    .HasColumnName("VFA(VisceralFatArea)");

                entity.Property(e => e.VFL_VisceralFatLevel_)
                    .HasMaxLength(255)
                    .HasColumnName("VFL(VisceralFatLevel)");

                entity.Property(e => e.WHREvaluation).HasMaxLength(255);

                entity.Property(e => e.WHR_Waist_HipRatio_)
                    .HasMaxLength(255)
                    .HasColumnName("WHR(Waist-HipRatio)");

                entity.Property(e => e.Weight).HasMaxLength(255);

                entity.Property(e => e.WeightControl).HasMaxLength(255);

                entity.Property(e => e.WeightEvaluation).HasMaxLength(255);

                entity.Property(e => e.WholeBodyPhaseAngle50kHz).HasMaxLength(255);

                entity.Property(e => e._1000khz_LAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("1000khz-LAImpedance");

                entity.Property(e => e._1000khz_LLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("1000khz-LLImpedance");

                entity.Property(e => e._1000khz_RAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("1000khz-RAImpedance");

                entity.Property(e => e._1000khz_RLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("1000khz-RLImpedance");

                entity.Property(e => e._1000khz_TRImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("1000khz-TRImpedance");

                entity.Property(e => e._100khz_LAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("100khz-LAImpedance");

                entity.Property(e => e._100khz_LLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("100khz-LLImpedance");

                entity.Property(e => e._100khz_RAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("100khz-RAImpedance");

                entity.Property(e => e._100khz_RLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("100khz-RLImpedance");

                entity.Property(e => e._100khz_TRImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("100khz-TRImpedance");

                entity.Property(e => e._1khz_LAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("1khz-LAImpedance");

                entity.Property(e => e._1khz_LLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("1khz-LLImpedance");

                entity.Property(e => e._1khz_RAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("1khz-RAImpedance");

                entity.Property(e => e._1khz_RLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("1khz-RLImpedance");

                entity.Property(e => e._1khz_TRImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("1khz-TRImpedance");

                entity.Property(e => e._20khz_LAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("20khz-LAImpedance");

                entity.Property(e => e._20khz_LLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("20khz-LLImpedance");

                entity.Property(e => e._20khz_RAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("20khz-RAImpedance");

                entity.Property(e => e._20khz_RLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("20khz-RLImpedance");

                entity.Property(e => e._20khz_TRImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("20khz-TRImpedance");

                entity.Property(e => e._250khz_LAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-LAImpedance");

                entity.Property(e => e._250khz_LAPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-LAPhaseAngle");

                entity.Property(e => e._250khz_LAReactance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-LAReactance");

                entity.Property(e => e._250khz_LAResistance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-LAResistance");

                entity.Property(e => e._250khz_LLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-LLImpedance");

                entity.Property(e => e._250khz_LLPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-LLPhaseAngle");

                entity.Property(e => e._250khz_LLReactance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-LLReactance");

                entity.Property(e => e._250khz_LLResistance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-LLResistance");

                entity.Property(e => e._250khz_RAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-RAImpedance");

                entity.Property(e => e._250khz_RAPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-RAPhaseAngle");

                entity.Property(e => e._250khz_RAReactance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-RAReactance");

                entity.Property(e => e._250khz_RAResistance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-RAResistance");

                entity.Property(e => e._250khz_RLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-RLImpedance");

                entity.Property(e => e._250khz_RLPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-RLPhaseAngle");

                entity.Property(e => e._250khz_RLReactance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-RLReactance");

                entity.Property(e => e._250khz_RLResistance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-RLResistance");

                entity.Property(e => e._250khz_TRImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-TRImpedance");

                entity.Property(e => e._250khz_TRPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-TRPhaseAngle");

                entity.Property(e => e._250khz_TRReactance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-TRReactance");

                entity.Property(e => e._250khz_TRResistance)
                    .HasMaxLength(255)
                    .HasColumnName("250khz-TRResistance");

                entity.Property(e => e._500khz_LAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("500khz-LAImpedance");

                entity.Property(e => e._500khz_LLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("500khz-LLImpedance");

                entity.Property(e => e._500khz_RAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("500khz-RAImpedance");

                entity.Property(e => e._500khz_RLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("500khz-RLImpedance");

                entity.Property(e => e._500khz_TRImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("500khz-TRImpedance");

                entity.Property(e => e._50khz_LAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-LAImpedance");

                entity.Property(e => e._50khz_LAPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-LAPhaseAngle");

                entity.Property(e => e._50khz_LAReactance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-LAReactance");

                entity.Property(e => e._50khz_LAResistance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-LAResistance");

                entity.Property(e => e._50khz_LLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-LLImpedance");

                entity.Property(e => e._50khz_LLPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-LLPhaseAngle");

                entity.Property(e => e._50khz_LLReactance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-LLReactance");

                entity.Property(e => e._50khz_LLResistance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-LLResistance");

                entity.Property(e => e._50khz_RAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-RAImpedance");

                entity.Property(e => e._50khz_RAPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-RAPhaseAngle");

                entity.Property(e => e._50khz_RAReactance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-RAReactance");

                entity.Property(e => e._50khz_RAResistance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-RAResistance");

                entity.Property(e => e._50khz_RLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-RLImpedance");

                entity.Property(e => e._50khz_RLPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-RLPhaseAngle");

                entity.Property(e => e._50khz_RLReactance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-RLReactance");

                entity.Property(e => e._50khz_RLResistance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-RLResistance");

                entity.Property(e => e._50khz_TRImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-TRImpedance");

                entity.Property(e => e._50khz_TRPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-TRPhaseAngle");

                entity.Property(e => e._50khz_TRReactance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-TRReactance");

                entity.Property(e => e._50khz_TRResistance)
                    .HasMaxLength(255)
                    .HasColumnName("50khz-TRResistance");

                entity.Property(e => e._5khz_LAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-LAImpedance");

                entity.Property(e => e._5khz_LAPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-LAPhaseAngle");

                entity.Property(e => e._5khz_LAReactance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-LAReactance");

                entity.Property(e => e._5khz_LAResistance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-LAResistance");

                entity.Property(e => e._5khz_LLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-LLImpedance");

                entity.Property(e => e._5khz_LLPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-LLPhaseAngle");

                entity.Property(e => e._5khz_LLReactance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-LLReactance");

                entity.Property(e => e._5khz_LLResistance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-LLResistance");

                entity.Property(e => e._5khz_RAImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-RAImpedance");

                entity.Property(e => e._5khz_RAPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-RAPhaseAngle");

                entity.Property(e => e._5khz_RAReactance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-RAReactance");

                entity.Property(e => e._5khz_RAResistance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-RAResistance");

                entity.Property(e => e._5khz_RLImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-RLImpedance");

                entity.Property(e => e._5khz_RLPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-RLPhaseAngle");

                entity.Property(e => e._5khz_RLReactance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-RLReactance");

                entity.Property(e => e._5khz_RLResistance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-RLResistance");

                entity.Property(e => e._5khz_TRImpedance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-TRImpedance");

                entity.Property(e => e._5khz_TRPhaseAngle)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-TRPhaseAngle");

                entity.Property(e => e._5khz_TRReactance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-TRReactance");

                entity.Property(e => e._5khz_TRResistance)
                    .HasMaxLength(255)
                    .HasColumnName("5khz-TRResistance");

                entity.Property(e => e._ofArmStrength)
                    .HasMaxLength(255)
                    .HasColumnName("%ofArmStrength");

                entity.Property(e => e._ofBFM)
                    .HasMaxLength(255)
                    .HasColumnName("%ofBFM");

                entity.Property(e => e._ofECW)
                    .HasMaxLength(255)
                    .HasColumnName("%ofECW");

                entity.Property(e => e._ofFFM_LBM_)
                    .HasMaxLength(255)
                    .HasColumnName("%ofFFM(LBM)");

                entity.Property(e => e._ofFFM_LBM_ofLeftArm)
                    .HasMaxLength(255)
                    .HasColumnName("%ofFFM(LBM)ofLeftArm");

                entity.Property(e => e._ofFFM_LBM_ofLeftLeg)
                    .HasMaxLength(255)
                    .HasColumnName("%ofFFM(LBM)ofLeftLeg");

                entity.Property(e => e._ofFFM_LBM_ofRightArm)
                    .HasMaxLength(255)
                    .HasColumnName("%ofFFM(LBM)ofRightArm");

                entity.Property(e => e._ofFFM_LBM_ofRightLeg)
                    .HasMaxLength(255)
                    .HasColumnName("%ofFFM(LBM)ofRightLeg");

                entity.Property(e => e._ofFFM_LBM_ofTrunk)
                    .HasMaxLength(255)
                    .HasColumnName("%ofFFM(LBM)ofTrunk");

                entity.Property(e => e._ofFFM__ofLBM)
                    .HasMaxLength(255)
                    .HasColumnName("%ofFFM/%ofLBM");

                entity.Property(e => e._ofICW)
                    .HasMaxLength(255)
                    .HasColumnName("%ofICW");

                entity.Property(e => e._ofLegStrength)
                    .HasMaxLength(255)
                    .HasColumnName("%ofLegStrength");

                entity.Property(e => e._ofMinerals)
                    .HasMaxLength(255)
                    .HasColumnName("%ofMinerals");

                entity.Property(e => e._ofMuscleStrength)
                    .HasMaxLength(255)
                    .HasColumnName("%ofMuscleStrength");

                entity.Property(e => e._ofPBF_)
                    .HasMaxLength(255)
                    .HasColumnName("%ofPBF%");

                entity.Property(e => e._ofProtein)
                    .HasMaxLength(255)
                    .HasColumnName("%ofProtein");

                entity.Property(e => e._ofSMM)
                    .HasMaxLength(255)
                    .HasColumnName("%ofSMM");

                entity.Property(e => e._ofTBW)
                    .HasMaxLength(255)
                    .HasColumnName("%ofTBW");

                entity.Property(e => e._ofTBWofLeftArm)
                    .HasMaxLength(255)
                    .HasColumnName("%ofTBWofLeftArm");

                entity.Property(e => e._ofTBWofLeftLeg)
                    .HasMaxLength(255)
                    .HasColumnName("%ofTBWofLeftLeg");

                entity.Property(e => e._ofTBWofRightArm)
                    .HasMaxLength(255)
                    .HasColumnName("%ofTBWofRightArm");

                entity.Property(e => e._ofTBWofRightLeg)
                    .HasMaxLength(255)
                    .HasColumnName("%ofTBWofRightLeg");

                entity.Property(e => e._ofTBWofTrunk)
                    .HasMaxLength(255)
                    .HasColumnName("%ofTBWofTrunk");

                entity.Property(e => e._ofWeight)
                    .HasMaxLength(255)
                    .HasColumnName("%ofWeight");
            });

            modelBuilder.Entity<SaintEir_InsuranceIdentity>(entity =>
            {
                entity.ToTable("SaintEir_InsuranceIdentity");

                entity.HasComment("保險身份");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("身份編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.HICompanyPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("健保費健康保險費投保單位負擔");

                entity.Property(e => e.HIInsuredPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("健保費健康保險費被保險人負擔");

                entity.Property(e => e.HIRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("健保費健康保險費率");

                entity.Property(e => e.LIECompanyPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費就業保險費投保單位負擔");

                entity.Property(e => e.LIEInsuredPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費就業保險費被保險人負擔");

                entity.Property(e => e.LIEmploymentRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費就業保險費率");

                entity.Property(e => e.LINACompanyPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費普通事故費投保單位負擔");

                entity.Property(e => e.LINAInsuredPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費普通事故費被保險人負擔");

                entity.Property(e => e.LINormalAccidentRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費普通事故費率");

                entity.Property(e => e.LIOHCompanyPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費職業災害費投保單位負擔");

                entity.Property(e => e.LIOHInsuredPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費職業災害費被保險人負擔");

                entity.Property(e => e.LIOccupationalHazardRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費職業災害費率");

                entity.Property(e => e.LIWCFCompanyPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費工資墊償基金投保單位負擔");

                entity.Property(e => e.LIWCFInsuredPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費工資墊償基金被保險人負擔");

                entity.Property(e => e.LIWageCompensationFund)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費工資墊償基金");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("身份名稱");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_Introducer>(entity =>
            {
                entity.HasKey(e => e.IntroducerKeyNo)
                    .HasName("PK__SaintEir_Introdu__71BCD978");

                entity.ToTable("SaintEir_Introducer");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.BankAccount).HasMaxLength(30);

                entity.Property(e => e.Birthday).HasMaxLength(255);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.ContractEndDate).HasColumnType("datetime");

                entity.Property(e => e.ContractStartDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.IntroducerNo).HasMaxLength(255);

                entity.Property(e => e.Mobile_1).HasMaxLength(20);

                entity.Property(e => e.SSID).HasMaxLength(12);

                entity.Property(e => e.SalesBy).HasMaxLength(255);

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.Tel_H_AreaCode).HasMaxLength(20);

                entity.Property(e => e.Tel_H_Number).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_JobAdjustment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_JobAdjustment");

                entity.HasComment("工作調整單");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("datetime")
                    .HasComment("日期");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("datetime")
                    .HasComment("核決日期");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(255)
                    .HasComment("核決人員");

                entity.Property(e => e.AssignBranchNo)
                    .HasMaxLength(20)
                    .HasComment("隸屬公司");

                entity.Property(e => e.AttendanceBonus).HasComment("全勤獎金(月) 金額");

                entity.Property(e => e.BasicSalary).HasComment("本薪金額");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasComment("隸屬部門");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("單號");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasComment("生效日期");

                entity.Property(e => e.EmployeeTypeId).HasComment("員工類型");

                entity.Property(e => e.EnglishJobTitle)
                    .HasMaxLength(50)
                    .HasComment("英文職稱");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_AttendanceBonus).HasComment("全勤獎金(月)");

                entity.Property(e => e.Is_MealAllowance).HasComment("伙食津貼");

                entity.Property(e => e.Is_OverTimePay).HasComment("加班費用");

                entity.Property(e => e.Is_PaySalary).HasComment("發放薪資");

                entity.Property(e => e.Is_Welfare).HasComment("代扣福利費");

                entity.Property(e => e.JobLevelId).HasComment("職級編號");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .HasComment("中文職稱");

                entity.Property(e => e.JobTitleId).HasComment("職等編號");

                entity.Property(e => e.LeaveWithoutPayDays).HasComment("留職停薪天數");

                entity.Property(e => e.MealAllowance).HasComment("伙食津貼金額");

                entity.Property(e => e.OldAssignBranchNo)
                    .HasMaxLength(20)
                    .HasComment("隸屬公司");

                entity.Property(e => e.OldAttendanceBonus).HasComment("全勤獎金(月) 金額");

                entity.Property(e => e.OldBasicSalary).HasComment("本薪金額");

                entity.Property(e => e.OldDepartmentId).HasComment("隸屬部門");

                entity.Property(e => e.OldEmployeeTypeId).HasComment("員工類型");

                entity.Property(e => e.OldEnglishJobTitle)
                    .HasMaxLength(50)
                    .HasComment("英文職稱");

                entity.Property(e => e.OldIs_AttendanceBonus).HasComment("發放薪資");

                entity.Property(e => e.OldIs_MealAllowance).HasComment("伙食津貼");

                entity.Property(e => e.OldIs_OverTimePay).HasComment("加班費用");

                entity.Property(e => e.OldIs_PaySalary).HasComment("發放薪資");

                entity.Property(e => e.OldIs_Welfare).HasComment("代扣福利費");

                entity.Property(e => e.OldJobLevelId).HasComment("職級編號");

                entity.Property(e => e.OldJobTitle)
                    .HasMaxLength(50)
                    .HasComment("中文職稱");

                entity.Property(e => e.OldJobTitleId).HasComment("職等編號");

                entity.Property(e => e.OldMealAllowance).HasComment("伙食津貼金額");

                entity.Property(e => e.OldOverTimePayId).HasComment("加班類別");

                entity.Property(e => e.OldSalaryDepartmentId).HasComment("薪資隸屬部門");

                entity.Property(e => e.OldTaxRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("固定稅率");

                entity.Property(e => e.OldWelfareRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("代扣福利費費率");

                entity.Property(e => e.Oldp_HourPayBase).HasComment("原時薪計算標準");

                entity.Property(e => e.Oldp_SalaryCaculateMethod).HasComment("計薪方式");

                entity.Property(e => e.Oldp_SalaryCaculateMethodIfAdjInMiddle).HasComment("月中調薪處理方式");

                entity.Property(e => e.Oldp_SalaryPayMethod).HasComment("薪資發放");

                entity.Property(e => e.Oldp_SalarySubject).HasComment("薪資科目");

                entity.Property(e => e.Oldp_TaxType).HasComment("課稅方式");

                entity.Property(e => e.OriginalLeaveWithoutPayDate)
                    .HasColumnType("datetime")
                    .HasComment("原留職停薪日");

                entity.Property(e => e.OutEnd).HasColumnType("datetime");

                entity.Property(e => e.OutStart).HasColumnType("datetime");

                entity.Property(e => e.OverTimePayId).HasComment("加班類別");

                entity.Property(e => e.SalaryDepartmentId).HasComment("薪資隸屬部門");

                entity.Property(e => e.SystemProcessDate).HasColumnType("datetime");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("固定稅率");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WelfareRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("代扣福利費費率");

                entity.Property(e => e.p_HourPayBase).HasComment("新時薪計算標準");

                entity.Property(e => e.p_JobAdujstmentReasonId).HasComment("調整原因");

                entity.Property(e => e.p_SalaryCaculateMethod).HasComment("計薪方式");

                entity.Property(e => e.p_SalaryCaculateMethodIfAdjInMiddle).HasComment("月中調薪處理方式");

                entity.Property(e => e.p_SalaryPayMethod).HasComment("薪資發放");

                entity.Property(e => e.p_SalarySubject).HasComment("薪資科目");

                entity.Property(e => e.p_TaxType).HasComment("課稅方式");
            });

            modelBuilder.Entity<SaintEir_JobAdjustment_SalaryItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_JobAdjustment_SalaryItem");

                entity.HasComment("工作調整之薪資項目");

                entity.Property(e => e.AdjustmentId).HasComment("調整單 Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemId).HasComment("薪資項目編號");

                entity.Property(e => e.NewEndDate)
                    .HasColumnType("datetime")
                    .HasComment("新結束時間");

                entity.Property(e => e.NewStartDate)
                    .HasColumnType("datetime")
                    .HasComment("新開始時間");

                entity.Property(e => e.NewValue).HasComment("新資料");

                entity.Property(e => e.OldEndDate)
                    .HasColumnType("datetime")
                    .HasComment("原結束時間");

                entity.Property(e => e.OldStartDate)
                    .HasColumnType("datetime")
                    .HasComment("原開始時間");

                entity.Property(e => e.OldValue).HasComment("舊資料");
            });

            modelBuilder.Entity<SaintEir_JobLevel>(entity =>
            {
                entity.ToTable("SaintEir_JobLevel");

                entity.HasComment("職級");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("職級編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EngName)
                    .HasMaxLength(50)
                    .HasComment("英文名稱");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("職級名稱");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_JobTitle>(entity =>
            {
                entity.ToTable("SaintEir_JobTitle");

                entity.HasComment("職等資料(職稱)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("職等編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EngName)
                    .HasMaxLength(50)
                    .HasComment("英文名稱");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("職等名稱");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_LaborInsuranceAdj>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_LaborInsuranceAdj");

                entity.HasComment("勞保調整記錄");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DeleterId).HasMaxLength(255);

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasComment("生效日期");

                entity.Property(e => e.En_Type).HasComment("異動類別$加保=100,修改投保薪資=200,退保=300");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InsuranceDepartment).HasMaxLength(32);

                entity.Property(e => e.Salary).HasComment("投保薪資");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_LoginUserInBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_LoginUserInBranch");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.BranchNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.BranchNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK5FB9EBFFF9304BEE");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK5FB9EBFF1C7BFF32");
            });

            modelBuilder.Entity<SaintEir_MaterialConsumption>(entity =>
            {
                entity.HasKey(e => e.MaterialConsumptionNo);

                entity.ToTable("SaintEir_MaterialConsumption");

                entity.Property(e => e.BHMaterialQuantity).HasColumnType("decimal(9, 5)");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.ConsumptionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IOBNoteNO).HasMaxLength(255);

                entity.Property(e => e.Quantity).HasColumnType("decimal(9, 5)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_MaterialSummary>(entity =>
            {
                entity.HasKey(e => e.MaterialSummaryNo);

                entity.ToTable("SaintEir_MaterialSummary");

                entity.Property(e => e.AdjustAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AdjustQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AdjustUnitPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BeginningAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BeginningQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BeginningUnitPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.ConsumptionAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ConsumptionQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ConsumptionUnitPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FinalQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FinalUnitPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReplenishAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReplenishQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReplenishUnitPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.dateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_Member>(entity =>
            {
                entity.HasKey(e => e.MemberNo)
                    .HasName("PK__SaintEir_Member__2E70E1FD");

                entity.ToTable("SaintEir_Member");

                entity.HasIndex(e => e.MemberNo, "IDX_SaintEir_Member_MemberNo");

                entity.HasIndex(e => e.FullName, "member_name");

                entity.Property(e => e.Acne).HasMaxLength(255);

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AdverseReactions).HasMaxLength(255);

                entity.Property(e => e.Allergy).HasMaxLength(255);

                entity.Property(e => e.AnamnesisNo).HasMaxLength(255);

                entity.Property(e => e.Attendant).HasMaxLength(255);

                entity.Property(e => e.Attendant2).HasMaxLength(255);

                entity.Property(e => e.BelongToBranch).HasMaxLength(255);

                entity.Property(e => e.BelongToGroup).HasMaxLength(255);

                entity.Property(e => e.Birthday).HasMaxLength(255);

                entity.Property(e => e.BloodType).HasMaxLength(2);

                entity.Property(e => e.Bud).HasMaxLength(255);

                entity.Property(e => e.CardNum).HasMaxLength(20);

                entity.Property(e => e.Cellulite).HasMaxLength(255);

                entity.Property(e => e.ChildBoys).HasMaxLength(255);

                entity.Property(e => e.ChildGirls).HasMaxLength(255);

                entity.Property(e => e.CirculatorySystem).HasMaxLength(255);

                entity.Property(e => e.Constellation).HasMaxLength(255);

                entity.Property(e => e.ConsultOther).HasMaxLength(255);

                entity.Property(e => e.ConsultSuggestion).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CureHistoryOther).HasMaxLength(255);

                entity.Property(e => e.CustomerHabit).HasMaxLength(255);

                entity.Property(e => e.DigestiveSystem).HasMaxLength(255);

                entity.Property(e => e.DoctorType).HasMaxLength(255);

                entity.Property(e => e.Education).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.ExpectImporvedItems).HasMaxLength(255);

                entity.Property(e => e.ExpectImporvedItemsBody).HasMaxLength(200);

                entity.Property(e => e.ExpectImporvedItemsFacial).HasMaxLength(200);

                entity.Property(e => e.FSSID).HasMaxLength(30);

                entity.Property(e => e.FaceAnalysis).HasMaxLength(255);

                entity.Property(e => e.FamilyHistory).HasMaxLength(255);

                entity.Property(e => e.Freckles).HasMaxLength(255);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.Height).HasMaxLength(255);

                entity.Property(e => e.History).HasMaxLength(255);

                entity.Property(e => e.HyaluronanBrand).HasMaxLength(255);

                entity.Property(e => e.Hypersensitive).HasMaxLength(255);

                entity.Property(e => e.ImmuneSystem).HasMaxLength(255);

                entity.Property(e => e.Income).HasMaxLength(50);

                entity.Property(e => e.Introducer).HasMaxLength(50);

                entity.Property(e => e.IsCompleted).HasMaxLength(1);

                entity.Property(e => e.IsConfirmAccount).HasMaxLength(255);

                entity.Property(e => e.IsPurposeToDr).HasMaxLength(255);

                entity.Property(e => e.IskuvaEmployee).HasMaxLength(200);

                entity.Property(e => e.KVNumber).HasMaxLength(50);

                entity.Property(e => e.KuvaMemberID).HasMaxLength(200);

                entity.Property(e => e.LanguageCode).HasMaxLength(50);

                entity.Property(e => e.LineID).HasMaxLength(255);

                entity.Property(e => e.LiposuctionSite).HasMaxLength(255);

                entity.Property(e => e.MaintainChangeReason).HasMaxLength(255);

                entity.Property(e => e.MaintainDailyProductName).HasMaxLength(255);

                entity.Property(e => e.MaintainHabit).HasMaxLength(255);

                entity.Property(e => e.MaintainProductName).HasMaxLength(255);

                entity.Property(e => e.MaintainProgramName).HasMaxLength(255);

                entity.Property(e => e.MaintainShopName).HasMaxLength(255);

                entity.Property(e => e.Marriage).HasMaxLength(1);

                entity.Property(e => e.MassageLevel).HasMaxLength(50);

                entity.Property(e => e.MemberLevel).HasMaxLength(255);

                entity.Property(e => e.MemberType).HasMaxLength(20);

                entity.Property(e => e.Mobile_1).HasMaxLength(20);

                entity.Property(e => e.Mobile_2).HasMaxLength(20);

                entity.Property(e => e.MuscleSystem).HasMaxLength(255);

                entity.Property(e => e.NervousSystem).HasMaxLength(255);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.OtherReason).HasMaxLength(255);

                entity.Property(e => e.Pigment).HasMaxLength(255);

                entity.Property(e => e.Pimples).HasMaxLength(255);

                entity.Property(e => e.PrePayMoney).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RemainCredit).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.ReproductionSystem).HasMaxLength(255);

                entity.Property(e => e.RespiratorySystem).HasMaxLength(255);

                entity.Property(e => e.SSID).HasMaxLength(12);

                entity.Property(e => e.Scar).HasMaxLength(255);

                entity.Property(e => e.SelfFatLipFaceCreamSite).HasMaxLength(255);

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.SkinType).HasMaxLength(255);

                entity.Property(e => e.Surgery).HasMaxLength(255);

                entity.Property(e => e.Tel_H_AreaCode).HasMaxLength(20);

                entity.Property(e => e.Tel_H_Number).HasMaxLength(20);

                entity.Property(e => e.Tel_O_AreaCode).HasMaxLength(20);

                entity.Property(e => e.Tel_O_Number).HasMaxLength(20);

                entity.Property(e => e.Transportation).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UrinarySystem).HasMaxLength(255);

                entity.Property(e => e.WeChatID).HasMaxLength(255);

                entity.Property(e => e.Weight).HasMaxLength(255);

                entity.Property(e => e.WhereToGetInfo).HasMaxLength(200);

                entity.Property(e => e.Wrinkle).HasMaxLength(255);

                entity.Property(e => e.Zip).HasMaxLength(10);
            });

            modelBuilder.Entity<SaintEir_MemberAnalysis>(entity =>
            {
                entity.HasKey(e => e.MemberAnalysisNo);

                entity.ToTable("SaintEir_MemberAnalysis");
            });

            modelBuilder.Entity<SaintEir_MemberApp>(entity =>
            {
                entity.HasKey(e => e.MemberAppNo)
                    .HasName("PK_SaintEir_MemberApp_1");

                entity.ToTable("SaintEir_MemberApp");

                entity.Property(e => e.Account).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceType).HasMaxLength(20);

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.Token).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_MemberBlackList>(entity =>
            {
                entity.HasKey(e => e.MemberBlackListNo)
                    .HasName("PK_SaintEir_MemberBalckList");

                entity.ToTable("SaintEir_MemberBlackList");
            });

            modelBuilder.Entity<SaintEir_MemberDrOrder>(entity =>
            {
                entity.HasKey(e => e.MemberDrOrderNo);

                entity.ToTable("SaintEir_MemberDrOrder");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_MemberMedicalRecord>(entity =>
            {
                entity.HasKey(e => e.MedicalRecordNo);

                entity.ToTable("SaintEir_MemberMedicalRecord");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_MemberValue>(entity =>
            {
                entity.HasKey(e => e.MemberValueNo);

                entity.ToTable("SaintEir_MemberValue");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OwnMoney).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_MonthlyReport>(entity =>
            {
                entity.HasKey(e => e.MonthlyReportNo)
                    .HasName("PK__SaintEir_Monthly__257187A8");

                entity.ToTable("SaintEir_MonthlyReport");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.IntravenousDrip).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ItemInjection).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ItemLaser).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ItemService).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.ItemSurgery).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.RealIntravenousDrip).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.RealItemInjection).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.RealItemLaser).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.RealItemService).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.RealItemSurgery).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.RealSumCredit).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.RealSumProduct).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.RealSumSpa).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.RemainAR).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumCashIn).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumCredit).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumCreditIn).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumDayAmount).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumIn).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumItem).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumLeftPay).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumNotPayYet).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumProduct).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumRealAmount).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumSpa).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumTaxIn).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.SumVirtualIncome).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.dateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_MonthlyReportCustom>(entity =>
            {
                entity.HasKey(e => e.ReportNo);

                entity.ToTable("SaintEir_MonthlyReportCustom");

                entity.HasIndex(e => new { e.Date, e.BranchNo, e.Category }, "I_SaintEir_MonthlyReportCustom_1");

                entity.Property(e => e.BranchNo).HasMaxLength(20);

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Income).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SaintEir_MsgMapping>(entity =>
            {
                entity.HasKey(e => e.MsgMappingNo)
                    .HasName("PK__SaintEir__AFD9CF910BCE637D");

                entity.ToTable("SaintEir_MsgMapping");

                entity.Property(e => e.Addition).HasMaxLength(255);

                entity.Property(e => e.Main).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_OperationItem>(entity =>
            {
                entity.HasKey(e => e.OperationItemNo)
                    .HasName("PK__SaintEir_Operati__7BE56230");

                entity.ToTable("SaintEir_OperationItem");

                entity.Property(e => e.NameInChinese).HasMaxLength(300);

                entity.Property(e => e.NameInEnglish).HasMaxLength(300);

                entity.HasOne(d => d.BelongToResourceNavigation)
                    .WithMany(p => p.SaintEir_OperationItems)
                    .HasForeignKey(d => d.BelongToResource)
                    .HasConstraintName("FK87769FB110E5121E");
            });

            modelBuilder.Entity<SaintEir_OutPeriod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_OutPeriod");

                entity.HasComment("留職停薪期間");

                entity.HasIndex(e => new { e.UserId, e.EndDate }, "IX_SaintEir_OutPeriod_UserId (ASC), EndDate (ASC)");

                entity.HasIndex(e => new { e.UserId, e.StartDate }, "IX_SaintEir_OutPeriod_UserId (ASC), StartDate (ASC)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Days).HasComment("天數");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("結束日期");

                entity.Property(e => e.Flag)
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否刪除");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.JobAdjustmentId).HasComment("職務調整單編號");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("開始日期");

                entity.Property(e => e.TakeOffId).HasComment("請假單編號");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_OvertimeApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_OvertimeApplication");

                entity.HasComment("加班申請單");

                entity.Property(e => e.ActualAHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("實際A段時數");

                entity.Property(e => e.ActualBHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("實際B段時數");

                entity.Property(e => e.ActualCHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("實際C段時數");

                entity.Property(e => e.ActualEndDate)
                    .HasColumnType("datetime")
                    .HasComment("實際結束");

                entity.Property(e => e.ActualHHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("實際D段時數");

                entity.Property(e => e.ActualHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("實際時數");

                entity.Property(e => e.ActualSalaryDay)
                    .HasColumnType("datetime")
                    .HasComment("實際計薪日期");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnType("datetime")
                    .HasComment("實際開始");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("datetime")
                    .HasComment("日期");

                entity.Property(e => e.CorrectDate)
                    .HasColumnType("datetime")
                    .HasComment("校正日期");

                entity.Property(e => e.CorrectorId)
                    .HasMaxLength(255)
                    .HasComment("校正人員Id");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasComment("部門編號");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("部門名稱");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("文件編號");

                entity.Property(e => e.EstimateAHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("預計A段時數");

                entity.Property(e => e.EstimateBHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("預計B段時數");

                entity.Property(e => e.EstimateCHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("預計C段時數");

                entity.Property(e => e.EstimateEndDate)
                    .HasColumnType("datetime")
                    .HasComment("預計結束");

                entity.Property(e => e.EstimateHHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("預計假日時數");

                entity.Property(e => e.EstimateHours)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("預計時數");

                entity.Property(e => e.EstimateSalaryDay)
                    .HasColumnType("datetime")
                    .HasComment("計薪日期");

                entity.Property(e => e.EstimateStartDate)
                    .HasColumnType("datetime")
                    .HasComment("預計開始");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("datetime")
                    .HasComment("可休期限");

                entity.Property(e => e.ExtendDate)
                    .HasColumnType("datetime")
                    .HasComment("展延期限");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.HappenDate)
                    .HasColumnType("datetime")
                    .HasComment("加班日期");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_Holiday).HasComment("假日加班");

                entity.Property(e => e.Is_WorkingTypeAllowance).HasComment("含班別津貼");

                entity.Property(e => e.Memo).HasComment("請假說明");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("請假人員編號");

                entity.Property(e => e.WorkingDayTypeId).HasComment("加班班別");

                entity.Property(e => e.p_OvertimeCompensatoryId).HasComment("補嘗方式(加班費, 抵休假)");
            });

            modelBuilder.Entity<SaintEir_OvertimePayType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_OvertimePayType");

                entity.HasComment("加班費類別");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.En_HDOvertimePayType).HasComment("假日加班費計算方式, 1:依固定金額給薪, 2: 依時薪倍數給薪");

                entity.Property(e => e.En_NDOvertimePayType).HasComment("平日加班費計算方式, 1:依固定金額給薪, 2: 依時薪倍數給薪");

                entity.Property(e => e.En_OverHolidayDayLimitAction).HasComment("每月假日加班時數超過上限動作 1: 不檢查, 2:超限警告, 3: 超限拒?");

                entity.Property(e => e.En_OverNormalDayLimitAction).HasComment("每月平日加班時數超過上限動作 1: 不檢查, 2:超限警告, 3: 超限拒?");

                entity.Property(e => e.En_OvertimeDefaultAction).HasComment("加班單預設值 1: 不控管, 2: 僅能加班費, 3: 僅能補休");

                entity.Property(e => e.FemaleTaxFreeHours).HasComment("女性加班免稅時數");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.HDFoodAllowance).HasComment("假日誤餐費金額");

                entity.Property(e => e.HDFoodAllowanceInterval).HasComment("假日誤餐費開始時數");

                entity.Property(e => e.HDOvertimePayA)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("假日A時段每小時加班費");

                entity.Property(e => e.HDOvertimePayB)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("假日B時段每小時加班費");

                entity.Property(e => e.HDOvertimePayC)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("假日C時段每小時加班費");

                entity.Property(e => e.HolidayLimit).HasComment("每月假日加班時數上限");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MaleTaxFreeHours).HasComment("男性加班免稅時數");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.NDFoodAllowanceIntervalHour).HasComment("平日誤餐費間隔時數");

                entity.Property(e => e.NDFoodAllowancePerInterval).HasComment("平日誤餐費每時段增加金額");

                entity.Property(e => e.NDFoodAllowanceStart).HasComment("平日誤餐費啟動金額");

                entity.Property(e => e.NDFoodAllowanceStartHour).HasComment("平日誤餐費啟動時數");

                entity.Property(e => e.NDOvertimePayA)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("平日A時段每小時加班費");

                entity.Property(e => e.NDOvertimePayB)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("平日B時段每小時加班費");

                entity.Property(e => e.NDOvertimePayC)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("平日C時段每小時加班費");

                entity.Property(e => e.NDOvertimePayD)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("假日時段每小時加班費");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasComment("名稱");

                entity.Property(e => e.NormalDayLimit).HasComment("每月平日加班時數上限");

                entity.Property(e => e.NormalDayWarming).HasComment("每月平日加班超過時數警告");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_Package>(entity =>
            {
                entity.HasKey(e => e.PackageKeyNo);

                entity.ToTable("SaintEir_Package");

                entity.HasIndex(e => e.PackageKeyNo, "IDX_SaintEir_Package_PackageKeyNo");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToClassify).HasMaxLength(20);

                entity.Property(e => e.ClassifySet).HasMaxLength(100);

                entity.Property(e => e.Command).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultTradeType).HasDefaultValueSql("((1))");

                entity.Property(e => e.DiscountPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.NameInChinese).HasMaxLength(500);

                entity.Property(e => e.NameInEnglish).HasMaxLength(500);

                entity.Property(e => e.OriginalPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PackageMaxPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PackageMinPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PackageNo).HasMaxLength(20);

                entity.Property(e => e.PackagePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PackageSellPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_PackageItem>(entity =>
            {
                entity.HasKey(e => e.PackageItemNo)
                    .HasName("PK__SaintEir_Package__7073AF84");

                entity.ToTable("SaintEir_PackageItem");
            });

            modelBuilder.Entity<SaintEir_PackageReward>(entity =>
            {
                entity.HasKey(e => e.PackageRewardNo);

                entity.ToTable("SaintEir_PackageReward");

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);

                entity.Property(e => e.RewardPercentage).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<SaintEir_PackageRewardIntro>(entity =>
            {
                entity.HasKey(e => e.PackageRewardIntroNo);

                entity.ToTable("SaintEir_PackageRewardIntro");

                entity.Property(e => e.RewardPercentage).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<SaintEir_PaidTimeOffSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_PaidTimeOffSetting");

                entity.HasComment("特休設定");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Days).HasComment("天");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Month).HasComment("滿月數");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Years).HasComment("年");
            });

            modelBuilder.Entity<SaintEir_PaiedHoliday>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_PaiedHoliday");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateList).IsRequired();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_Parameter>(entity =>
            {
                entity.ToTable("SaintEir_Parameter");

                entity.HasComment("參數");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasComment("名稱");

                entity.Property(e => e.OrderNo).HasDefaultValueSql("((500))");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("類別, FK to ParameterControl.Type");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.SaintEir_Parameters)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaintEir_Parameter_SaintEir_ParameterControl");
            });

            modelBuilder.Entity<SaintEir_ParameterControl>(entity =>
            {
                entity.HasKey(e => e.Type)
                    .HasName("PK_ParameterControl");

                entity.ToTable("SaintEir_ParameterControl");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SaintEir_PayHistory>(entity =>
            {
                entity.HasKey(e => e.PayHistoryNo)
                    .HasName("PK__SaintEir_PayHist__3429BB53");

                entity.ToTable("SaintEir_PayHistory");

                entity.HasIndex(e => e.BelongToInProcess, "IDX_SaintEir_PayHistory_BelongToInProcess");

                entity.Property(e => e.ANo).HasMaxLength(255);

                entity.Property(e => e.Command).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Paid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayWay).HasMaxLength(255);

                entity.Property(e => e.TaxPaid).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.BelongToPurchaseNavigation)
                    .WithMany(p => p.SaintEir_PayHistories)
                    .HasForeignKey(d => d.BelongToPurchase)
                    .HasConstraintName("FKDEB793B0E46791E8");
            });

            modelBuilder.Entity<SaintEir_PayStatus>(entity =>
            {
                entity.HasKey(e => e.PayStatusNo);

                entity.ToTable("SaintEir_PayStatus");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SaintEir_PayrollSettlementDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_PayrollSettlementDate");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifyDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_PendingDocument>(entity =>
            {
                entity.HasKey(e => e.PendingNo)
                    .HasName("PK__SaintEir__D811728B09657ECF");

                entity.ToTable("SaintEir_PendingDocument");

                entity.Property(e => e.Attendant).HasMaxLength(50);

                entity.Property(e => e.BelongToDocumentName).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Doctor).HasMaxLength(50);

                entity.Property(e => e.Nurse).HasMaxLength(50);

                entity.Property(e => e.PendingType).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_PersonalReward>(entity =>
            {
                entity.HasKey(e => e.PersonalRewardNo)
                    .HasName("PK__SaintEir_Persona__32CB82C6");

                entity.ToTable("SaintEir_PersonalReward");

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);

                entity.Property(e => e.ClassifySet).HasMaxLength(255);

                entity.Property(e => e.ClassifySetName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RewardPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_PrePayHistory>(entity =>
            {
                entity.HasKey(e => e.PrePayHistoryNo)
                    .HasName("PK__SaintEir_PrePayH__1A34DF26");

                entity.ToTable("SaintEir_PrePayHistory");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PayWay).HasMaxLength(255);

                entity.Property(e => e.PrePayTotalFee).HasColumnType("decimal(19, 5)");
            });

            modelBuilder.Entity<SaintEir_Product>(entity =>
            {
                entity.HasKey(e => e.ProductKeyNo);

                entity.ToTable("SaintEir_Product");

                entity.HasIndex(e => e.ProductKeyNo, "IDX_SaintEir_Product_ProductKeyNo");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToClassify).HasMaxLength(20);

                entity.Property(e => e.Command).HasMaxLength(500);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditValue).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.DefaultTradeType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FollowerReward).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.KeyWord).HasMaxLength(500);

                entity.Property(e => e.MaterialEstimate).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.MaxPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MemberPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MinPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NameInChinese).HasMaxLength(500);

                entity.Property(e => e.NameInEnglish).HasMaxLength(500);

                entity.Property(e => e.PicFileName).HasMaxLength(30);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductNo).HasMaxLength(20);

                entity.Property(e => e.RelatedProducts).HasMaxLength(500);

                entity.Property(e => e.RequireSelectMaterial).HasDefaultValueSql("((1))");

                entity.Property(e => e.RewardPercet).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SAReward).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatisticUnit).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ProductInBranch>(entity =>
            {
                entity.HasKey(e => e.ProductInBranchNo);

                entity.ToTable("SaintEir_ProductInBranch");

                entity.Property(e => e.InBranch).HasMaxLength(100);

                entity.Property(e => e.ProductInBranchType).HasMaxLength(10);
            });

            modelBuilder.Entity<SaintEir_ProductOrder>(entity =>
            {
                entity.HasKey(e => e.ProductOrderNo);

                entity.ToTable("SaintEir_ProductOrder");

                entity.Property(e => e.ProductOrderNo).HasMaxLength(255);

                entity.Property(e => e.AcceptBy).HasMaxLength(255);

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.ApplyBy).HasMaxLength(255);

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.BelongToBranch).HasMaxLength(255);

                entity.Property(e => e.ByWhom).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromProductOrder).HasMaxLength(255);

                entity.Property(e => e.GetProductDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.Supplier).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ProductOrderItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_ProductOrderItem");

                entity.Property(e => e.AcceptQuantity).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ApplyQuantity).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.BelongToProductOrder).HasMaxLength(255);

                entity.Property(e => e.ProductOrderItemNo).ValueGeneratedOnAdd();

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<SaintEir_ProductPrice>(entity =>
            {
                entity.HasKey(e => e.ProductPriceNo)
                    .HasName("PK__SaintEir_Product__7A8729A3");

                entity.ToTable("SaintEir_ProductPrice");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ProductReward>(entity =>
            {
                entity.HasKey(e => e.ProductRewardNo)
                    .HasName("PK__SaintEir_Product__2B2A60FE");

                entity.ToTable("SaintEir_ProductReward");

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);

                entity.Property(e => e.BonusType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Cost).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.RewardMoney).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.RewardPercentage).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<SaintEir_ProductRewardExtra>(entity =>
            {
                entity.HasKey(e => e.ProductRewardExtraNo);

                entity.ToTable("SaintEir_ProductRewardExtra");

                entity.Property(e => e.BelongToLoginUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.TextExpressionReward)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TextExpressionTrait)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.ProductRewardNoNavigation)
                    .WithMany(p => p.SaintEir_ProductRewardExtras)
                    .HasForeignKey(d => d.ProductRewardNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaintEir_ProductRewardExtra_SaintEir_ProductReward");
            });

            modelBuilder.Entity<SaintEir_ProductRewardIntro>(entity =>
            {
                entity.HasKey(e => e.ProductRewardIntroNo);

                entity.ToTable("SaintEir_ProductRewardIntro");

                entity.Property(e => e.RewardPercentage).HasColumnType("decimal(9, 1)");
            });

            modelBuilder.Entity<SaintEir_Province>(entity =>
            {
                entity.ToTable("SaintEir_Province");

                entity.HasComment("省籍資料");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("職等編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EngName)
                    .HasMaxLength(50)
                    .HasComment("英文名稱");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("職等名稱");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_Purchase>(entity =>
            {
                entity.HasKey(e => e.PurchaseNo)
                    .HasName("PK__SaintEir_Purchas__7814D14C");

                entity.ToTable("SaintEir_Purchase");

                entity.HasIndex(e => e.BelongToInProcess, "IDX_SaintEir_Purchase_BelongToInProcess");

                entity.HasIndex(e => e.ByMember, "IDX_SaintEir_Purchase_ByMember");

                entity.HasIndex(e => e.PurchaseDate, "purchase_date");

                entity.Property(e => e.ANo).HasMaxLength(50);

                entity.Property(e => e.AlreadyPaid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.CustomerPhone).HasMaxLength(255);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DiscountPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IncomeNo).HasMaxLength(255);

                entity.Property(e => e.NotPayYet).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.SellPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ShouldPay).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SoldBy).HasMaxLength(255);

                entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.SoldByNavigation)
                    .WithMany(p => p.SaintEir_Purchases)
                    .HasForeignKey(d => d.SoldBy)
                    .HasConstraintName("FK3232843292E1E6E6");
            });

            modelBuilder.Entity<SaintEir_PurchaseItem>(entity =>
            {
                entity.HasKey(e => e.PurchaseItemNo)
                    .HasName("PK__SaintEir_Purchas__762C88DA");

                entity.ToTable("SaintEir_PurchaseItem");

                entity.Property(e => e.DiscountPercentage).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SellPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SoldOutPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.BelongToPurchaseNavigation)
                    .WithMany(p => p.SaintEir_PurchaseItems)
                    .HasForeignKey(d => d.BelongToPurchase)
                    .HasConstraintName("FK3CED833FE46791E8");
            });

            modelBuilder.Entity<SaintEir_PurchaseItemCredit>(entity =>
            {
                entity.HasKey(e => e.PurchaseItemCreditNo)
                    .HasName("PK__SaintEir__658D3068AEFCFCF8");

                entity.ToTable("SaintEir_PurchaseItemCredit");

                entity.Property(e => e.CreditPoint).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SaintEir_PurchaseItemStatus>(entity =>
            {
                entity.HasKey(e => e.PurchaseItemStatusNo)
                    .HasName("PK__SaintEir__B7AB8917F3278BF9");

                entity.ToTable("SaintEir_PurchaseItemStatus");

                entity.HasOne(d => d.BelongToPurchaseItemNavigation)
                    .WithMany(p => p.SaintEir_PurchaseItemStatuses)
                    .HasForeignKey(d => d.BelongToPurchaseItem)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaintEir_PurchaseItemStatus_SaintEir_PurchaseItem");
            });

            modelBuilder.Entity<SaintEir_PurchaseItemSubTotal>(entity =>
            {
                entity.HasKey(e => e.PurchaseItemSubTotalNo);

                entity.ToTable("SaintEir_PurchaseItemSubTotal");

                entity.Property(e => e.BelongDate).HasColumnType("datetime");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.ItemNo).HasMaxLength(20);

                entity.Property(e => e.SoldOutPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SaintEir_RegularList>(entity =>
            {
                entity.HasKey(e => e.RegularListNo);

                entity.ToTable("SaintEir_RegularList");

                entity.Property(e => e.BelongToUser).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.GvName).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_RegularListItem>(entity =>
            {
                entity.HasKey(e => e.RegularListItemNo);

                entity.ToTable("SaintEir_RegularListItem");

                entity.Property(e => e.BelongToRegularList).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_Remaining>(entity =>
            {
                entity.HasKey(e => e.RemainingNo);

                entity.ToTable("SaintEir_Remaining");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.SA).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ValidDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_RemainingCheck>(entity =>
            {
                entity.HasKey(e => e.RemainingCheckNo)
                    .HasName("PK__SaintEir__E2D7E9F324414F00");

                entity.ToTable("SaintEir_RemainingCheck");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_RemindParam>(entity =>
            {
                entity.HasKey(e => e.RemindParamNo);

                entity.ToTable("SaintEir_RemindParam");

                entity.Property(e => e.Param).HasMaxLength(50);

                entity.Property(e => e.TreatmentType).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_Reminder>(entity =>
            {
                entity.HasKey(e => e.ReminderNo);

                entity.ToTable("SaintEir_Reminder");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EarlyRemindDate).HasColumnType("datetime");

                entity.Property(e => e.RemindDate).HasColumnType("datetime");

                entity.Property(e => e.RemindUser).HasMaxLength(255);

                entity.Property(e => e.ReminderType).HasMaxLength(50);

                entity.Property(e => e.SignedBy).HasMaxLength(255);

                entity.Property(e => e.SignedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ResTimeLock>(entity =>
            {
                entity.HasKey(e => e.ResTimeLockNo);

                entity.ToTable("SaintEir_ResTimeLock");

                entity.Property(e => e.BelongToBranch).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_Reservation>(entity =>
            {
                entity.HasKey(e => e.ReservationNo)
                    .HasName("PK__SaintEir_Reserva__79FD19BE");

                entity.ToTable("SaintEir_Reservation");

                entity.Property(e => e.Attendant).HasMaxLength(255);

                entity.Property(e => e.Beautician).HasMaxLength(255);

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.Birthday).HasMaxLength(255);

                entity.Property(e => e.ByConsult).HasMaxLength(20);

                entity.Property(e => e.ByDr).HasMaxLength(20);

                entity.Property(e => e.ByNurceA).HasMaxLength(20);

                entity.Property(e => e.ByNurceB).HasMaxLength(20);

                entity.Property(e => e.ByResource).HasMaxLength(20);

                entity.Property(e => e.CancelReason).HasMaxLength(500);

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.CustomerType).HasMaxLength(20);

                entity.Property(e => e.Detail).HasMaxLength(500);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EntryType3).HasMaxLength(50);

                entity.Property(e => e.EventBackColor).HasMaxLength(50);

                entity.Property(e => e.IsConflict).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsReserved3).HasMaxLength(50);

                entity.Property(e => e.MemberNo).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.OperationItemNo).HasMaxLength(20);

                entity.Property(e => e.RemindCompleteDate).HasColumnType("datetime");

                entity.Property(e => e.RemindCompleteUser).HasMaxLength(255);

                entity.Property(e => e.ReminderComment).HasMaxLength(255);

                entity.Property(e => e.ReminderDate).HasColumnType("datetime");

                entity.Property(e => e.ReservationType).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ReservationCommon>(entity =>
            {
                entity.HasKey(e => e.CommonWordNo);

                entity.ToTable("SaintEir_ReservationCommon");

                entity.Property(e => e.CommonWord).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_ReservationLimit>(entity =>
            {
                entity.HasKey(e => e.LimitNo);

                entity.ToTable("SaintEir_ReservationLimit");

                entity.Property(e => e.BelongToBranch).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ReservationLimitRelate>(entity =>
            {
                entity.HasKey(e => e.RealteNo);

                entity.ToTable("SaintEir_ReservationLimitRelate");

                entity.Property(e => e.BelongToBranch).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_ResignApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_ResignApplication");

                entity.HasComment("離職申請單");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("datetime")
                    .HasComment("日期");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("datetime")
                    .HasComment("核決日期");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(255)
                    .HasComment("核決人員");

                entity.Property(e => e.ArrivedDate)
                    .HasColumnType("datetime")
                    .HasComment("到職日期");

                entity.Property(e => e.AssignBranchNo)
                    .HasMaxLength(20)
                    .HasComment("指派店別(部門)");

                entity.Property(e => e.CorrecterId)
                    .HasMaxLength(255)
                    .HasComment("校正人員Id");

                entity.Property(e => e.CorrectionDate)
                    .HasColumnType("datetime")
                    .HasComment("校正日期");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasComment("隸屬部門");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("單號");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasComment("生效日期");

                entity.Property(e => e.EmployeeTypeId).HasComment("員工類型");

                entity.Property(e => e.EnglishJobTitle)
                    .HasMaxLength(50)
                    .HasComment("英文職稱");

                entity.Property(e => e.ExpectedReturnDate)
                    .HasColumnType("datetime")
                    .HasComment("預定復職日");

                entity.Property(e => e.FinalUIDate)
                    .HasColumnType("datetime")
                    .HasComment("UI 失效日");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_NoHire).HasComment("永不錄用");

                entity.Property(e => e.JobLevelId).HasComment("職級編號");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .HasComment("中文職稱");

                entity.Property(e => e.JobTitleId).HasComment("職稱編號");

                entity.Property(e => e.NoHireReason).HasComment("永不錄用原因");

                entity.Property(e => e.ResignExplanation).HasComment("離職原因說明");

                entity.Property(e => e.SalaryDepartmentId).HasComment("薪資隸屬部門");

                entity.Property(e => e.SeniorityInMonth).HasComment("服務年資(月)");

                entity.Property(e => e.SystemProcessDate)
                    .HasColumnType("datetime")
                    .HasComment("系統處理時間");

                entity.Property(e => e.TakeOfficeEffectiveDate)
                    .HasColumnType("datetime")
                    .HasComment("到職生效日期");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("到職人員編號(FK:PRO2E_AUTH_LOGIN_USER.UserId)");

                entity.Property(e => e.p_ResignReason).HasComment("離職原因");

                entity.Property(e => e.p_ResignType).HasComment("異動性質");

                entity.Property(e => e.p_SalarySubject).HasComment("薪資科目");
            });

            modelBuilder.Entity<SaintEir_Resource>(entity =>
            {
                entity.HasKey(e => e.ResourceNo)
                    .HasName("PK__SaintEir_Resourc__7DCDAAA2");

                entity.ToTable("SaintEir_Resource");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.NameInChinese).HasMaxLength(300);

                entity.Property(e => e.NameInEnglish).HasMaxLength(300);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_RetireInsuranceAdj>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_RetireInsuranceAdj");

                entity.HasComment("勞退調整記錄");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DeleterId).HasMaxLength(255);

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasComment("生效日期");

                entity.Property(e => e.En_Type).HasComment("異動類別$加保=100,修改投保薪資=200,退保=300");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InsuranceDepartment).HasMaxLength(32);

                entity.Property(e => e.Salary).HasComment("投保薪資");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_RewardAdditionalItem>(entity =>
            {
                entity.HasKey(e => e.RewardAdditionalItemNO)
                    .HasName("PK_SaintEir_AdditionalItem");

                entity.ToTable("SaintEir_RewardAdditionalItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BelongToBranch).HasMaxLength(50);

                entity.Property(e => e.BelongToUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.RationDate).HasColumnType("datetime");

                entity.Property(e => e.Reason).IsRequired();

                entity.Property(e => e.TableName).HasMaxLength(100);
            });

            modelBuilder.Entity<SaintEir_RewardBaseSetting>(entity =>
            {
                entity.HasKey(e => e.RewardBaseSettingNo);

                entity.ToTable("SaintEir_RewardBaseSetting");

                entity.Property(e => e.RewardBase).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SaintEir_RewardDistribution>(entity =>
            {
                entity.HasKey(e => e.RewardDistributionNo);

                entity.ToTable("SaintEir_RewardDistribution");

                entity.Property(e => e.AchievementAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.AchievementPercent).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToUser).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RewardAmountSource).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RewardDate).HasColumnType("datetime");

                entity.Property(e => e.RewardPercent).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_RewardPaid>(entity =>
            {
                entity.HasKey(e => e.RewardPaidKeyNo);

                entity.ToTable("SaintEir_RewardPaid");

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_RewardPaidItem>(entity =>
            {
                entity.HasKey(e => e.RewardPaidItemKeyNo);

                entity.ToTable("SaintEir_RewardPaidItem");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SaintEir_SClassify>(entity =>
            {
                entity.HasKey(e => e.ClassNo);

                entity.ToTable("SaintEir_SClassify");

                entity.Property(e => e.ClassChtTitle).HasMaxLength(30);

                entity.Property(e => e.ClassCode).HasMaxLength(10);

                entity.Property(e => e.ClassEngTitle).HasMaxLength(30);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_SMSSendHistory>(entity =>
            {
                entity.HasKey(e => e.SMSSendHistoryNo)
                    .HasName("PK__SaintEir_SMSSend__6C390A4C");

                entity.ToTable("SaintEir_SMSSendHistory");

                entity.Property(e => e.AdvisoryEventNo).HasDefaultValueSql("('0')");

                entity.Property(e => e.BatchID).HasMaxLength(500);

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToCustomer).HasMaxLength(500);

                entity.Property(e => e.BelongToType).HasMaxLength(20);

                entity.Property(e => e.Cost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerPhone).HasMaxLength(500);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.PostTime).HasColumnType("datetime");

                entity.Property(e => e.SMSContent).HasMaxLength(500);

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.Status_Every8D).HasMaxLength(500);

                entity.Property(e => e.Status_SMS).HasMaxLength(500);

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_SMSWording>(entity =>
            {
                entity.HasKey(e => e.SMSWordingNo)
                    .HasName("PK__SaintEir_SMSWord__6E2152BE");

                entity.ToTable("SaintEir_SMSWording");

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LanguageCode).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(20);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_Salary>(entity =>
            {
                entity.HasKey(e => new { e.YM, e.UserId })
                    .HasName("PK_SaintEir_Salary_1");

                entity.ToTable("SaintEir_Salary");

                entity.HasComment("薪資表");

                entity.Property(e => e.YM)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("年月");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasComment("員工編號");

                entity.Property(e => e.ACEndDate)
                    .HasColumnType("datetime")
                    .HasComment("出缺勤統計結束");

                entity.Property(e => e.ACStartDate)
                    .HasColumnType("datetime")
                    .HasComment("出缺勤統計開始");

                entity.Property(e => e.AbsentDeduction).HasComment("缺勤扣薪");

                entity.Property(e => e.AbsentMemo).HasComment("缺勤備註");

                entity.Property(e => e.ActualDays).HasComment("實際日曆天(當月到職者), 有包括請假");

                entity.Property(e => e.AddOnRegular).HasComment("常態加給(全計入全薪中)");

                entity.Property(e => e.AddOnRegularMomo).HasComment("常態加給備註");

                entity.Property(e => e.AddOnSpecial).HasComment("非常態加給(不計入全薪中)");

                entity.Property(e => e.AddOnSpecialMemo).HasComment("非常態加給備註");

                entity.Property(e => e.AdjAmount).HasComment("調整金額");

                entity.Property(e => e.AdjMemo).HasComment("調整備註");

                entity.Property(e => e.AnnualLeaveToSalaryAmount).HasComment("特休轉薪資");

                entity.Property(e => e.AttendanceBonus).HasComment("全勤獎金");

                entity.Property(e => e.BasicSalary).HasComment("基本薪資");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DependentsCount).HasComment("健保眷屬人數");

                entity.Property(e => e.Error).HasComment("異常");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.HealthyInsuranceDeduction).HasComment("健保自付金額");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InsuranceAmount).HasComment("勞健保投保金額");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .HasComment("職稱");

                entity.Property(e => e.LaborInsuranceDeduction).HasComment("勞保自付金額");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasComment("姓名");

                entity.Property(e => e.OvertimeMemo)
                    .IsRequired()
                    .HasDefaultValueSql("('')")
                    .HasComment("加班費說明");

                entity.Property(e => e.OvertimePay).HasComment("加班費");

                entity.Property(e => e.RetireInsuranceAmount).HasComment("勞退提撥金額");

                entity.Property(e => e.ScheduledDays).HasComment("表定日曆天");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WithholdAmount).HasComment("代扣金額");

                entity.Property(e => e.WithholdMemo)
                    .IsRequired()
                    .HasDefaultValueSql("('')")
                    .HasComment("代扣說明");

                entity.Property(e => e.WorkingHourPerDay)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("每日工作時數");

                entity.Property(e => e.p_HourPayBase).HasComment("時薪計算基準");
            });

            modelBuilder.Entity<SaintEir_SalaryDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_SalaryDetail");

                entity.HasComment("薪資表明細");

                entity.Property(e => e.Amount).HasComment("金額");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.En_Type).HasComment("加減項");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_Gift).HasComment("是否為禮金項目(可以在增減項批次發放)");

                entity.Property(e => e.Is_Ratio)
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否依在職比例計算.");

                entity.Property(e => e.Is_Regular).HasComment("是否為常態薪資項目(加入全薪計算)");

                entity.Property(e => e.Is_Withhold).HasComment("是否為代扣");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .HasComment("新資項目代碼");

                entity.Property(e => e.ItemId).HasComment("新資項目編號");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("新資項目名稱");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasComment("備註");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("員工編號");

                entity.Property(e => e.YM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("年月");
            });

            modelBuilder.Entity<SaintEir_SalaryDetail_Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_SalaryDetail_Log");

                entity.HasComment("薪資表明細");

                entity.Property(e => e.Amount).HasComment("金額");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.En_Type).HasComment("加減項");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_Gift).HasComment("是否為禮金項目(可以在增減項批次發放)");

                entity.Property(e => e.Is_Ratio)
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否依在職比例計算.");

                entity.Property(e => e.Is_Regular).HasComment("是否為常態薪資項目(加入全薪計算)");

                entity.Property(e => e.Is_Withhold).HasComment("是否為代扣");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .HasComment("新資項目代碼");

                entity.Property(e => e.ItemId).HasComment("新資項目編號");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("新資項目名稱");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasComment("備註");

                entity.Property(e => e.ProcessId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("員工編號");

                entity.Property(e => e.YM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("年月");
            });

            modelBuilder.Entity<SaintEir_SalaryItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_SalaryItem");

                entity.HasComment("薪資項目");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.En_Type).HasComment("類別: 1: 津貼(加項), -1:扣款(減項)");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_Gift).HasComment("是否為禮金項目(可以在增減項批次發放)");

                entity.Property(e => e.Is_Ratio)
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否依在職比例計算.");

                entity.Property(e => e.Is_Regular).HasComment("是否為常態薪資項目(加入全薪計算)");

                entity.Property(e => e.Is_Withhold).HasComment("是否為代扣項目");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名稱");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_Salary_Log>(entity =>
            {
                entity.HasKey(e => new { e.YM, e.UserId, e.ProcessId, e.Type });

                entity.ToTable("SaintEir_Salary_Log");

                entity.HasComment("薪資表");

                entity.Property(e => e.YM)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("年月");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasComment("員工編號");

                entity.Property(e => e.ProcessId).HasMaxLength(128);

                entity.Property(e => e.Type).HasMaxLength(32);

                entity.Property(e => e.ACEndDate)
                    .HasColumnType("datetime")
                    .HasComment("出缺勤統計結束");

                entity.Property(e => e.ACStartDate)
                    .HasColumnType("datetime")
                    .HasComment("出缺勤統計開始");

                entity.Property(e => e.AbsentDeduction).HasComment("缺勤扣薪");

                entity.Property(e => e.AbsentMemo).HasComment("缺勤備註");

                entity.Property(e => e.ActualDays).HasComment("實際日曆天(當月到職者), 有包括請假");

                entity.Property(e => e.AddOnRegular).HasComment("常態加給(全計入全薪中)");

                entity.Property(e => e.AddOnRegularMomo).HasComment("常態加給備註");

                entity.Property(e => e.AddOnSpecial).HasComment("非常態加給(不計入全薪中)");

                entity.Property(e => e.AddOnSpecialMemo).HasComment("非常態加給備註");

                entity.Property(e => e.AdjAmount).HasComment("調整金額");

                entity.Property(e => e.AdjMemo).HasComment("調整備註");

                entity.Property(e => e.AttendanceBonus).HasComment("全勤獎金");

                entity.Property(e => e.BasicSalary).HasComment("基本薪資");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DependentsCount).HasComment("健保眷屬人數");

                entity.Property(e => e.Error).HasComment("異常");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.HealthyInsuranceDeduction).HasComment("健保自付金額");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InsuranceAmount).HasComment("勞健保投保金額");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .HasComment("職稱");

                entity.Property(e => e.LaborInsuranceDeduction).HasComment("勞保自付金額");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasComment("姓名");

                entity.Property(e => e.OvertimeMemo)
                    .IsRequired()
                    .HasDefaultValueSql("('')")
                    .HasComment("加班費說明");

                entity.Property(e => e.OvertimePay).HasComment("加班費");

                entity.Property(e => e.RetireInsuranceAmount).HasComment("勞退提撥金額");

                entity.Property(e => e.ScheduledDays).HasComment("表定日曆天");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WithholdAmount).HasComment("代扣金額");

                entity.Property(e => e.WithholdMemo)
                    .IsRequired()
                    .HasDefaultValueSql("('')")
                    .HasComment("代扣說明");

                entity.Property(e => e.WorkingHourPerDay)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("每日工作時數");

                entity.Property(e => e.p_HourPayBase).HasComment("時薪計算基準");
            });

            modelBuilder.Entity<SaintEir_SaleReward>(entity =>
            {
                entity.HasKey(e => e.SaleRewardNo);

                entity.ToTable("SaintEir_SaleReward");

                entity.Property(e => e.AchievementAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);

                entity.Property(e => e.ClassifyName).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.IntroFee).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.IsPackageOrProduct).HasMaxLength(50);

                entity.Property(e => e.ProductClassify).HasMaxLength(50);

                entity.Property(e => e.RewardAmountSource).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RewardAmout).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RewardDate).HasColumnType("datetime");

                entity.Property(e => e.RewardPercentage).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.SoldOutPrice).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_SaleValue>(entity =>
            {
                entity.HasKey(e => e.SaleValueNo);

                entity.ToTable("SaintEir_SaleValue");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.MaterialStockIn).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.MaterialStockOut).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PackageST).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ProductST).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_SaleValue_Backup>(entity =>
            {
                entity.HasKey(e => e.SaleValueNo);

                entity.ToTable("SaintEir_SaleValue_Backup");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.MaterialStockIn).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.MaterialStockOut).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PackageST).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ProductST).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_SalesRanking>(entity =>
            {
                entity.HasKey(e => e.SalesRankingNo);

                entity.ToTable("SaintEir_SalesRanking");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BranchNo).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseItemNo).HasMaxLength(50);

                entity.Property(e => e.StaticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_Serial>(entity =>
            {
                entity.HasKey(e => e.SerialId)
                    .HasName("PK__SaintEir_Serial__6ABAD62E");

                entity.ToTable("SaintEir_Serial");

                entity.Property(e => e.PurchaseIncomeDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ServiceControl>(entity =>
            {
                entity.HasKey(e => e.ServiceControlNo)
                    .HasName("PK__SaintEir__2A3C7D10D65142C7");

                entity.ToTable("SaintEir_ServiceControl");

                entity.HasIndex(e => e.BelongToBranch, "IDX_SaintEir_ServiceControl_BelongToBranch");

                entity.HasIndex(e => e.CreatedDate, "IDX_SaintEir_ServiceControl_CreatedDate");

                entity.Property(e => e.Attendant)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BelongToBranch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BelongToDoctor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.StartingTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ServiceOrder>(entity =>
            {
                entity.HasKey(e => e.ServiceOrderNo)
                    .HasName("PK_ServiceOrder");

                entity.ToTable("SaintEir_ServiceOrder");

                entity.Property(e => e.BelongToBranch).HasMaxLength(50);

                entity.Property(e => e.BelongToUser).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ServiceStatic>(entity =>
            {
                entity.HasKey(e => e.ServiceStaticNo)
                    .HasName("PK_ServiceStatic");

                entity.ToTable("SaintEir_ServiceStatic");

                entity.Property(e => e.BranchNo).HasMaxLength(20);

                entity.Property(e => e.StaticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_ShiftApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_ShiftApplication");

                entity.HasComment("調班申請單");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("datetime")
                    .HasComment("日期");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasComment("部門編號");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("部門名稱");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("文件編號");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("調班區間結束");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Memo).HasComment("調班說明");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("調班區間開始");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("調班人員編號");
            });

            modelBuilder.Entity<SaintEir_ShiftApplicationDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_ShiftApplicationDetail");

                entity.HasComment("調班申請明細");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NewWorkingDayTypeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("新班別代碼");

                entity.Property(e => e.NewWorkingDayTypeId).HasComment("新班別編號");

                entity.Property(e => e.NewWorkingDayTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("新班別名稱");

                entity.Property(e => e.OldWorkingDayTypeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("原班別代碼");

                entity.Property(e => e.OldWorkingDayTypeId).HasComment("原班別編號");

                entity.Property(e => e.OldWorkingDayTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("原班別名稱");

                entity.Property(e => e.ShiftId).HasComment("調整單編號");

                entity.Property(e => e.YMD)
                    .HasColumnType("datetime")
                    .HasComment("調整日期");
            });

            modelBuilder.Entity<SaintEir_SignDoc>(entity =>
            {
                entity.HasKey(e => e.SignDocNo);

                entity.ToTable("SaintEir_SignDoc");

                entity.Property(e => e.Application)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ByDr).HasMaxLength(50);

                entity.Property(e => e.ByFollower).HasMaxLength(50);

                entity.Property(e => e.ByNurse).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SignedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_SignDocItem>(entity =>
            {
                entity.HasKey(e => e.SignDocItemNo);

                entity.ToTable("SaintEir_SignDocItem");

                entity.Property(e => e.ItemId).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_SignDocRelative>(entity =>
            {
                entity.HasKey(e => e.SignDocRelativeNo);

                entity.ToTable("SaintEir_SignDocRelative");

                entity.HasIndex(e => e.BelongToSignDoc, "IDX_SaintEir_SignDocRelative_BelongToSignDoc");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BelongToConsumptionHistoryNavigation)
                    .WithMany(p => p.SaintEir_SignDocRelatives)
                    .HasForeignKey(d => d.BelongToConsumptionHistory)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaintEir_SignDocRelative_SaintEir_ComsumptionHistory");

                entity.HasOne(d => d.BelongToPurchaseItemNavigation)
                    .WithMany(p => p.SaintEir_SignDocRelatives)
                    .HasForeignKey(d => d.BelongToPurchaseItem)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaintEir_SignDocRelative_SaintEir_PurchaseItem");

                entity.HasOne(d => d.BelongToSignDocNavigation)
                    .WithMany(p => p.SaintEir_SignDocRelatives)
                    .HasForeignKey(d => d.BelongToSignDoc)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaintEir_SignDocRelative_SaintEir_SignDoc");
            });

            modelBuilder.Entity<SaintEir_Signature>(entity =>
            {
                entity.HasKey(e => e.SignatureNo);

                entity.ToTable("SaintEir_Signature");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SignaturePath).HasMaxLength(200);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_SignatureRelative>(entity =>
            {
                entity.HasKey(e => e.SignatureRelativeNo);

                entity.ToTable("SaintEir_SignatureRelative");

                entity.Property(e => e.SignedBy).HasMaxLength(255);

                entity.Property(e => e.SignedDate).HasColumnType("datetime");

                entity.Property(e => e.ValueType).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_StockType>(entity =>
            {
                entity.HasKey(e => e.StockTypeNo)
                    .HasName("PK_StockType");

                entity.ToTable("SaintEir_StockType");

                entity.Property(e => e.StockTypeID).HasMaxLength(255);

                entity.Property(e => e.StockTypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_Subsidy>(entity =>
            {
                entity.ToTable("SaintEir_Subsidy");

                entity.HasComment("補助等級");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("補助編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.HISubsidyAfter9904).HasComment("健保費99年4月後補助上限");

                entity.Property(e => e.HISubsidyBefore9904).HasComment("健保費99年4月前調整補助");

                entity.Property(e => e.HISubsidyRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("健保費補助比率");

                entity.Property(e => e.LISubsidyRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("勞保費補助比率");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("補助名稱");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_Supplier>(entity =>
            {
                entity.HasKey(e => e.SupplierNo)
                    .HasName("PK__SaintEir_Supplie__17236851");

                entity.ToTable("SaintEir_Supplier");

                entity.Property(e => e.AccountNo).HasMaxLength(20);

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ListOrder).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(20);

                entity.Property(e => e.SupplierAddress).HasMaxLength(20);

                entity.Property(e => e.SupplierKeyman).HasMaxLength(20);

                entity.Property(e => e.SupplierKeymanPhone).HasMaxLength(20);

                entity.Property(e => e.SupplierName).HasMaxLength(20);

                entity.Property(e => e.SupplierNumber).HasMaxLength(20);

                entity.Property(e => e.SupplierPhone).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VATnumber).HasMaxLength(20);
            });

            modelBuilder.Entity<SaintEir_SupplyList>(entity =>
            {
                entity.HasKey(e => e.SupplyListNo);

                entity.ToTable("SaintEir_SupplyList");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_TakeOffApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_TakeOffApplication");

                entity.HasComment("請假單");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("datetime")
                    .HasComment("日期");

                entity.Property(e => e.ArriveDate)
                    .HasColumnType("datetime")
                    .HasComment("到職日期");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeductionDay)
                    .HasColumnType("datetime")
                    .HasComment("扣薪日期");

                entity.Property(e => e.DepartmentId).HasComment("部門編號");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("部門名稱");

                entity.Property(e => e.DeputyDepartmentId).HasComment("代理人部門編號");

                entity.Property(e => e.DeputyDepartmentName)
                    .HasMaxLength(50)
                    .HasComment("代理人部門名稱");

                entity.Property(e => e.DeputyId)
                    .HasMaxLength(255)
                    .HasComment("代理人編號");

                entity.Property(e => e.DeputyName)
                    .HasMaxLength(50)
                    .HasComment("代理人姓名");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("文件編號");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("結束日期時間");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Memo).HasComment("請假說明");

                entity.Property(e => e.Seniority_Month).HasComment("應計年資");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("起始日期時間");

                entity.Property(e => e.TakeOffTypeId).HasComment("假別編號");

                entity.Property(e => e.TakeOffTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("假別名稱");

                entity.Property(e => e.TakeOffUnit_Minute).HasComment("最小單位_分鐘");

                entity.Property(e => e.TotalDay)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("總天數");

                entity.Property(e => e.TotalHour)
                    .HasColumnType("decimal(18, 1)")
                    .HasComment("總小時數");

                entity.Property(e => e.TotalMinutes).HasComment("總分鐘數");

                entity.Property(e => e.TotalUnit).HasComment("總單位數");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("請假人員編號");
            });

            modelBuilder.Entity<SaintEir_TakeOffApplicationAttachement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_TakeOffApplicationAttachement");

                entity.Property(e => e.CeratorUserId)
                    .HasMaxLength(255)
                    .HasComment("建立人");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("建立日期");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("datetime")
                    .HasComment("刪除日期");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsDeleted).HasComment("是否被刪除");

                entity.Property(e => e.MainId).HasComment("請假單編號");

                entity.Property(e => e.OriginalFileName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("原始檔案名稱");

                entity.Property(e => e.RemoverUserId)
                    .HasMaxLength(255)
                    .HasComment("刪除人");

                entity.Property(e => e.StoreFileName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasComment("存檔檔案名稱");
            });

            modelBuilder.Entity<SaintEir_TakeOffCategory>(entity =>
            {
                entity.ToTable("SaintEir_TakeOffCategory");

                entity.HasComment("請假單類別");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("類別編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Is_ThreeDayOnly).HasComment("控管請假單須在請假後3日內補送假單");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("類別名稱");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_TakeOffSchedule>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.OffDay });

                entity.ToTable("SaintEir_TakeOffSchedule");

                entity.HasComment("排休表");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasComment("使用者編號");

                entity.Property(e => e.OffDay)
                    .HasColumnType("datetime")
                    .HasComment("日期");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TakeOffTypeName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("假別名稱");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkingDayTypeId).HasComment("班別Id");

                entity.Property(e => e.YM)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("年月");
            });

            modelBuilder.Entity<SaintEir_TakeOffType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_TakeOffType");

                entity.HasComment("假別資料");

                entity.Property(e => e.CategoryId).HasComment("請假類別");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DebitSalaryPercentage).HasComment("請假是否扣款");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_Agent)
                    .HasDefaultValueSql("((1))")
                    .HasComment("必需設定代理人");

                entity.Property(e => e.Is_DeductSeniority).HasComment("不計入年資");

                entity.Property(e => e.Is_NoUse).HasComment("暫停使用, 新增請假單時不可選用.");

                entity.Property(e => e.Is_UpdateClockRecord).HasComment("是否依請假時間更新刷卡記錄");

                entity.Property(e => e.MaxMiunte).HasComment("每次請假最長時間");

                entity.Property(e => e.MaxtimesPerMonth).HasComment("每月最多次數");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名稱");

                entity.Property(e => e.NoAttendanceBonusAfterTimes).HasComment("第 N 次起扣全勤獎金");

                entity.Property(e => e.UnitMinute).HasComment("計假單位(分鐘)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.p_AdditionalLeaveType).HasComment("扣假別");
            });

            modelBuilder.Entity<SaintEir_TakeOfficeApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_TakeOfficeApplication");

                entity.HasComment("到職申請單");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("datetime")
                    .HasComment("日期");

                entity.Property(e => e.AttendanceBonus).HasComment("全勤獎金(月) 金額");

                entity.Property(e => e.BasicSalary).HasComment("本薪金額");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(20)
                    .HasComment("隸屬公司");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasComment("隸屬部門");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .HasComment("隸屬部門名稱");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("單號");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasComment("生效日期");

                entity.Property(e => e.EmployeeTypeId).HasComment("員工類型");

                entity.Property(e => e.EnglishJobTitle)
                    .HasMaxLength(50)
                    .HasComment("英文職稱");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_AttendanceBonus).HasComment("全勤獎金(月)");

                entity.Property(e => e.Is_MealAllowance).HasComment("伙食津貼");

                entity.Property(e => e.Is_OverTimePay).HasComment("加班費用");

                entity.Property(e => e.Is_PaySalary).HasComment("發放薪資");

                entity.Property(e => e.Is_Welfare).HasComment("代扣福利費");

                entity.Property(e => e.JobLevelId).HasComment("職級編號");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .HasComment("中文職稱");

                entity.Property(e => e.JobTitleId).HasComment("職等編號");

                entity.Property(e => e.LastEmployerContribution).HasComment("期前雇主提繳金額");

                entity.Property(e => e.LastWorkerContribution).HasComment("期前勞工提繳金額");

                entity.Property(e => e.MealAllowance).HasComment("伙食津貼金額");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.OverTimePayId).HasComment("加班類別");

                entity.Property(e => e.RoleId).HasComment("隸屬群組");

                entity.Property(e => e.SalaryBranchNo).HasMaxLength(20);

                entity.Property(e => e.SalaryDepartmentId).HasComment("薪資隸屬部門");

                entity.Property(e => e.SalaryDepartmentName)
                    .HasMaxLength(50)
                    .HasComment("薪資隸屬部門名稱");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("固定稅率");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("到職人員編號(FK:PRO2E_AUTH_LOGIN_USER.UserId)");

                entity.Property(e => e.WelfareRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("代扣福利費費率");

                entity.Property(e => e.p_ArriveType).HasComment("異動性質");

                entity.Property(e => e.p_HourPayBase).HasComment("時薪計算標準");

                entity.Property(e => e.p_SalaryCaculateMethod).HasComment("計薪方式");

                entity.Property(e => e.p_SalaryPayMethod).HasComment("薪資發放");

                entity.Property(e => e.p_SalarySubject).HasComment("薪資科目");

                entity.Property(e => e.p_TaxType).HasComment("課稅方式");
            });

            modelBuilder.Entity<SaintEir_TakeOfficeApplication_SalaryItem>(entity =>
            {
                entity.HasKey(e => new { e.ApplicationId, e.ItemId });

                entity.ToTable("SaintEir_TakeOfficeApplication_SalaryItem");

                entity.HasComment("到職申請單的薪資項目");

                entity.Property(e => e.ApplicationId).HasComment("申請單Id");

                entity.Property(e => e.ItemId).HasComment("薪項目 Id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("發放結束日期");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("發放開始日期");

                entity.Property(e => e.Value).HasComment("金額");
            });

            modelBuilder.Entity<SaintEir_TakeOfficeTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_TakeOfficeTemplate");

                entity.HasComment("到職申請單範本");

                entity.Property(e => e.AttendanceBonus).HasComment("全勤獎金(月) 金額");

                entity.Property(e => e.BasicSalary).HasComment("本薪金額");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_AttendanceBonus).HasComment("全勤獎金(月)");

                entity.Property(e => e.Is_MealAllowance).HasComment("伙食津貼");

                entity.Property(e => e.Is_OverTimePay).HasComment("加班費用");

                entity.Property(e => e.Is_PaySalary).HasComment("發放薪資");

                entity.Property(e => e.Is_Welfare).HasComment("代扣福利費");

                entity.Property(e => e.LastEmployerContribution).HasComment("期前雇主提繳金額");

                entity.Property(e => e.LastWorkerContribution).HasComment("期前勞工提繳金額");

                entity.Property(e => e.MealAllowance).HasComment("伙食津貼金額");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.OverTimePayId).HasComment("加班類別");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("固定稅率");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WelfareRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("代扣福利費費率");

                entity.Property(e => e.p_SalaryCaculateMethod).HasComment("計薪方式");

                entity.Property(e => e.p_SalaryPayMethod).HasComment("薪資發放");

                entity.Property(e => e.p_TaxType).HasComment("課稅方式");
            });

            modelBuilder.Entity<SaintEir_TaxAgreement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_TaxAgreement");

                entity.HasComment("所得租稅協定");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("編號");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EngName)
                    .HasMaxLength(128)
                    .HasComment("英文名稱");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasComment("名稱");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_TeamReward>(entity =>
            {
                entity.HasKey(e => e.TeamRewardNo)
                    .HasName("PK__SaintEir_TeamRew__34B3CB38");

                entity.ToTable("SaintEir_TeamReward");

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RangeEnd).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RangeStart).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RewardMoney).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RewardPercentage).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_TempDatum>(entity =>
            {
                entity.HasKey(e => e.TempDataNo);

                entity.Property(e => e.Expiration).HasColumnType("datetime");

                entity.Property(e => e.Extra1).IsUnicode(false);

                entity.Property(e => e.Extra2).IsUnicode(false);

                entity.Property(e => e.Extra3).IsUnicode(false);

                entity.Property(e => e.SessionId).HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_TransferMemberHistory>(entity =>
            {
                entity.HasKey(e => e.TransferMemberHistoryNo)
                    .HasName("PK__SaintEir__C2CFE769C7A8EB90");

                entity.ToTable("SaintEir_TransferMemberHistory");

                entity.Property(e => e.TransferFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TransferTime).HasColumnType("datetime");

                entity.Property(e => e.TransferTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SaintEir_User_Calendar>(entity =>
            {
                entity.HasKey(e => new { e.Year, e.UserId });

                entity.ToTable("SaintEir_User_Calendar");

                entity.HasComment("員工出勤曆");

                entity.Property(e => e.Year).HasComment("年份");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasComment("使用者編號");

                entity.Property(e => e.CalendarId).HasComment("日曆編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_User_SalaryItem>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ItemId });

                entity.ToTable("SaintEir_User_SalaryItem");

                entity.HasComment("員工的薪資項目");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasComment("使用者 Id");

                entity.Property(e => e.ItemId).HasComment("薪資項目的 Id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("發放結束日期");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("發放開始日期");

                entity.Property(e => e.Value).HasComment("金額");
            });

            modelBuilder.Entity<SaintEir_ValuableCoupon>(entity =>
            {
                entity.HasKey(e => e.ValuableCouponNo);

                entity.ToTable("SaintEir_ValuableCoupon");

                entity.Property(e => e.Comment).HasMaxLength(30);

                entity.Property(e => e.CouponWorth).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.NoteNo).HasMaxLength(30);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_Withhold>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_Withhold");

                entity.HasComment("代扣款設定");

                entity.Property(e => e.Amount).HasComment("金額");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndYM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("結束年月");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("品項名稱");

                entity.Property(e => e.StartYM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("開始年月");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("員編");
            });

            modelBuilder.Entity<SaintEir_WorkSheet>(entity =>
            {
                entity.HasKey(e => e.WorkSheetNo)
                    .HasName("PK_SaintEir_Test");

                entity.ToTable("SaintEir_WorkSheet");

                entity.Property(e => e.Agent).HasMaxLength(255);

                entity.Property(e => e.EventEnd).HasColumnType("datetime");

                entity.Property(e => e.EventEndTime).HasMaxLength(50);

                entity.Property(e => e.EventStart).HasColumnType("datetime");

                entity.Property(e => e.EventStartTime).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_WorkingCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_WorkingCalendar");

                entity.HasComment("出勤曆");

                entity.Property(e => e.CalendarId).HasComment("預設行事曆編號");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("出勤曆編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("出勤曆名稱");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkingDayType0).HasComment("星期日的班別");

                entity.Property(e => e.WorkingDayType1).HasComment("星期一的班別");

                entity.Property(e => e.WorkingDayType2).HasComment("星期二的班別");

                entity.Property(e => e.WorkingDayType3).HasComment("星期三的班別");

                entity.Property(e => e.WorkingDayType4).HasComment("星期四的班別");

                entity.Property(e => e.WorkingDayType5).HasComment("星期五的班別");

                entity.Property(e => e.WorkingDayType6).HasComment("星期六的班別");
            });

            modelBuilder.Entity<SaintEir_WorkingCalendarDay>(entity =>
            {
                entity.HasKey(e => new { e.CalendarId, e.Day });

                entity.ToTable("SaintEir_WorkingCalendarDay");

                entity.HasComment("出勤曆明細");

                entity.Property(e => e.CalendarId).HasComment("日曆編號");

                entity.Property(e => e.Day)
                    .HasColumnType("date")
                    .HasComment("日期");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HolidayName)
                    .HasMaxLength(128)
                    .HasComment("假日名稱");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_Off).HasComment("放假日(1)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WeekDay).HasComment("星期幾(0=sunday)");

                entity.Property(e => e.WorkingDayTypeId).HasComment("班別編號");
            });

            modelBuilder.Entity<SaintEir_WorkingDayType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_WorkingDayType");

                entity.HasComment("班別資料");

                entity.Property(e => e.BreakEnd)
                    .HasMaxLength(50)
                    .HasComment("休息結束時間");

                entity.Property(e => e.BreakStart)
                    .HasMaxLength(50)
                    .HasComment("休息開始時間");

                entity.Property(e => e.BufferMinutes).HasComment("彈性緩衝時間");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("班別編號");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EarlyQuitMinutesAllowed)
                    .HasMaxLength(50)
                    .HasComment("早退超過幾分鐘要請假");

                entity.Property(e => e.En_OverMaxHourOP).HasComment("超過時的作法.");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("下班時間");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_SPA).HasComment("是否為 SPA 用班別");

                entity.Property(e => e.LateMinutesAllowed).HasComment("遲到超過幾分鐘要請假");

                entity.Property(e => e.MaxHour).HasComment("當日上班時數限制");

                entity.Property(e => e.Memo).HasComment("備註");

                entity.Property(e => e.MinOverTimeMinutes).HasComment("加班超過分鐘才算加班");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("班別名稱");

                entity.Property(e => e.OverTimeAEndHours).HasComment("加班時段A(小時內)");

                entity.Property(e => e.OverTimeAllowance).HasComment("當天上班超過小時之後有特定津貼");

                entity.Property(e => e.OverTimeBEndHours).HasComment("加班時段B(小時內)");

                entity.Property(e => e.OverTimeHoursBeforeAllowance).HasComment("每日班別津貼");

                entity.Property(e => e.OverTimeStart)
                    .HasMaxLength(50)
                    .HasComment("開始計算加班時間");

                entity.Property(e => e.OverTimeUnitMinutes).HasComment("加班時數計算單位");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("上班時間");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_WorkingTime>(entity =>
            {
                entity.HasKey(e => e.WorkingTimeNo)
                    .HasName("PK__SaintEir_Working__7FB5F314");

                entity.ToTable("SaintEir_WorkingTime");

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.BelongToLoginUserId).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InWeekDays).HasMaxLength(500);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaintEir_flCoworker>(entity =>
            {
                entity.HasKey(e => new { e.DocId, e.UserId })
                    .HasName("PK_SaintEir_flCoWorker");

                entity.ToTable("SaintEir_flCoworker");

                entity.HasComment("協辦人員清單");

                entity.Property(e => e.DocId).HasComment("文件編號");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasComment("協辦人員員編");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_flCoworkerMemo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flCoworkerMemo");

                entity.HasComment("協辦人員意見");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasComment("留言人");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocId).HasComment("文件編號");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Memo).HasComment("意見");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SaintEir_flDocDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("文件建立日期");

                entity.Property(e => e.CreatorDepartmentId).HasComment("建立人部門編號");

                entity.Property(e => e.CreatorDepartmentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("建立人部門名稱");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("建立人編號");

                entity.Property(e => e.CreatorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("建立人姓名");

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifierDepartmentId).HasComment("修改人部門編號");

                entity.Property(e => e.ModifierDepartmentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人部門名稱");

                entity.Property(e => e.ModifierId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("修改人編號");

                entity.Property(e => e.ModifierName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改人姓名");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("文件修改日期");
            });

            modelBuilder.Entity<SaintEir_flDocField>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flDocField");

                entity.Property(e => e.En_DataType)
                    .HasDefaultValueSql("((100))")
                    .HasComment("int");

                entity.Property(e => e.En_Type).HasDefaultValueSql("((100))");

                entity.Property(e => e.Heigh).HasDefaultValueSql("((30))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_Deleted)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.Is_Enable)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);

                entity.Property(e => e.ParameterType_Id).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParameterType_Name).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SaintEir_flDocFieldDataType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flDocFieldDataType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_flDocFieldType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flDocFieldType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SaintEir_flDocNo>(entity =>
            {
                entity.HasKey(e => new { e.DocTypeId, e.IssueDate })
                    .HasName("PK_SaintEir_DocNo");

                entity.ToTable("SaintEir_flDocNo");

                entity.HasComment("文件編號控制表");

                entity.Property(e => e.DocTypeId).HasComment("文件類別編號");

                entity.Property(e => e.IssueDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("發放日期");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Seq).HasComment("發放日流水號");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.SaintEir_flDocNos)
                    .HasForeignKey(d => d.DocTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaintEir_flDocNo_SaintEir_flDocType");
            });

            modelBuilder.Entity<SaintEir_flDocNoControl>(entity =>
            {
                entity.HasKey(e => e.DocNo);

                entity.ToTable("SaintEir_flDocNoControl");

                entity.Property(e => e.DocNo).HasMaxLength(128);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SaintEir_flDocRow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flDocRow");

                entity.Property(e => e.En_RowType)
                    .HasDefaultValueSql("((100))")
                    .HasComment("橫列類型$單欄位=100,雙欄位=200,三欄單行=310,三欄位雙行=320,四欄位雙行=400");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_Deleted)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.Seq).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SaintEir_flDocType>(entity =>
            {
                entity.ToTable("SaintEir_flDocType");

                entity.HasComment("文件類別");

                entity.Property(e => e.Id).HasComment("類別編號");

                entity.Property(e => e.FirstNodeId).HasComment("流程起點, FK: SaintEir_flNode.Id");

                entity.Property(e => e.Is_Design).HasComment("是否為設計表單");

                entity.Property(e => e.Is_Flow).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("類別名稱");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("文件編號前綴字");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("資料存放表單");

                entity.Property(e => e.TitleFieldId).HasComment("作為列表頁標題的欄位");
            });

            modelBuilder.Entity<SaintEir_flDocTypeVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flDocTypeVersion");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SaintEir_flDocument>(entity =>
            {
                entity.HasKey(e => new { e.DocTypeId, e.DocId })
                    .HasName("PK_SaintEir_flDocument_1");

                entity.ToTable("SaintEir_flDocument");

                entity.HasComment("流程中的文件");

                entity.HasIndex(e => new { e.DocNoControlId, e.DocNo }, "IX_SaintEir_flDocument_DocNoControlId (ASC), DocNo (ASC)")
                    .IsUnique();

                entity.Property(e => e.DocTypeId).HasComment("文件的類別, FK: SaintEir_flDocType.Id");

                entity.Property(e => e.DocId).HasComment("文件編號");

                entity.Property(e => e.Applicant)
                    .HasMaxLength(50)
                    .HasComment("申請人(被審核者)姓名");

                entity.Property(e => e.ApplicantDepartmentId).HasComment("申請人(被審核者)部門編號");

                entity.Property(e => e.ApplicantDepartmentName)
                    .HasMaxLength(50)
                    .HasComment("申請人(被審核者)部門名稱");

                entity.Property(e => e.ApplicantId)
                    .HasMaxLength(255)
                    .HasComment("申請人(被審核者)編號");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("datetime")
                    .HasComment("核可日期");

                entity.Property(e => e.ApproverDepartmentId).HasComment("核可人部門編號");

                entity.Property(e => e.ApproverDepartmentName)
                    .HasMaxLength(50)
                    .HasComment("核可人部門名稱");

                entity.Property(e => e.ApproverId)
                    .HasMaxLength(255)
                    .HasComment("核可人編號");

                entity.Property(e => e.ApproverName)
                    .HasMaxLength(50)
                    .HasComment("核可人姓名");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("文件建立日期");

                entity.Property(e => e.CreatorDepartmentId).HasComment("建立人部門編號");

                entity.Property(e => e.CreatorDepartmentName)
                    .HasMaxLength(50)
                    .HasComment("建立人部門名稱");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(255)
                    .HasComment("建立人編號");

                entity.Property(e => e.CreatorName)
                    .HasMaxLength(50)
                    .HasComment("建立人姓名");

                entity.Property(e => e.CurrentValidatorJson).HasComment("目前應審核這份文件的人員或群組(Json 格式)");

                entity.Property(e => e.CurrentVerifierId)
                    .HasMaxLength(255)
                    .HasComment("目前的審核人員.");

                entity.Property(e => e.DepartmentId).HasComment("原屬部門編號");

                entity.Property(e => e.Description).HasComment("說明");

                entity.Property(e => e.DocDate)
                    .HasMaxLength(50)
                    .HasComment("文件日期");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(128)
                    .HasComment("文件編號");

                entity.Property(e => e.EN_Status).HasComment("狀態$取消 = -1, 退回 = -2, 審核中 = 1, 已核可= 2");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastDepartmentId).HasComment("上一關部門");

                entity.Property(e => e.LastDepartmentName)
                    .HasMaxLength(50)
                    .HasComment("上一關部門名稱");

                entity.Property(e => e.LastVerificationDate)
                    .HasColumnType("datetime")
                    .HasComment("上一關審核日期");

                entity.Property(e => e.LastVerifiedLevel).HasComment("目前最後已審核的部門");

                entity.Property(e => e.LastVerifierId)
                    .HasMaxLength(255)
                    .HasComment("上一關編號");

                entity.Property(e => e.LastVerifierName)
                    .HasMaxLength(50)
                    .HasComment("上一關名稱");

                entity.Property(e => e.Memo).HasComment("簽核意見");

                entity.Property(e => e.StartVerificationDate)
                    .HasColumnType("datetime")
                    .HasComment("開始審核日期");

                entity.Property(e => e.VerificationId).HasComment("目前核關卡編號");

                entity.Property(e => e.VerifyLevel).HasComment("建立文章時設定的應審核最高部門");
            });

            modelBuilder.Entity<SaintEir_flDocumentToken>(entity =>
            {
                entity.HasKey(e => new { e.DocId, e.Token });

                entity.ToTable("SaintEir_flDocumentToken");

                entity.HasComment("文件審核自動登入的 Token");

                entity.Property(e => e.Token).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_flDocument_CurrentSubNode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flDocument_CurrentSubNode");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedUserId).HasMaxLength(256);

                entity.Property(e => e.DepartmentId).HasComment("應審核的最高部門.");

                entity.Property(e => e.GroupList).HasMaxLength(256);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_Deleted)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.Is_DirectSupervisor).HasComment("是否為建立者的第一階直屬主管");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.SupervisorLevel).HasComment("審核層級(部門代碼長度)");

                entity.Property(e => e.UserList).HasMaxLength(256);
            });

            modelBuilder.Entity<SaintEir_flDocument_CurrentSubNode_Role>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flDocument_CurrentSubNode_Role");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SaintEir_flDocument_CurrentSubNode_User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flDocument_CurrentSubNode_User");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UserId).HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_flDocument_CurrentVerifier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flDocument_CurrentVerifier");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.VerifierId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SaintEir_flLog>(entity =>
            {
                entity.HasKey(e => new { e.DocumentId, e.Id });

                entity.ToTable("SaintEir_flLog");

                entity.HasComment("流程記錄");

                entity.Property(e => e.DocumentId).HasComment("文件編號, FK: SaintEir_flDocument.Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .HasComment("回意或退回");

                entity.Property(e => e.DocContent).HasComment("審核時的文件內容");

                entity.Property(e => e.EN_Type).HasComment("流程類別, 審核 = 1, 判斷 = 2");

                entity.Property(e => e.FlowId).HasComment("流程編號(在同一份文件中維一)");

                entity.Property(e => e.HappenDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("發生日期");

                entity.Property(e => e.Is_OK).HasComment("判斷式是否為 True");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasComment("備註");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("流程節點名稱");

                entity.Property(e => e.NodeId).HasComment("流程節點編號, FK: SaintEir_flNode.Id");

                entity.Property(e => e.SystemMemo).HasComment("系統備註");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasComment("核可者");

                entity.Property(e => e.VerifierName)
                    .HasMaxLength(50)
                    .HasComment("審核人姓名");
            });

            modelBuilder.Entity<SaintEir_flNode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flNode");

                entity.HasComment("流程節點");

                entity.Property(e => e.BatchKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("批次更新編號, 追?用");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocTypeId).HasComment("文件類別編號");

                entity.Property(e => e.En_Type).HasComment("類別: 審核=1, 判斷=2");

                entity.Property(e => e.Equation).HasComment("判斷方程式");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.FlowId).HasComment("流程編號");

                entity.Property(e => e.GroupList).HasComment("審核群組清單");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_DirectSupervisor).HasComment("直屬卜主管審核");

                entity.Property(e => e.Is_SupervisorOnly).HasComment("上階主管審核");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("節點名稱");

                entity.Property(e => e.NextId).HasComment("審核後下一關卡編號");

                entity.Property(e => e.NextNId).HasComment("判斷為 N 時, 下一關卡編號");

                entity.Property(e => e.NextYId).HasComment("判斷為 Y 時, 下一關卡編號");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserList).HasComment("審核同仁清單");
            });

            modelBuilder.Entity<SaintEir_flNode_Role>(entity =>
            {
                entity.HasKey(e => new { e.NodeId, e.RoleId });

                entity.ToTable("SaintEir_flNode_Role");

                entity.HasComment("審核群組");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SaintEir_flNode_User>(entity =>
            {
                entity.HasKey(e => new { e.NodeId, e.UserId });

                entity.ToTable("SaintEir_flNode_User");

                entity.HasComment("審核人");

                entity.Property(e => e.UserId).HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SaintEir_flRoleAuthority>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flRoleAuthority");

                entity.HasComment("文件的群組授權");

                entity.Property(e => e.DocTypeId).HasComment("文件類別");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_ReadAll).HasComment("可讀取所有文件");

                entity.Property(e => e.Is_ReadDepartment).HasComment("可讀取部門文件");

                entity.Property(e => e.Is_ReadSelf).HasComment("可讀取個人文件");

                entity.Property(e => e.Is_UpdateAll).HasComment("可修改所有文件");

                entity.Property(e => e.Is_UpdateDepartment).HasComment("可修改部門文件");

                entity.Property(e => e.Is_UpdateSelf).HasComment("可更新個人文件");

                entity.Property(e => e.RoleId).HasComment("群組名稱");
            });

            modelBuilder.Entity<SaintEir_flSkipedDocument>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.DocumentId });

                entity.ToTable("SaintEir_flSkipedDocument");

                entity.Property(e => e.UserId).HasMaxLength(255);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SaintEir_flUserAuthority>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaintEir_flUserAuthority");

                entity.HasComment("文件的員工授權");

                entity.Property(e => e.DocTypeId).HasComment("文件類別");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Is_ReadAll).HasComment("可讀取所有文件");

                entity.Property(e => e.Is_ReadDepartment).HasComment("可讀取部門文件");

                entity.Property(e => e.Is_ReadSelf).HasComment("可讀取個人文件");

                entity.Property(e => e.Is_UpdateAll).HasComment("可修改所有文件");

                entity.Property(e => e.Is_UpdateDepartment).HasComment("可修改部門文件");

                entity.Property(e => e.Is_UpdateSelf).HasComment("可修改個人文件");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("使用者編號");
            });

            modelBuilder.Entity<Tmp_SaintEir_DRService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp_SaintEir_DRService");

                entity.Property(e => e.BelongToBranch).HasMaxLength(255);

                entity.Property(e => e.BelongToLoginUser).HasMaxLength(255);

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DRServiceNo).ValueGeneratedOnAdd();

                entity.Property(e => e.Expression).HasMaxLength(255);

                entity.Property(e => e.OffDutyTime).HasColumnType("datetime");

                entity.Property(e => e.OffDutyTimeUpdatedBy).HasMaxLength(255);

                entity.Property(e => e.OnDutyTime).HasColumnType("datetime");

                entity.Property(e => e.OnDutyTimeUpdatedBy).HasMaxLength(255);

                entity.Property(e => e.ReviseOffDutyTime).HasColumnType("datetime");

                entity.Property(e => e.ReviseOffDutyTimeUpdatedBy).HasMaxLength(255);

                entity.Property(e => e.ReviseOnDutyTime).HasColumnType("datetime");

                entity.Property(e => e.ReviseOnDutyTimeUpdatedBy).HasMaxLength(255);

                entity.Property(e => e.ServiceCount).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceFee).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.TotalServiceFee).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.WorkTime).HasColumnType("decimal(9, 1)");
            });

            modelBuilder.Entity<UserStatusLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserStatusLog");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_PRO2E_AUTH_LOGIN_USER>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PRO2E_AUTH_LOGIN_USER");

                entity.Property(e => e.ArrivedDate).HasColumnType("datetime");

                entity.Property(e => e.ArrivedDateForPrint).HasColumnType("datetime");

                entity.Property(e => e.AssignBranchName).HasMaxLength(500);

                entity.Property(e => e.AssignBranchNo).HasMaxLength(20);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Blood).HasMaxLength(10);

                entity.Property(e => e.CardNo).HasMaxLength(50);

                entity.Property(e => e.ContactAddress).HasMaxLength(500);

                entity.Property(e => e.ContactZipCode).HasMaxLength(10);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.DeputyId).HasMaxLength(255);

                entity.Property(e => e.DisplayOrder).HasMaxLength(50);

                entity.Property(e => e.EducationDepartment).HasMaxLength(50);

                entity.Property(e => e.EducationDepartment2).HasMaxLength(50);

                entity.Property(e => e.EducationEnd).HasMaxLength(20);

                entity.Property(e => e.EducationEnd2).HasMaxLength(20);

                entity.Property(e => e.EducationSchool2).HasMaxLength(50);

                entity.Property(e => e.EducationStart).HasMaxLength(20);

                entity.Property(e => e.EducationStart2).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmergencyAddress).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactPerson).HasMaxLength(50);

                entity.Property(e => e.EmergencyPhone).HasMaxLength(50);

                entity.Property(e => e.EmergencyRelationship).HasMaxLength(50);

                entity.Property(e => e.EmployeeStatusName).HasMaxLength(50);

                entity.Property(e => e.EmployeeTypeName).HasMaxLength(50);

                entity.Property(e => e.EnglishJobTitle).HasMaxLength(50);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.ExperienceCompany1).HasMaxLength(50);

                entity.Property(e => e.ExperienceCompany2).HasMaxLength(50);

                entity.Property(e => e.ExperienceCompany3).HasMaxLength(50);

                entity.Property(e => e.ExperienceContent1).HasMaxLength(128);

                entity.Property(e => e.ExperienceContent2).HasMaxLength(128);

                entity.Property(e => e.ExperienceContent3).HasMaxLength(128);

                entity.Property(e => e.ExperienceEnd1).HasMaxLength(20);

                entity.Property(e => e.ExperienceEnd2).HasMaxLength(20);

                entity.Property(e => e.ExperienceEnd3).HasMaxLength(20);

                entity.Property(e => e.ExperienceStart1).HasMaxLength(20);

                entity.Property(e => e.ExperienceStart2).HasMaxLength(20);

                entity.Property(e => e.ExperienceStart3).HasMaxLength(20);

                entity.Property(e => e.ExperienceTitle1).HasMaxLength(50);

                entity.Property(e => e.ExperienceTitle2).HasMaxLength(50);

                entity.Property(e => e.ExperienceTitle3).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.FullNameInEnglish).HasMaxLength(50);

                entity.Property(e => e.HCNo).HasMaxLength(50);

                entity.Property(e => e.HCNoWithholding).HasMaxLength(50);

                entity.Property(e => e.HCSpecialIdentity).HasMaxLength(50);

                entity.Property(e => e.HealthCheckupDate).HasColumnType("datetime");

                entity.Property(e => e.HourPayBase).HasMaxLength(50);

                entity.Property(e => e.HouseOtherPhone).HasMaxLength(20);

                entity.Property(e => e.HousePhone).HasMaxLength(20);

                entity.Property(e => e.HousePhoneAreaCode).HasMaxLength(10);

                entity.Property(e => e.InvaildDate).HasColumnType("datetime");

                entity.Property(e => e.JobLevelName).HasMaxLength(50);

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.JobTitleName).HasMaxLength(50);

                entity.Property(e => e.LINo).HasMaxLength(50);

                entity.Property(e => e.LISpecialIdentity).HasMaxLength(50);

                entity.Property(e => e.LaborRetireSpecialIdentity).HasMaxLength(50);

                entity.Property(e => e.LeaveDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveWithoutPayDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseName1).HasMaxLength(50);

                entity.Property(e => e.LicenseName2).HasMaxLength(50);

                entity.Property(e => e.LicenseName3).HasMaxLength(50);

                entity.Property(e => e.LicenseNo1).HasMaxLength(50);

                entity.Property(e => e.LicenseNo2).HasMaxLength(50);

                entity.Property(e => e.LicenseNo3).HasMaxLength(50);

                entity.Property(e => e.LoginName).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.NextAnnualLeaveAddingDate).HasColumnType("datetime");

                entity.Property(e => e.OvertimePayTypeName).HasMaxLength(50);

                entity.Property(e => e.PassportNo).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhysicianCertificate).HasMaxLength(255);

                entity.Property(e => e.PhysicianSpecialist).HasMaxLength(255);

                entity.Property(e => e.Pic).HasMaxLength(255);

                entity.Property(e => e.SSID).HasMaxLength(20);

                entity.Property(e => e.SalaryBranchName).HasMaxLength(500);

                entity.Property(e => e.SalaryBranchNo).HasMaxLength(20);

                entity.Property(e => e.SalaryCaculateMethodName).HasMaxLength(50);

                entity.Property(e => e.SalaryDepartmentName).HasMaxLength(32);

                entity.Property(e => e.SalaryPayMethodName).HasMaxLength(50);

                entity.Property(e => e.SalarySubjectName).HasMaxLength(50);

                entity.Property(e => e.School).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.Specialty).HasMaxLength(50);

                entity.Property(e => e.StandardNo).HasMaxLength(50);

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxTypeName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WelfareRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkingHourPerDay).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<V_PRO2E_AUTH_USER_IN_ROLE>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PRO2E_AUTH_USER_IN_ROLE");

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_AdditionalLeave>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_AdditionalLeave");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode).HasMaxLength(50);

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.DocNo).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.ToSalaryDate).HasColumnType("datetime");

                entity.Property(e => e.TypeName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UsedHours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_AdditionalLeaveUsageLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_AdditionalLeaveUsageLog");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocNo).HasMaxLength(128);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UsedHours).HasColumnType("decimal(18, 1)");
            });

            modelBuilder.Entity<V_SaintEir_AllUserInitialAdditionalLeave>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_AllUserInitialAdditionalLeave");

                entity.Property(e => e.DepartmentCode).HasMaxLength(50);

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_AttendanceRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_AttendanceRecord");

                entity.Property(e => e.AdjDate).HasColumnType("datetime");

                entity.Property(e => e.AdjFirst).HasColumnType("datetime");

                entity.Property(e => e.AdjLast).HasColumnType("datetime");

                entity.Property(e => e.AdjOvertimeEnd).HasColumnType("datetime");

                entity.Property(e => e.AdjOvertimeStart).HasColumnType("datetime");

                entity.Property(e => e.AdjUserId).HasMaxLength(255);

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode).HasMaxLength(50);

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.FinalFirst).HasColumnType("datetime");

                entity.Property(e => e.FinalLast).HasColumnType("datetime");

                entity.Property(e => e.FinalOvertimeEnd).HasColumnType("datetime");

                entity.Property(e => e.FinalOvertimeStart).HasColumnType("datetime");

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.ImportFirst).HasColumnType("datetime");

                entity.Property(e => e.ImportLast).HasColumnType("datetime");

                entity.Property(e => e.ImportOvertimeEnd).HasColumnType("datetime");

                entity.Property(e => e.ImportOvertimeStart).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WorkingDayEnd).HasColumnType("datetime");

                entity.Property(e => e.WorkingDayOvertimeStart).HasColumnType("datetime");

                entity.Property(e => e.WorkingDayStart).HasColumnType("datetime");

                entity.Property(e => e.WorkingDayTypeCode).HasMaxLength(50);

                entity.Property(e => e.WorkingDayTypeName).HasMaxLength(50);

                entity.Property(e => e.YMD).HasColumnType("datetime");
            });

            modelBuilder.Entity<V_SaintEir_ClockInRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_ClockInRecord");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.YMD).HasColumnType("datetime");
            });

            modelBuilder.Entity<V_SaintEir_ConsumptionConfirm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_ConsumptionConfirm");

                entity.Property(e => e.AnamnesisNo).HasMaxLength(255);

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.ByChecker).HasMaxLength(255);

                entity.Property(e => e.ByCheckerName).HasMaxLength(50);

                entity.Property(e => e.ByDr).HasMaxLength(255);

                entity.Property(e => e.ByDrName).HasMaxLength(50);

                entity.Property(e => e.ByFollowerA).HasMaxLength(255);

                entity.Property(e => e.ByFollowerAName).HasMaxLength(50);

                entity.Property(e => e.ByFollowerB).HasMaxLength(255);

                entity.Property(e => e.ByFollowerBName).HasMaxLength(50);

                entity.Property(e => e.ConsumptionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.NameInChinese).HasMaxLength(500);

                entity.Property(e => e.ProductNo).HasMaxLength(20);

                entity.Property(e => e.Signature)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_Department");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EngName).HasMaxLength(128);

                entity.Property(e => e.Is_BirthdayBonus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Is_CashSalary)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LevelCode).HasMaxLength(50);

                entity.Property(e => e.LockedYM)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.ManagerId).HasMaxLength(255);

                entity.Property(e => e.ManagerName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(32);

                entity.Property(e => e.ScheduleTypeName).HasMaxLength(50);

                entity.Property(e => e.UpDepartmentName).HasMaxLength(32);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<V_SaintEir_DocRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_DocRecord");

                entity.Property(e => e.AnamnesisNo).HasMaxLength(255);

                entity.Property(e => e.Application)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BelongToBranch)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BranchName).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DocRecord).HasMaxLength(30);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_HealthInsuranceAdj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_HealthInsuranceAdj");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DeleterId).HasMaxLength(255);

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.Dependent).HasMaxLength(128);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_InitialAdditionalLeave>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_InitialAdditionalLeave");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_JobAdjustment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_JobAdjustment");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedBy).HasMaxLength(255);

                entity.Property(e => e.ApproverName).HasMaxLength(50);

                entity.Property(e => e.AssignBranchName).HasMaxLength(500);

                entity.Property(e => e.AssignBranchNo).HasMaxLength(20);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeTypeName).HasMaxLength(50);

                entity.Property(e => e.EnglishJobTitle).HasMaxLength(50);

                entity.Property(e => e.FlowNodeName).HasMaxLength(128);

                entity.Property(e => e.JobLevelName).HasMaxLength(50);

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.JobTitleName).HasMaxLength(50);

                entity.Property(e => e.OldAssignBranchName).HasMaxLength(500);

                entity.Property(e => e.OldAssignBranchNo).HasMaxLength(20);

                entity.Property(e => e.OldDepartmentName).HasMaxLength(32);

                entity.Property(e => e.OldEmployeeTypeName).HasMaxLength(50);

                entity.Property(e => e.OldEnglishJobTitle).HasMaxLength(50);

                entity.Property(e => e.OldJobLevelName).HasMaxLength(50);

                entity.Property(e => e.OldJobTitle).HasMaxLength(50);

                entity.Property(e => e.OldJobTitleName).HasMaxLength(50);

                entity.Property(e => e.OldOverTimePayName).HasMaxLength(50);

                entity.Property(e => e.OldSalaryDepartmentName).HasMaxLength(32);

                entity.Property(e => e.OldTaxRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OldWelfareRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalLeaveWithoutPayDate).HasColumnType("datetime");

                entity.Property(e => e.OutEnd).HasColumnType("datetime");

                entity.Property(e => e.OutStart).HasColumnType("datetime");

                entity.Property(e => e.OverTimePayName).HasMaxLength(50);

                entity.Property(e => e.SalaryDepartmentName).HasMaxLength(32);

                entity.Property(e => e.SystemProcessDate).HasColumnType("datetime");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WelfareRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<V_SaintEir_JobAdjustment_SalaryItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_JobAdjustment_SalaryItem");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_LaborInsuranceAdj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_LaborInsuranceAdj");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DeleterId).HasMaxLength(255);

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_MedicalRecordValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_MedicalRecordValue");

                entity.Property(e => e.BelongToBranch).HasMaxLength(255);

                entity.Property(e => e.BranchName).HasMaxLength(500);

                entity.Property(e => e.ByDr).HasMaxLength(50);

                entity.Property(e => e.ByDrName).HasMaxLength(50);

                entity.Property(e => e.ByFollower).HasMaxLength(50);

                entity.Property(e => e.ByFollowerName).HasMaxLength(50);

                entity.Property(e => e.ByNurse).HasMaxLength(50);

                entity.Property(e => e.ByNurseName).HasMaxLength(50);

                entity.Property(e => e.ColumnId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue).HasMaxLength(255);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.GroupByName).HasMaxLength(100);

                entity.Property(e => e.ItemColumn).HasMaxLength(50);

                entity.Property(e => e.ItemRow).HasMaxLength(50);

                entity.Property(e => e.ItemValue).IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateByName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<V_SaintEir_MemberTotalAmount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_MemberTotalAmount");

                entity.Property(e => e.MemberTotalAmount).HasColumnType("decimal(38, 0)");

                entity.Property(e => e.NotPayYet).HasColumnType("decimal(38, 0)");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.ShouldPay).HasColumnType("decimal(38, 0)");

                entity.Property(e => e.TotalCredit).HasColumnType("decimal(38, 1)");

                entity.Property(e => e.refound).HasColumnType("decimal(38, 1)");
            });

            modelBuilder.Entity<V_SaintEir_OvertimeApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_OvertimeApplication");

                entity.Property(e => e.ActualAHours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.ActualBHours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.ActualCHours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActualHHours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.ActualHours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.ActualSalaryDay).HasColumnType("datetime");

                entity.Property(e => e.ActualStartDate).HasColumnType("datetime");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.CorrectDate).HasColumnType("datetime");

                entity.Property(e => e.CorrectorId).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EstimateAHours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.EstimateBHours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.EstimateCHours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.EstimateEndDate).HasColumnType("datetime");

                entity.Property(e => e.EstimateHHours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.EstimateHours).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.EstimateSalaryDay).HasColumnType("datetime");

                entity.Property(e => e.EstimateStartDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.ExtendDate).HasColumnType("datetime");

                entity.Property(e => e.FlowNodeName).HasMaxLength(128);

                entity.Property(e => e.HappenDate).HasColumnType("datetime");

                entity.Property(e => e.OvertimeCompensatoryName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WorkingDayTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_Parameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_Parameter");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TypeDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_Remaining>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_Remaining");

                entity.Property(e => e.AnamnesisNo).HasMaxLength(255);

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.ItemFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.NameInChinese).HasMaxLength(500);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<V_SaintEir_ResignApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_ResignApplication");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedBy).HasMaxLength(255);

                entity.Property(e => e.ArrivedDate).HasColumnType("datetime");

                entity.Property(e => e.AssignBranchNo).HasMaxLength(20);

                entity.Property(e => e.BranchName).HasMaxLength(500);

                entity.Property(e => e.CorrecterId).HasMaxLength(255);

                entity.Property(e => e.CorrectionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeStatusName).HasMaxLength(50);

                entity.Property(e => e.EmployeeTypeName).HasMaxLength(50);

                entity.Property(e => e.EnglishJobTitle).HasMaxLength(50);

                entity.Property(e => e.ExpectedReturnDate).HasColumnType("datetime");

                entity.Property(e => e.FinalUIDate).HasColumnType("datetime");

                entity.Property(e => e.FlowNodeName).HasMaxLength(128);

                entity.Property(e => e.JobLevelName).HasMaxLength(50);

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.JobTitleName).HasMaxLength(50);

                entity.Property(e => e.SalaryDepartmentName).HasMaxLength(32);

                entity.Property(e => e.SystemProcessDate).HasColumnType("datetime");

                entity.Property(e => e.TakeOfficeEffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_RetireInsuranceAdj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_RetireInsuranceAdj");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DeleterId).HasMaxLength(255);

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_Salary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_Salary");

                entity.Property(e => e.ACEndDate).HasColumnType("datetime");

                entity.Property(e => e.ACStartDate).HasColumnType("datetime");

                entity.Property(e => e.ArrivedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.LevelCode).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OvertimeMemo).IsRequired();

                entity.Property(e => e.SalaryDepartmentName).HasMaxLength(32);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WithholdMemo).IsRequired();

                entity.Property(e => e.WorkingHourPerDay).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.YM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<V_SaintEir_Salary_Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_Salary_Log");

                entity.Property(e => e.ACEndDate).HasColumnType("datetime");

                entity.Property(e => e.ACStartDate).HasColumnType("datetime");

                entity.Property(e => e.ArrivedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.LINo).HasMaxLength(50);

                entity.Property(e => e.LevelCode).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OvertimeMemo).IsRequired();

                entity.Property(e => e.ProcessId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SalaryDepartmentName).HasMaxLength(32);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WithholdMemo).IsRequired();

                entity.Property(e => e.WorkingHourPerDay).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.YM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<V_SaintEir_Salary_WithholdSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_Salary_WithholdSummary");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.YM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<V_SaintEir_SalesInformation_productinPackage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_SalesInformation_productinPackage");

                entity.Property(e => e.ItemFee).HasColumnType("decimal(38, 9)");

                entity.Property(e => e.SellPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SoldOutPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StatisticUnit).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.TotalUnit).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.建立日期CreateDate).HasColumnType("datetime");

                entity.Property(e => e.會員姓名).HasMaxLength(255);

                entity.Property(e => e.服務人員AttendantName).HasMaxLength(50);

                entity.Property(e => e.產品名稱).HasMaxLength(500);

                entity.Property(e => e.購買日期).HasColumnType("datetime");

                entity.Property(e => e.館別代號).HasMaxLength(20);
            });

            modelBuilder.Entity<V_SaintEir_ShiftApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_ShiftApplication");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.CurrentVerifierName).HasMaxLength(50);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FlowNodeName).HasMaxLength(128);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_ShiftApplicationDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_ShiftApplicationDetail");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NewWorkingDayTypeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NewWorkingDayTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OldWorkingDayTypeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OldWorkingDayTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.YMD).HasColumnType("datetime");
            });

            modelBuilder.Entity<V_SaintEir_TakeOffApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_TakeOffApplication");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.ArriveDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.DeductionDay).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeputyDepartmentName).HasMaxLength(32);

                entity.Property(e => e.DeputyId).HasMaxLength(255);

                entity.Property(e => e.DeputyName).HasMaxLength(50);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FlowNodeName).HasMaxLength(128);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TakeOffTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TotalDay).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.TotalHour).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_TakeOffSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_TakeOffSchedule");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OffDay).HasColumnType("datetime");

                entity.Property(e => e.TakeOffTypeName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WorkingDayTypeCode).HasMaxLength(50);

                entity.Property(e => e.YM)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_TakeOfficeApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_TakeOfficeApplication");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverName).HasMaxLength(50);

                entity.Property(e => e.BranchName).HasMaxLength(500);

                entity.Property(e => e.BranchNo).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.CurrentVerifierName).HasMaxLength(50);

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeTypeName).HasMaxLength(50);

                entity.Property(e => e.EnglishJobTitle).HasMaxLength(50);

                entity.Property(e => e.FlowNodeName).HasMaxLength(128);

                entity.Property(e => e.JobLevelName).HasMaxLength(50);

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.JobTitleName).HasMaxLength(50);

                entity.Property(e => e.RoleName).HasMaxLength(255);

                entity.Property(e => e.SalaryBranchNo).HasMaxLength(20);

                entity.Property(e => e.SalaryDepartmentName).HasMaxLength(32);

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WelfareRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<V_SaintEir_TargetCustomerPurchaseItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_TargetCustomerPurchaseItem");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AlreadyPaid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AnamnesisNo).HasMaxLength(255);

                entity.Property(e => e.AttendantName).HasMaxLength(50);

                entity.Property(e => e.BelongToBranch).HasMaxLength(20);

                entity.Property(e => e.Birthday).HasMaxLength(255);

                entity.Property(e => e.BranchName).HasMaxLength(500);

                entity.Property(e => e.BranchNo).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.GoodsExchangeCredit).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.GoodsExchangeProductWorth).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.GoodsRefundCredit).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.GoodsRefundProductWorth).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ItemFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MemberCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Mobile_1).HasMaxLength(20);

                entity.Property(e => e.NotPayYet).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PackinProductValue).HasColumnType("decimal(38, 9)");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.SellPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.Property(e => e.ShouldPay).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SoldOutPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SoldOutPrice_Temp).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<V_SaintEir_User_SalaryItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_User_SalaryItem");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_Withhold>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_Withhold");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode).HasMaxLength(50);

                entity.Property(e => e.DepartmentName).HasMaxLength(32);

                entity.Property(e => e.EndYM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartYM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_WorkingCalendarDay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_WorkingCalendarDay");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Day).HasColumnType("date");

                entity.Property(e => e.HolidayName).HasMaxLength(128);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.WorkingDayTypeCode).HasMaxLength(50);

                entity.Property(e => e.WorkingDayTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_flCoWorker>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flCoWorker");

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_flDocDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flDocData");

                entity.Property(e => e.ApproverName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorDepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatorName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.FlowNodeName).HasMaxLength(128);

                entity.Property(e => e.ModifierDepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifierId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModifierName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_flDocField>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flDocField");

                entity.Property(e => e.DataTypeName).HasMaxLength(50);

                entity.Property(e => e.DocTypeName).HasMaxLength(50);

                entity.Property(e => e.Is_Deleted)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Is_Enable)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Is_RowDeleted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_flDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flDocument");

                entity.Property(e => e.Applicant).HasMaxLength(50);

                entity.Property(e => e.ApplicantDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApplicantId).HasMaxLength(255);

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApproverId).HasMaxLength(255);

                entity.Property(e => e.ApproverName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorDepartmentName).HasMaxLength(50);

                entity.Property(e => e.CreatorId).HasMaxLength(255);

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.DocDate).HasMaxLength(50);

                entity.Property(e => e.DocNo).HasMaxLength(128);

                entity.Property(e => e.DocTypeName).HasMaxLength(50);

                entity.Property(e => e.FlowNodeName).HasMaxLength(128);

                entity.Property(e => e.LastDepartmentName).HasMaxLength(50);

                entity.Property(e => e.LastVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.LastVerifierId).HasMaxLength(255);

                entity.Property(e => e.LastVerifierName).HasMaxLength(50);

                entity.Property(e => e.StartVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_flDocument_CurrentSubNode_Role>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flDocument_CurrentSubNode_Role");

                entity.Property(e => e.GroupList).HasMaxLength(256);

                entity.Property(e => e.Is_Deleted)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NodeName).HasMaxLength(256);

                entity.Property(e => e.UserList).HasMaxLength(256);
            });

            modelBuilder.Entity<V_SaintEir_flDocument_CurrentSubNode_User>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flDocument_CurrentSubNode_User");

                entity.Property(e => e.GroupList).HasMaxLength(256);

                entity.Property(e => e.Is_Deleted)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NodeName).HasMaxLength(256);

                entity.Property(e => e.UserId).HasMaxLength(255);

                entity.Property(e => e.UserList).HasMaxLength(256);
            });

            modelBuilder.Entity<V_SaintEir_flDocument_JobAdjustment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flDocument_JobAdjustment");

                entity.Property(e => e.Applicant).HasMaxLength(50);

                entity.Property(e => e.ApplicantDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApplicantId).HasMaxLength(255);

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApproverId).HasMaxLength(255);

                entity.Property(e => e.ApproverName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorDepartmentName).HasMaxLength(50);

                entity.Property(e => e.CreatorId).HasMaxLength(255);

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.DocDate).HasMaxLength(50);

                entity.Property(e => e.DocNo).HasMaxLength(128);

                entity.Property(e => e.DocTypeName).HasMaxLength(50);

                entity.Property(e => e.LastDepartmentName).HasMaxLength(50);

                entity.Property(e => e.LastVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.LastVerifierId).HasMaxLength(255);

                entity.Property(e => e.LastVerifierName).HasMaxLength(50);

                entity.Property(e => e.StartVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_flDocument_OvertimeApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flDocument_OvertimeApplication");

                entity.Property(e => e.Applicant).HasMaxLength(50);

                entity.Property(e => e.ApplicantDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApplicantId).HasMaxLength(255);

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApproverId).HasMaxLength(255);

                entity.Property(e => e.ApproverName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorDepartmentName).HasMaxLength(50);

                entity.Property(e => e.CreatorId).HasMaxLength(255);

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.DocDate).HasMaxLength(50);

                entity.Property(e => e.DocNo).HasMaxLength(128);

                entity.Property(e => e.DocTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastDepartmentName).HasMaxLength(50);

                entity.Property(e => e.LastVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.LastVerifierId).HasMaxLength(255);

                entity.Property(e => e.LastVerifierName).HasMaxLength(50);

                entity.Property(e => e.StartVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_flDocument_ResignApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flDocument_ResignApplication");

                entity.Property(e => e.Applicant).HasMaxLength(50);

                entity.Property(e => e.ApplicantDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApplicantId).HasMaxLength(255);

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorDepartmentName).HasMaxLength(50);

                entity.Property(e => e.CreatorId).HasMaxLength(255);

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.DocNo).HasMaxLength(128);

                entity.Property(e => e.DocTypeName).HasMaxLength(50);

                entity.Property(e => e.LastDepartmentName).HasMaxLength(50);

                entity.Property(e => e.LastVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.LastVerifierId).HasMaxLength(255);

                entity.Property(e => e.LastVerifierName).HasMaxLength(50);

                entity.Property(e => e.StartVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_flDocument_ShiftApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flDocument_ShiftApplication");

                entity.Property(e => e.Applicant).HasMaxLength(50);

                entity.Property(e => e.ApplicantDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApplicantId).HasMaxLength(255);

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApproverId).HasMaxLength(255);

                entity.Property(e => e.ApproverName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorDepartmentName).HasMaxLength(50);

                entity.Property(e => e.CreatorId).HasMaxLength(255);

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.DocDate).HasMaxLength(50);

                entity.Property(e => e.DocNo).HasMaxLength(128);

                entity.Property(e => e.DocTypeName).HasMaxLength(50);

                entity.Property(e => e.LastDepartmentName).HasMaxLength(50);

                entity.Property(e => e.LastVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.LastVerifierId).HasMaxLength(255);

                entity.Property(e => e.LastVerifierName).HasMaxLength(50);

                entity.Property(e => e.StartVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_flDocument_TakeOffApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flDocument_TakeOffApplication");

                entity.Property(e => e.Applicant).HasMaxLength(50);

                entity.Property(e => e.ApplicantDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApplicantId).HasMaxLength(255);

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApproverId).HasMaxLength(255);

                entity.Property(e => e.ApproverName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorDepartmentName).HasMaxLength(50);

                entity.Property(e => e.CreatorId).HasMaxLength(255);

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.DocDate).HasMaxLength(50);

                entity.Property(e => e.DocNo).HasMaxLength(128);

                entity.Property(e => e.DocTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastDepartmentName).HasMaxLength(50);

                entity.Property(e => e.LastVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.LastVerifierId).HasMaxLength(255);

                entity.Property(e => e.LastVerifierName).HasMaxLength(50);

                entity.Property(e => e.StartVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_flDocument_TakeOfficeApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flDocument_TakeOfficeApplication");

                entity.Property(e => e.Applicant).HasMaxLength(50);

                entity.Property(e => e.ApplicantDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApplicantId).HasMaxLength(255);

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverDepartmentName).HasMaxLength(50);

                entity.Property(e => e.ApproverId).HasMaxLength(255);

                entity.Property(e => e.ApproverName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorDepartmentName).HasMaxLength(50);

                entity.Property(e => e.CreatorId).HasMaxLength(255);

                entity.Property(e => e.CreatorName).HasMaxLength(50);

                entity.Property(e => e.CurrentVerifierId).HasMaxLength(255);

                entity.Property(e => e.DocNo).HasMaxLength(128);

                entity.Property(e => e.DocTypeName).HasMaxLength(50);

                entity.Property(e => e.LastDepartmentName).HasMaxLength(50);

                entity.Property(e => e.LastVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.LastVerifierId).HasMaxLength(255);

                entity.Property(e => e.LastVerifierName).HasMaxLength(50);

                entity.Property(e => e.StartVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_flLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flLog");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HappenDate).HasColumnType("datetime");

                entity.Property(e => e.Memo).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(255);

                entity.Property(e => e.VerifierName).HasMaxLength(50);
            });

            modelBuilder.Entity<V_SaintEir_flNode_Role>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flNode_Role");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<V_SaintEir_flNode_User>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SaintEir_flNode_User");

                entity.Property(e => e.FullNameInChinese).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WhereToGetInfoOtherList>(entity =>
            {
                entity.ToTable("WhereToGetInfoOtherList");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.HasOne(d => d.BelongToMemberNavigation)
                    .WithMany(p => p.WhereToGetInfoOtherLists)
                    .HasForeignKey(d => d.BelongToMember)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WhereToGe__Belon__047151E7");
            });

            modelBuilder.Entity<doctor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.其他資料).HasMaxLength(255);

                entity.Property(e => e.名字漢拼).HasMaxLength(255);

                entity.Property(e => e.管藥證號).HasMaxLength(255);

                entity.Property(e => e.醫事人員密碼).HasMaxLength(255);

                entity.Property(e => e.醫事人員帳號).HasMaxLength(255);

                entity.Property(e => e.醫事系統信箱).HasMaxLength(255);

                entity.Property(e => e.醫字號).HasMaxLength(255);

                entity.Property(e => e.醫師名字).HasMaxLength(255);

                entity.Property(e => e.電話_手機)
                    .HasMaxLength(255)
                    .HasColumnName("電話／手機");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
