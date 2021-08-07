using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int MovieId { get; set; }
        public DateTime PurchasedDate { get; set; }
    }
}
