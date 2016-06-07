using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Models
{
    /// <summary>
    ///     Customer Model / Table.
    /// </summary>
    public class Customer
    {

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [MinLength(13)]
        [MaxLength(13)]
        public string Cnp { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [DefaultValue("")]
        [MaxLength(64)]
        public string LastName { get; set; }

        [DefaultValue("")]
        [MaxLength(64)]
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        protected bool Equals(Customer other)
        {
            return string.Equals(Cnp, other.Cnp);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Customer) obj);
        }

        public override int GetHashCode()
        {
            return (Cnp != null ? Cnp.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, LastName: {LastName}, Phone: {Phone}";
        }

    }
}