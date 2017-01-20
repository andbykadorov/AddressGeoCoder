namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentOutboundComm")]
    public partial class AgentOutboundComm
    {
        [Key]
        [Column("AgentOutboundComm")]
        public int AgentOutboundComm1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int? Agent { get; set; }

        public int? Lead { get; set; }

        public DateTime? CommDate { get; set; }

        [StringLength(2000)]
        public string NotifyEmail { get; set; }

        [StringLength(2000)]
        public string NotifyCC { get; set; }

        [StringLength(2000)]
        public string NotifyBCC { get; set; }

        [StringLength(255)]
        public string NotifySubject { get; set; }

        [StringLength(500)]
        public string AttachedFileName { get; set; }

        public string NotifyMsg { get; set; }

        public bool? NotifyFailure { get; set; }

        public string FailureMsg { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public virtual Agent Agent1 { get; set; }

        public virtual Lead Lead1 { get; set; }
    }
}
