namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeadScript")]
    public partial class LeadScript
    {
        [Key]
        [Column("LeadScript")]
        public int LeadScript1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int? Lead { get; set; }

        [StringLength(120)]
        public string Question { get; set; }

        [StringLength(120)]
        public string Answer { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }
    }
}
