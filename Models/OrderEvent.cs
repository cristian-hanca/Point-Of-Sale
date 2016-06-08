using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    ///     Order Event Model / Table.
    /// </summary>
    public class OrderEvent : IDataModel
    {

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public long OrderId { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        [DefaultValue(OrderStatus.Created)]
        public OrderStatus Status { get; set; }

    }
}
