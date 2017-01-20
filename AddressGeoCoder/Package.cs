namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Package")]
    public partial class Package
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Package()
        {
            AgentPackages = new HashSet<AgentPackage>();
        }

        [Key]
        [Column("Package")]
        public int Package1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        [StringLength(80)]
        public string PackageName { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public int? Appointment { get; set; }

        public int? Lead { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        [StringLength(40)]
        public string BillingCycle { get; set; }

        public int? NoofPay { get; set; }

        public int MaxApptPerMonth { get; set; }

        public int MaxLeadPerMonth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentPackage> AgentPackages { get; set; }
    }
}
