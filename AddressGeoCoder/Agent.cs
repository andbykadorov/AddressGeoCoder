namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agent")]
    public partial class Agent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agent()
        {
            AgentOutboundComms = new HashSet<AgentOutboundComm>();
            AgentPackages = new HashSet<AgentPackage>();
            AgentSchedules = new HashSet<AgentSchedule>();
            AgentSpecialties = new HashSet<AgentSpecialty>();
            Offers = new HashSet<Offer>();
        }

        [Key]
        [Column("Agent")]
        public int Agent1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        [StringLength(80)]
        public string Login_ID { get; set; }

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

        [StringLength(80)]
        public string AddressLine1 { get; set; }

        [StringLength(80)]
        public string AddressLine2 { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(10)]
        public string Zip { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        [StringLength(4)]
        public string Extension { get; set; }

        [StringLength(25)]
        public string Cell { get; set; }

        public bool? Active { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(80)]
        public string JobTitle { get; set; }

        [StringLength(80)]
        public string LicenseID { get; set; }

        public bool? LicenseVerified { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VerificationDate { get; set; }

        [StringLength(2000)]
        public string AgentBio { get; set; }

        public bool? DoNotMail { get; set; }

        public bool? DoNotText { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        [StringLength(80)]
        public string Company { get; set; }

        public DbGeography GeoLoc { get; set; }

        [StringLength(80)]
        public string Region { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public bool? HasPriority { get; set; }

        public int? PriorityAppointments { get; set; }

        public bool IsBlacklisted { get; set; }

        public int? Login { get; set; }

        public bool IsOnboarded { get; set; }

        [StringLength(80)]
        public string CenterPointAddressLine1 { get; set; }

        [StringLength(80)]
        public string CenterPointAddressLine2 { get; set; }

        [StringLength(40)]
        public string CenterPointCity { get; set; }

        [StringLength(2)]
        public string CenterPointState { get; set; }

        [StringLength(80)]
        public string CenterPointRegion { get; set; }

        [StringLength(10)]
        public string CenterPointZip { get; set; }

        public DbGeography CenterPointGeoLoc { get; set; }

        public double? CenterPointLatitude { get; set; }

        public double? CenterPointLongitude { get; set; }

        public bool IsContractSigned { get; set; }

        public int? NumberOwed { get; set; }

        public virtual Login Login1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentOutboundComm> AgentOutboundComms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentPackage> AgentPackages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentSchedule> AgentSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentSpecialty> AgentSpecialties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
