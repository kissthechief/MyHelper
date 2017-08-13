namespace Dal.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LHELP.Food")]
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            Inventar = new HashSet<Inventar>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int? FoodSort_Id { get; set; }

        public int? Messurement_Id { get; set; }

        public virtual FoodSort FoodSort { get; set; }

        public virtual Messurement Messurement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventar> Inventar { get; set; }
    }
}
