namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataHistory")]
    public partial class DataHistory
    {
        [Key]
        [Column("DataHistory")]
        public int DataHistory1 { get; set; }

        [StringLength(80)]
        public string Property { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Date { get; set; }

        public string InitialValue { get; set; }

        public string GivenValue { get; set; }

        [StringLength(128)]
        public string UserId { get; set; }

        public int? PK { get; set; }

        [Required]
        [StringLength(80)]
        public string TableName { get; set; }

        public int? DataTape { get; set; }

        [StringLength(80)]
        public string FKTable { get; set; }

        [StringLength(96)]
        public string FKPrimaryKey { get; set; }

        [StringLength(4000)]
        public string FKDisplayName { get; set; }

        [StringLength(16)]
        public string PublicIP { get; set; }

        [StringLength(16)]
        public string InternalIP { get; set; }

        [StringLength(1)]
        public string Action { get; set; }

        [StringLength(128)]
        public string ForeignTable { get; set; }
    }
}
