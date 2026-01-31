using SnackMachine.Application.DTOs.DeliveryDTO;
using SnackMachine.Domain.Entities;

namespace SnackMachine.Application.Mappers.DeliveryMapper
{
    public static class DeliveryToEntity
    {
        public static Delivery ToDto (CreateDeliveryDto createDeliveryDto)
        {
            return new Delivery(
                createDeliveryDto.ProductId,
                createDeliveryDto.Quantity,
                createDeliveryDto.Status
            );
        }
    }
}
