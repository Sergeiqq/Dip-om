namespace Cafe.BDModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Заказ столика")]
    public partial class Заказ_столика
    {
        [Key]
        [StringLength(50)]
        public string Код_заказа_столика { get; set; }

        public int? Код_клиента { get; set; }

        public int? Код_столика { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Дата_заказа_столика { get; set; }

        public virtual Client Client { get; set; }

        public virtual Tables Tables { get; set; }
    }
}
