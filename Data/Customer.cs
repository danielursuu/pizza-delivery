using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDeliveryAPI.Data
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Adress { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "int")]
        public int OrderId { get; set; }
    }
}
