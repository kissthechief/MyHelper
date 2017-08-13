namespace Dal.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LHELP.User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Inventar = new HashSet<Inventar>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string EMail { get; set; }

        public DateTime? Birthday { get; set; }

        public string City { get; set; }

        public int? ZipCode { get; set; }

        public string Street { get; set; }

        public string Nickname { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventar> Inventar { get; set; }
    }
}
