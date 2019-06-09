using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDeliveryAPI.Data
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Ingredients { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Size { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CrustType { get; set; }

        [Column(TypeName = "int")]
        public int Quantity { get; set; }

        [Column(TypeName = "float")]
        public float Price { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Image { get; set; }
    }
}
