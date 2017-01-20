namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Privilege")]
    public partial class Privilege
    {
        [Key]
        [Column("Privilege")]
        public int Privilege1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        [Required]
        [StringLength(80)]
        public string Privilege_id { get; set; }

        [StringLength(255)]
        public string Privilege_description { get; set; }
    }
}
