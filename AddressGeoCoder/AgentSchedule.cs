namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentSchedule")]
    public partial class AgentSchedule
    {
        [Key]
        [Column("AgentSchedule")]
        public int AgentSchedule1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int Agent { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SchDateStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SchDateEnd { get; set; }

        [StringLength(10)]
        public string SchDay { get; set; }

        public TimeSpan? SchTS { get; set; }

        public TimeSpan? SchTE { get; set; }

        public bool? FullDay { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public virtual Agent Agent1 { get; set; }
    }
}
