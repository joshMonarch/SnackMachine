using SnackMachine.Application.DTOs.SaleDTOs;
using SnackMachine.Domain.Entities;

namespace SnackMachine.Application.Mappers.SaleMapper
{
    public static class SaleToEntity
    {
        public static Sale ToEntity(CreateSaleDto createSaleDto)
        {
            return new Sale(
                    createSaleDto.UserId,
                    createSaleDto.ProductId,
                    createSaleDto.Quantity,
                    createSaleDto.Status,
                    createSaleDto.TotalPrice
                );
        }
    }
}
