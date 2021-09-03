using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class V_SaintEir_flDocument
    {
        public int Id { get; set; }
        public int DocTypeId { get; set; }
        public int DocId { get; set; }
        public int? VerificationId { get; set; }
        public int EN_Status { get; set; }
        public int DepartmentId { get; set; }
        public string Description { get; set; }
        public string TableName { get; set; }
        public string DocTypeName { get; set; }
        public string FlowNodeName { get; set; }
        public string DocNo { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? StartVerificationDate { get; set; }
        public DateTime? LastVerificationDate { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public int? CreatorDepartmentId { get; set; }
        public string CreatorDepartmentName { get; set; }
        public string Applicant { get; set; }
        public string ApplicantId { get; set; }
        public int? ApplicantDepartmentId { get; set; }
        public string ApplicantDepartmentName { get; set; }
        public string LastVerifierId { get; set; }
        public string LastVerifierName { get; set; }
        public int? LastDepartmentId { get; set; }
        public string LastDepartmentName { get; set; }
        public string CurrentVerifierId { get; set; }
        public string DocDate { get; set; }
        public string Memo { get; set; }
        public string ApproverId { get; set; }
        public string ApproverName { get; set; }
        public int? ApproverDepartmentId { get; set; }
        public string ApproverDepartmentName { get; set; }
        public int Is_CallBack { get; set; }
        public string CurrentValidatorJson { get; set; }
        public string CurrentVerifierName { get; set; }
        public int VerifyLevel { get; set; }
        public int? LastVerifiedLevel { get; set; }
        public int Is_DepartmentVerify { get; set; }
        public int Is_PassedDepartmentVerify { get; set; }
    }
}
