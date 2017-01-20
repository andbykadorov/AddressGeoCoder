namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OfferDetail
    {
        [Key]
        public int OfferDetails { get; set; }

        public int Offer { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40)]
        public string LastName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(81)]
        public string FullName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(82)]
        public string OrderedName { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(25)]
        public string Cell { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        [StringLength(4)]
        public string Extension { get; set; }

        [StringLength(30)]
        public string PropertyType { get; set; }

        [StringLength(80)]
        public string AddressLine1 { get; set; }

        [StringLength(80)]
        public string AddressLine2 { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [StringLength(80)]
        public string Region { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(10)]
        public string Zip { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(216)]
        public string Combo { get; set; }

        public decimal? SQFT { get; set; }

        public decimal? Beds { get; set; }

        public decimal? Baths { get; set; }

        public decimal? LotSize { get; set; }

        public int? CurrentOwner { get; set; }

        [Column(TypeName = "money")]
        public decimal? EstValue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ListDate { get; set; }

        public DbGeography GeoLoc { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        [StringLength(30)]
        public string LeadType { get; set; }

        [StringLength(30)]
        public string LeadStatus { get; set; }

        public string DispatchNote { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OriginalDate { get; set; }

        public DateTime? OriginalTime { get; set; }

        public bool? Priority { get; set; }

        [StringLength(200)]
        public string MoveDestination { get; set; }

        [StringLength(3)]
        public string IsOwnerLookingToList { get; set; }

        [StringLength(50)]
        public string NeedForBiggerOrSmallerHome { get; set; }

        [StringLength(3)]
        public string IsListed { get; set; }

        [StringLength(3)]
        public string WantReviewFinancingOptions { get; set; }

        [StringLength(3)]
        public string AnyConstructionNeeds { get; set; }

        public int? LeadTier { get; set; }

        public bool? AnyFootageAddedToHome { get; set; }

        public bool? HasKitchenImprovements { get; set; }

        public bool? HasPool { get; set; }

        public bool? HasMortgage { get; set; }

        public bool? BuiltYear { get; set; }

        public string SecondOwnerName { get; set; }

        public int? LivedYearsInHome { get; set; }

        public virtual Offer Offer1 { get; set; }
    }
}
