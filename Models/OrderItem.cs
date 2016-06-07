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
    ///     Order Item Model / Table.
    /// </summary>
    public class OrderItem
    {

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public long OrderId { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        
        [Required]
        public long ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [Required]
        [DefaultValue(1)]
        public int Quantity { get; set; }

        public decimal? AlterPrice { get; set; }

        public decimal GetPrice()
        {
            return AlterPrice ?? Product.Price;
        }

    }
}
