namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Offer")]
    public partial class Offer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Offer()
        {
            OfferDetails = new HashSet<OfferDetail>();
            OfferFeedbacks = new HashSet<OfferFeedback>();
            OfferOutcomes = new HashSet<OfferOutcome>();
        }

        [Key]
        [Column("Offer")]
        public int Offer1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int? Lead { get; set; }

        public int? Agent { get; set; }

        [StringLength(30)]
        public string OfferType { get; set; }

        [StringLength(30)]
        public string Status { get; set; }

        public DateTime? StatusDate { get; set; }

        public DateTime? ResponseTS { get; set; }

        public int? Rating { get; set; }

        [StringLength(60)]
        public string DeclineReason { get; set; }

        public string AdditionalNote { get; set; }

        public bool? Favorite { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public bool? NoFollowUp { get; set; }

        public Guid? RequestedFeedbackGuid { get; set; }

        public virtual Agent Agent1 { get; set; }

        public virtual Lead Lead1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferDetail> OfferDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferFeedback> OfferFeedbacks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfferOutcome> OfferOutcomes { get; set; }
    }
}
