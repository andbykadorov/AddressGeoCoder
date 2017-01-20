namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusHistory")]
    public partial class StatusHistory
    {
        [Key]
        [Column("StatusHistory")]
        public int StatusHistory1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        [Required]
        [StringLength(80)]
        public string Table_Name { get; set; }

        public int Table_Key { get; set; }

        public DateTime? HistDate { get; set; }

        [StringLength(40)]
        public string OldStatus { get; set; }

        [StringLength(40)]
        public string NewStatus { get; set; }

        public int? Login { get; set; }

        public int? Role { get; set; }
    }
}
