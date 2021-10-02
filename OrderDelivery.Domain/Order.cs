﻿namespace OrderDelivery.Domain
{
    public class Order
    {
        public int Id { get; set; }

        public string SenderCity { get; set; }

        public string SenderAddress { get; set; }

        public string ReceiverCity { get; set; }

        public string ReceiverAddress{ get; set; }

        public double CargoWeight { get; set; }

        public string PickUpDate { get; set; }
    }
}
