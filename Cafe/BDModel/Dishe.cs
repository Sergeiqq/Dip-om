namespace Cafe.BDModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dishe")]
    public partial class Dishe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dishe()
        {
            Order_Dishes = new HashSet<Order_Dishes>();
            Ingredient = new HashSet<Ingredient>();
        }

        [Key]
        public int ID_Dishes { get; set; }

        [StringLength(50)]
        public string Name_Dishes { get; set; }

        [StringLength(10)]
        public string Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? Money { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Dishes> Order_Dishes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingredient> Ingredient { get; set; }
    }
}
