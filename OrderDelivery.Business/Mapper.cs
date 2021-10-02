using OrderDelivery.Business.Orders.DTO;
using OrderDelivery.Domain;

namespace OrderDelivery.Business
{
    internal static class Mapper
    {
        internal static Order Map (OrderRequest orderRequest, Order order)
        {
            order.SenderCity = orderRequest.SenderCity;
            order.SenderAddress = orderRequest.SenderAddress;
            order.ReceiverCity = orderRequest.ReceiverCity;
            order.ReceiverAddress = orderRequest.ReceiverAddress;
            order.CargoWeight = orderRequest.CargoWeight;
            order.PickUpDate = orderRequest.PickUpDate;

            orderRequest.SenderCity = order.SenderCity;
            orderRequest.SenderAddress = order.SenderAddress;
            orderRequest.ReceiverCity = order.ReceiverCity;
            orderRequest.ReceiverAddress = order.ReceiverAddress;
            orderRequest.CargoWeight = order.CargoWeight;
            orderRequest.PickUpDate = order.PickUpDate;

            return order;
        }

        internal static OrderResponse Map(OrderResponse orderResponse, Order order)
        { 
            orderResponse.Id = order.Id;
            orderResponse.SenderCity = order.SenderCity;
            orderResponse.SenderAddress = order.SenderAddress;
            orderResponse.ReceiverCity = order.ReceiverCity;
            orderResponse.ReceiverAddress = order.ReceiverAddress;
            orderResponse.CargoWeight = order.CargoWeight;
            orderResponse.PickUpDate = order.PickUpDate;

            return orderResponse;
        }
    }
}
