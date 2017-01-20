namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentProcessor")]
    public partial class PaymentProcessor
    {
        [Key]
        [Column("PaymentProcessor")]
        public int PaymentProcessor1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public int? LastModifiedBy { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(25)]
        public string CustServicePhone { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(80)]
        public string PaymentProcessingMethod { get; set; }

        [StringLength(80)]
        public string TestLoginId { get; set; }

        [StringLength(80)]
        public string TestLoginPassword { get; set; }

        [StringLength(255)]
        public string RedirectURL { get; set; }

        [StringLength(255)]
        public string XmlURL { get; set; }

        [StringLength(255)]
        public string SoapURL { get; set; }

        [StringLength(255)]
        public string TestRedirectURL { get; set; }

        [StringLength(255)]
        public string TestXMLUrl { get; set; }

        [StringLength(255)]
        public string TestSoapURL { get; set; }

        public bool InTestMode { get; set; }
    }
}
