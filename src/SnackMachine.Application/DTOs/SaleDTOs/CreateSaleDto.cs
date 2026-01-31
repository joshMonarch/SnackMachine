using SnackMachine.Domain.Enums;

namespace SnackMachine.Application.DTOs.SaleDTOs
{
    public class CreateSaleDto
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Status Status { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
