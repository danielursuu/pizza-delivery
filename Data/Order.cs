using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDeliveryAPI.Data
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "int")]
        public int PizzaId { get; set; }

        [Column(TypeName = "int")]
        public int DipId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateTimeDelivered { get; set; }

        [Column(TypeName = "int")]
        public int TimeToDeliver { get; set; }

        [Column(TypeName = "float")]
        public float TotalPrice { get; set; }

        [Column(TypeName = "int")]
        public int CustomerId { get; set; }
    }
}
