namespace Cafe.BDModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ingredient")]
    public partial class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Ingredient { get; set; }

        public int? ID_Dishes { get; set; }

        [StringLength(50)]
        public string Name_ingredient { get; set; }

        [Column(TypeName = "money")]
        public decimal? Money { get; set; }

        [StringLength(10)]
        public string Quantity { get; set; }

        public virtual Dishe Dishe { get; set; }
    }
}
