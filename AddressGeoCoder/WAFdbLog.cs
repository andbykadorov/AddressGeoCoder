namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WAFdbLog")]
    public partial class WAFdbLog
    {
        public DateTime? LoggedOn { get; set; }

        [StringLength(80)]
        public string Category { get; set; }

        [StringLength(80)]
        public string ClassName { get; set; }

        [StringLength(80)]
        public string Location { get; set; }

        public string Message { get; set; }

        public string Custom { get; set; }

        [StringLength(40)]
        public string RecordKey { get; set; }

        [StringLength(80)]
        public string Login_ID { get; set; }

        [Key]
        [Column("WAFdbLog")]
        public int WAFdbLog1 { get; set; }
    }
}
