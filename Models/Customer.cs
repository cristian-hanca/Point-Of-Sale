using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Models
{
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
        public string Name { get; set; }

        [DefaultValue("")]
        public string LastName { get; set; }

        [DefaultValue("")]
        public string Phone { get; set; }

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