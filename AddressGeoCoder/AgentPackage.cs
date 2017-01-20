namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentPackage")]
    public partial class AgentPackage
    {
        [Key]
        [Column("AgentPackage")]
        public int AgentPackage1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        public int Agent { get; set; }

        public int Package { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public int? Appointment { get; set; }

        public int? Lead { get; set; }

        [StringLength(40)]
        public string BillingCycle { get; set; }

        public int? NoofPay { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BuyDate { get; set; }

        public virtual Agent Agent1 { get; set; }

        public virtual Package Package1 { get; set; }
    }
}
