using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Models
{
    /// <summary>
    ///     Order Model / Table.
    /// </summary>
    public class Order : IDataModel
    {

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public long CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public virtual OrderType Type {
            get
            {
                int total = Items.Count();
                int negative = Items.Count(x => x.Quantity < 0);

                if (negative == 0)
                {
                    return OrderType.Normal;
                }
                if (negative == total)
                {
                   return OrderType.Return;
                }
                return OrderType.Exchange;
            }
        }

        public virtual ICollection<OrderItem> Items { get; set; }

        public long CurrencyId { get; set; }

        [ForeignKey("CurrencyId")]
        public virtual Currency Currency { get; set; }

        /// <summary>
        ///     Gets the total to be payed.
        /// </summary>
        public virtual decimal Total {
            get { return Items.Sum(x => x.Price * x.Quantity); }
        }
        
        public virtual ICollection<OrderEvent> Events { get; set; }

        public virtual OrderEvent LatestEvent {
            get { return Events.OrderByDescending(x => x.DateTime).First(); }
        }

    }
}
