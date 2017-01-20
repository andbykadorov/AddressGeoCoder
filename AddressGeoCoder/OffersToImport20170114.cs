namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OffersToImport20170114
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string AgentFullName { get; set; }

        [StringLength(255)]
        public string OwnerFullName { get; set; }

        [StringLength(255)]
        public string CellFull { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string EstimatedValue { get; set; }

        public DateTime? Schedule { get; set; }

        public DateTime? OriginalAppointmentDate { get; set; }

        public string SystemNotes { get; set; }

        public DateTime? LastUpdate { get; set; }

        [StringLength(255)]
        public string AgentNotes { get; set; }

        public int? Agent { get; set; }

        public int? Owner { get; set; }

        public int? Lead { get; set; }

        public int? Offer { get; set; }

        [StringLength(255)]
        public string Cell { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }

        public int? Property { get; set; }

        [StringLength(80)]
        public string AddressLine1 { get; set; }

        [StringLength(80)]
        public string AddressLine2 { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(10)]
        public string Zip { get; set; }

        public DbGeography GeoLoc { get; set; }

        [StringLength(80)]
        public string Region { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }
    }
}
