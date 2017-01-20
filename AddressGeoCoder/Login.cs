namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Login()
        {
            Agents = new HashSet<Agent>();
        }

        [Key]
        [Column("Login")]
        public int Login1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        [Required]
        [StringLength(80)]
        public string Login_ID { get; set; }

        [Required]
        [StringLength(80)]
        public string Authentication { get; set; }

        [StringLength(5)]
        public string NamePrefix { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(3)]
        public string MiddleInitial { get; set; }

        [Required]
        [StringLength(40)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string NameSuffix { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(98)]
        public string FullName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(92)]
        public string OrderedName { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public int? Role { get; set; }

        public bool? Active { get; set; }

        public bool? NotifyIniReview { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public bool? LatestTermsAccepted { get; set; }

        [StringLength(80)]
        public string SecretQ { get; set; }

        [StringLength(80)]
        public string SecretA { get; set; }

        [StringLength(80)]
        public string LastAuthentication { get; set; }

        [StringLength(80)]
        public string LastAuthentication2 { get; set; }

        public DateTime? LastPassChange { get; set; }

        public bool? Lending { get; set; }

        public bool? Acquisition { get; set; }

        public bool? Consolidate { get; set; }

        public DateTime? FirstLoginDate { get; set; }

        public string SignatureHTML { get; set; }

        public bool? NotifyFinReview { get; set; }

        public bool? NotifyDocDayAlert { get; set; }

        [StringLength(10)]
        public string AppLoanType { get; set; }

        public int? ApprovalLevel { get; set; }

        public bool? IsReadOnly { get; set; }

        [StringLength(10)]
        public string DefaultDashboard { get; set; }

        [StringLength(50)]
        public string DefaultLoanStage { get; set; }

        [StringLength(50)]
        public string DefaultApplicantStage { get; set; }

        public bool? IsOriginator { get; set; }

        public bool? TermsOfUseRequired { get; set; }

        public bool? IsUnderwriter { get; set; }

        public bool IsUploadTreeSimple { get; set; }

        public int? UserProfile { get; set; }

        [StringLength(50)]
        public string DefaultDashboardLoanStatus { get; set; }

        public bool IsServicer { get; set; }

        public bool IsAttorney { get; set; }

        public bool IsSalesRep { get; set; }

        public bool IsCloser { get; set; }

        public bool? IsLoanCoordinator { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        public bool? IsOwner { get; set; }

        public string DashboardConfiguration { get; set; }

        public bool NeedChangePassword { get; set; }

        public string ImagePath { get; set; }

        [StringLength(200)]
        public string CmaCompany { get; set; }

        public Guid? Guid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agent> Agents { get; set; }
    }
}
