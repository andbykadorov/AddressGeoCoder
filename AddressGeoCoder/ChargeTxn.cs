namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChargeTxn")]
    public partial class ChargeTxn
    {
        [Key]
        [Column("ChargeTxn")]
        public int ChargeTxn1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public int? MerchantAccount { get; set; }

        public int? Office { get; set; }

        public int? Organization { get; set; }

        [StringLength(80)]
        public string ChargeTxnType { get; set; }

        [StringLength(80)]
        public string ReferenceNoInternal { get; set; }

        [StringLength(80)]
        public string ChargeTxnID { get; set; }

        [StringLength(80)]
        public string OriginChargeTxnID { get; set; }

        public int? OriginChargeTxn { get; set; }

        public DateTime? OriginChargeTxnDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tax { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        [StringLength(80)]
        public string PatientFirstName { get; set; }

        [StringLength(80)]
        public string PatientLastName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(161)]
        public string PatientFullName { get; set; }

        [StringLength(80)]
        public string CCFirstName { get; set; }

        [StringLength(80)]
        public string CCLastName { get; set; }

        [StringLength(255)]
        public string CCFullName { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(80)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(20)]
        public string PostalCode { get; set; }

        [StringLength(80)]
        public string Country { get; set; }

        [StringLength(40)]
        public string CCType { get; set; }

        [StringLength(6)]
        public string CCIIN { get; set; }

        [StringLength(4)]
        public string CCFinalDigits { get; set; }

        [StringLength(2)]
        public string CCExpMonth { get; set; }

        [StringLength(4)]
        public string CCExpYear { get; set; }

        [StringLength(80)]
        public string ChargeTxnStatus { get; set; }

        [StringLength(40)]
        public string AuthCode { get; set; }

        [StringLength(40)]
        public string AvsCode { get; set; }

        [StringLength(80)]
        public string ErrorCode { get; set; }

        [StringLength(500)]
        public string ErrorMessage { get; set; }

        [StringLength(56)]
        public string ClientIP { get; set; }

        public string Post { get; set; }

        public string Response { get; set; }

        public bool? SwipeFlg { get; set; }

        public bool? IsSettled { get; set; }
    }
}
