namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("roleprivilege")]
    public partial class roleprivilege
    {
        [Key]
        [Column("Roleprivilege")]
        public int Roleprivilege1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int Role { get; set; }

        public int Privilege { get; set; }
    }
}
