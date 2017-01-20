namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChargeTransaction")]
    public partial class ChargeTransaction
    {
        [Key]
        [Column("ChargeTransaction")]
        public int ChargeTransaction1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(255)]
        public string CCFullName { get; set; }

        [StringLength(4)]
        public string CCFinalDigits { get; set; }

        [StringLength(2)]
        public string CCExpMonth { get; set; }

        [StringLength(4)]
        public string CCExpYear { get; set; }

        [StringLength(40)]
        public string CCType { get; set; }

        [StringLength(40)]
        public string AuthCode { get; set; }

        [StringLength(40)]
        public string AvsResultCode { get; set; }

        [StringLength(40)]
        public string CavvResultCode { get; set; }

        [StringLength(40)]
        public string CvvResultCode { get; set; }

        [StringLength(20)]
        public string ResponseCode { get; set; }

        public int? Transaction { get; set; }

        public int? OriginTransaction { get; set; }

        [StringLength(80)]
        public string GatewayTransactionId { get; set; }

        public DateTime? TransactionDate { get; set; }

        [StringLength(56)]
        public string ClientIP { get; set; }

        [StringLength(1000)]
        public string Errors { get; set; }

        [StringLength(1000)]
        public string Messages { get; set; }

        public string TraceLog { get; set; }

        public bool IsSuccess { get; set; }

        public bool IsSettled { get; set; }
    }
}
