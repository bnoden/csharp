using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packt.CS7
{
    [Table("Suppliers")]
    public class Supplier
    {
        public int SupplierId {get;set;}
        [Required]
        [StringLength(15)]
        public string CompanyName {get;set;}
    }
}
