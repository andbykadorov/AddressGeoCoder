namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lookup_Value
    {
        [Key]
        [Column("Lookup_Value")]
        public int Lookup_Value1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int Lookup { get; set; }

        [Required]
        [StringLength(80)]
        public string Code_Value { get; set; }

        public int? Sort_Order { get; set; }

        public bool IsDefault { get; set; }

        public bool IsSystem { get; set; }

        public virtual Lookup Lookup1 { get; set; }
    }
}
