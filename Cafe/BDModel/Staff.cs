namespace Cafe.BDModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [Key]
        public int ID_Staff { get; set; }

        public int? ID_Post { get; set; }

        [StringLength(50)]
        public string FIO { get; set; }

        [StringLength(50)]
        public string Adress { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        public virtual Post Post { get; set; }
    }
}
