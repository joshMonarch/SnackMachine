using SnackMachine.Domain.Enums;

namespace SnackMachine.Application.DTOs.DeliveryDTO
{
    public class CreateDeliveryDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Status Status { get; set; }
    }
}
