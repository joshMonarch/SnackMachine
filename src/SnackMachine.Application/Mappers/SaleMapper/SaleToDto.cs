using SnackMachine.Application.DTOs.SaleDTOs;
using SnackMachine.Domain.Entities;

namespace SnackMachine.Application.Mappers.SaleMapper
{
    public static class SaleToDto
    {
        public static ResponseSaleDto ToDto(Sale sale)
        {
            return new ResponseSaleDto
            {
                UserId = sale.UserId,
                ProductId = sale.ProductId,
                Quantity = sale.Quantity,
                Status = sale.Status,
                TotalPrice = sale.TotalPrice
            };
        }
        public static IEnumerable<ResponseSaleDto> ToDtoList(IEnumerable<Sale> sales)
        {
            return sales.Select(ToDto);
        }
    }
}
