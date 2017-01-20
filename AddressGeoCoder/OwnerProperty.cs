namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OwnerProperty")]
    public partial class OwnerProperty
    {
        [Key]
        [Column("OwnerProperty")]
        public int OwnerProperty1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int? Property { get; set; }

        public int? Owner { get; set; }

        public bool? PrimaryContact { get; set; }

        public bool? MailingAddress { get; set; }

        public bool? PrimaryAddress { get; set; }

        [StringLength(30)]
        public string Status { get; set; }

        public DateTime? StatusDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }
    }
}
