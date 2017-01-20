namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TermsOfUse")]
    public partial class TermsOfUse
    {
        [Key]
        [Column("TermsOfUse", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TermsOfUse1 { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public string TOUText { get; set; }

        public DateTime? FinalizedDate { get; set; }

        [StringLength(50)]
        public string AppLoanType { get; set; }
    }
}
