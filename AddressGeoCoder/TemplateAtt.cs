namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TemplateAtt")]
    public partial class TemplateAtt
    {
        [Key]
        [Column("TemplateAtt")]
        public int TemplateAtt1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int? Template { get; set; }

        [StringLength(120)]
        public string FileName { get; set; }

        [StringLength(255)]
        public string FileLink { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }
    }
}
