namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lead")]
    public partial class Lead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lead()
        {
            AgentOutboundComms = new HashSet<AgentOutboundComm>();
            Offers = new HashSet<Offer>();
        }

        [Key]
        [Column("Lead")]
        public int Lead1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int? Property { get; set; }

        public int? Owner { get; set; }

        public int? LeadSource { get; set; }

        public int? LeadTier { get; set; }

        [StringLength(30)]
        public string LeadType { get; set; }

        [StringLength(30)]
        public string Status { get; set; }

        public DateTime? StatusDate { get; set; }

        public string DispatchNote { get; set; }

        [Column(TypeName = "money")]
        public decimal? LeadPrice { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        [StringLength(60)]
        public string CRMAgent { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OriginalDate { get; set; }

        public DateTime? OriginalTime { get; set; }

        public bool? Priority { get; set; }

        [StringLength(3)]
        public string IsOwnerLookingToList { get; set; }

        [StringLength(200)]
        public string MoveDestination { get; set; }

        [StringLength(50)]
        public string NeedForBiggerOrSmallerHome { get; set; }

        [StringLength(3)]
        public string IsListed { get; set; }

        [StringLength(3)]
        public string WantReviewFinancingOptions { get; set; }

        [StringLength(3)]
        public string AnyConstructionNeeds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentOutboundComm> AgentOutboundComms { get; set; }

        public virtual LeadTier LeadTier1 { get; set; }

        public virtual Owner Owner1 { get; set; }

        public virtual Property Property1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
