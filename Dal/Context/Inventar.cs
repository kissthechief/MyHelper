namespace Dal.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LHELP.Inventar")]
    public partial class Inventar
    {
        public int Id { get; set; }

        public string Guid { get; set; }

        public int Amount { get; set; }

        public int? User_Id { get; set; }

        public virtual ICollection<Food> Food { get; set; }

        public virtual User User { get; set; }
    }
}
