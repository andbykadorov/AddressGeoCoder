namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Note")]
    public partial class Note
    {
        [Key]
        [Column("Note")]
        public int Note1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TSLastModified { get; set; }

        [Required]
        [StringLength(80)]
        public string Table_Name { get; set; }

        public int Table_Key { get; set; }

        public DateTime? NoteDate { get; set; }

        [Column(TypeName = "text")]
        public string Notation { get; set; }

        public DateTime? Note_Taken { get; set; }

        [StringLength(255)]
        public string AttachedFile { get; set; }

        public bool? NoteStatus { get; set; }

        public int? Login { get; set; }

        public int? Role { get; set; }

        public int? Assigned { get; set; }
    }
}
