namespace Cafe.BDModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Order_Dishes = new HashSet<Order_Dishes>();
        }

        [Key]
        public int ID_Order { get; set; }

        public int? ID_Client { get; set; }

        [StringLength(50)]
        public string Status_Order { get; set; }

        [StringLength(50)]
        public string Number_Order { get; set; }

        public virtual Client Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Dishes> Order_Dishes { get; set; }
    }
}
