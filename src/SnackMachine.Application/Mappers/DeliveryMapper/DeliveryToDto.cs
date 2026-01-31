using SnackMachine.Application.DTOs.DeliveryDTO;
using SnackMachine.Domain.Entities;

namespace SnackMachine.Application.Mappers.DeliveryMapper
{
    public static class DeliveryToDto
    {
        public static ResponseDeliveryDto ToDto(Delivery delivery)
        {
            return new ResponseDeliveryDto
            {
                Id = delivery.Id,
                ProductId = delivery.ProductId,
                Quantity = delivery.Quantity,
                Status = delivery.Status.ToString(),
                CreatedAt = delivery.CreatedAt,
                UpdatedAt = delivery.UpdatedAt
            };
        }
        public static IEnumerable<ResponseDeliveryDto> ToDtoList(IEnumerable<Delivery> delivery)
        {
            return delivery.Select(ToDto);
        }

    }
}
