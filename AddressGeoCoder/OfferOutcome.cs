namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfferOutcome")]
    public partial class OfferOutcome
    {
        [Key]
        [Column("OfferOutcome")]
        public int OfferOutcome1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int? Offer { get; set; }

        public int? Rating { get; set; }

        [StringLength(3)]
        public string DidMeetWithClient { get; set; }

        [StringLength(3)]
        public string DidPresentToClient { get; set; }

        public string KeyMotivationConcerns { get; set; }

        [StringLength(200)]
        public string NextAction { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NextFollowUpDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public virtual Offer Offer1 { get; set; }
    }
}
