namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfferListCool")]
    public partial class OfferListCool
    {
        [StringLength(255)]
        public string Agent { get; set; }

        [StringLength(255)]
        public string Customer { get; set; }

        [StringLength(255)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [Column("Schedule ")]
        public DateTime? Schedule_ { get; set; }

        [Column("Original Appointment Date")]
        public DateTime? Original_Appointment_Date { get; set; }

        [Column("System Notes")]
        public string System_Notes { get; set; }

        [StringLength(255)]
        public string LastUpdate { get; set; }

        public string AgentNotes { get; set; }

        [Key]
        public bool Done { get; set; }
    }
}
