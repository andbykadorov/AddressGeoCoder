namespace AddressGeoCoder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AgentSpecialty
    {
        public int Id { get; set; }

        public int Agent { get; set; }

        public int SpecialtyId { get; set; }

        public virtual Agent Agent1 { get; set; }

        public virtual Specialty Specialty { get; set; }
    }
}
