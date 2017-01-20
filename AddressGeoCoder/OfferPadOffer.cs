namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OfferPadOffer
    {
        public int Id { get; set; }

        public int? Offer { get; set; }

        public int? Agent { get; set; }

        public int? Lead { get; set; }

        public int? Owner { get; set; }

        public int? Property { get; set; }

        [StringLength(255)]
        public string Homeowner { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Cell { get; set; }

        public string DispatchNotes { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(80)]
        public string CenterPointAddressLine1 { get; set; }

        [StringLength(80)]
        public string CenterPointAddressLine2 { get; set; }

        [StringLength(40)]
        public string CenterPointCity { get; set; }

        [StringLength(2)]
        public string CenterPointState { get; set; }

        [StringLength(80)]
        public string CenterPointRegion { get; set; }

        [StringLength(10)]
        public string CenterPointZip { get; set; }

        public DbGeography CenterPointGeoLoc { get; set; }

        public double? CenterPointLatitude { get; set; }

        public double? CenterPointLongitude { get; set; }
    }
}
