using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Models
{
    /// <summary>
    ///     Product Model / Table.
    /// </summary>
    public sealed class Product
    {

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public long CategoryId { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }

        [DefaultValue(0)]
        public decimal Vat { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        private bool Equals(Product other)
        {
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Product) obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return $"Id: {Id}, CategotyId: {CategoryId}, Name: {Name}, Price: {Price}, Vat: {Vat}";
        }

    }
}