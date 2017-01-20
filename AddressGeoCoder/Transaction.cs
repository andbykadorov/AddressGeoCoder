namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        [Key]
        [Column("Transaction")]
        public int Transaction1 { get; set; }

        public int TransactionTypeId { get; set; }

        public int? Succeeded { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreatedById { get; set; }
    }
}
