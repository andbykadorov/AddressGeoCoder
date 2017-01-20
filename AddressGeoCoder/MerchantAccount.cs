namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MerchantAccount")]
    public partial class MerchantAccount
    {
        [Key]
        [Column("MerchantAccount")]
        public int MerchantAccount1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public int? MasterMerchantAccount { get; set; }

        public int Organization { get; set; }

        public int PaymentProcessor { get; set; }

        [Required]
        [StringLength(255)]
        public string AccountName { get; set; }

        public string AccountDesc { get; set; }

        [Required]
        [StringLength(80)]
        public string LoginID { get; set; }

        [Required]
        [StringLength(80)]
        public string LoginPassword { get; set; }

        [StringLength(40)]
        public string BuyPassID { get; set; }
    }
}
