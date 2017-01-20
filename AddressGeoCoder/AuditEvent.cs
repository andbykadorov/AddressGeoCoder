namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuditEvent")]
    public partial class AuditEvent
    {
        [Key]
        [Column("AuditEvent")]
        public int AuditEvent1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int? Login { get; set; }

        [StringLength(16)]
        public string IPAddr { get; set; }

        [StringLength(80)]
        public string Table_Name { get; set; }

        public int? Table_Key { get; set; }

        [StringLength(80)]
        public string AuditEventType { get; set; }

        public DateTime? AuditEventDateTime { get; set; }

        [StringLength(255)]
        public string AuditEventComment { get; set; }
    }
}
