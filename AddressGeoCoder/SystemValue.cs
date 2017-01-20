namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemValue")]
    public partial class SystemValue
    {
        [Key]
        [Column("SystemValue")]
        public int SystemValue1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        [Required]
        [StringLength(80)]
        public string ItemName { get; set; }

        [Required]
        public string ItemValue { get; set; }

        [StringLength(255)]
        public string ItemDescription { get; set; }
    }
}
