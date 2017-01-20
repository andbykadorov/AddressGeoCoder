namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Property")]
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            Leads = new HashSet<Lead>();
        }

        [Key]
        [Column("Property")]
        public int Property1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        [StringLength(30)]
        public string PropertyType { get; set; }

        [StringLength(60)]
        public string PropertyName { get; set; }

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

        public decimal? SQFT { get; set; }

        public decimal? Beds { get; set; }

        public decimal? Baths { get; set; }

        public decimal? LotSize { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(216)]
        public string Combo { get; set; }

        public int? CurrentOwner { get; set; }

        [Column(TypeName = "money")]
        public decimal? EstValue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ListDate { get; set; }

        public DbGeography GeoLoc { get; set; }

        [StringLength(80)]
        public string Region { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public bool? AnyFootageAddedToHome { get; set; }

        public bool? HasKitchenImprovements { get; set; }

        public bool? HasPool { get; set; }

        public bool? HasMortgage { get; set; }

        public string SecondOwnerName { get; set; }

        public int? LivedYearsInHome { get; set; }

        public int? BuiltYear { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lead> Leads { get; set; }
    }
}
