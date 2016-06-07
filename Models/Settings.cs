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
    public sealed class Settings
    {

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [DefaultValue("EUR")]
        [MinLength(3)]
        [MaxLength(3)]
        public string BaseCurrency { get; set; }

    }
}
