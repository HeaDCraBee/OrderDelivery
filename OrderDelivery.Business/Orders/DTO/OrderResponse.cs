using System.ComponentModel.DataAnnotations;

namespace OrderDelivery.Business.Orders.DTO
{
    public class OrderResponse
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string SenderCity { get; set; }

        [Required]
        public string SenderAddress { get; set; }

        [Required]
        public string ReceiverCity { get; set; }

        [Required]
        public string ReceiverAddress { get; set; }

        [Required]
        public double CargoWeight { get; set; }

        [Required]
        public string PickUpDate { get; set; }
    }
}
