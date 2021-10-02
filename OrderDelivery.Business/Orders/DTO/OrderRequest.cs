using System;
using System.ComponentModel.DataAnnotations;


namespace OrderDelivery.Business.Orders.DTO
{
    public class OrderRequest
    {
        [Required]
        public string SenderCity { get; set; }

        [Required]
        public string SenderAddress { get; set; }

        [Required]
        public string ReceiverCity { get; set; }

        [Required]
        public string ReceiverAddress { get; set; }

        private double _cargoWeight;

        [Required]
        public double CargoWeight
        {
            get
            {
                return _cargoWeight;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Incorrect Weight");

                _cargoWeight = value;
            }
        }

        private string _pickUpDate;
        [Required]
        public string PickUpDate
        {
            get
            {
                return _pickUpDate;
            }
            set
            {
               var dt = new DateTime();

                if (!DateTime.TryParse(value, out dt))
                    throw new ArgumentException("Incorrect Date");

                if (dt < DateTime.Now)
                    throw new ArgumentException("Incorrect Date");

                _pickUpDate = value;
            }
        }
    }
}
