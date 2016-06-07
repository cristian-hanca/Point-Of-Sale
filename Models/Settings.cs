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
    ///     Settings Model / Table.
    ///     Intended as being a Single Row!
    /// </summary>
    public class Settings
    {

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public long BaseCurrencyId { get; set; }

        [ForeignKey("BaseCurrencyId")]
        public virtual Currency BaseCurrency { get; set; }

    }
}
