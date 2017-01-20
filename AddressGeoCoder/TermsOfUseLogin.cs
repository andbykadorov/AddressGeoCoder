namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TermsOfUseLogin")]
    public partial class TermsOfUseLogin
    {
        [Key]
        [Column("TermsOfUseLogin", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TermsOfUseLogin1 { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int? TermsOfUse { get; set; }

        public int? Login { get; set; }

        [StringLength(20)]
        public string IPAddr { get; set; }

        public DateTime? AcceptDate { get; set; }
    }
}
