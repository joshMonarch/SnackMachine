using SnackMachine.Application.DTOs.ProductDTOs;
using SnackMachine.Domain.Entities;

namespace SnackMachine.Application.Mappers.ProductMapper
{
    public static class ProductToEntity
    {
        public static Product ToEntity(CreateProductDto createProductDto)
        {
            return new Product(
                createProductDto.Name,
                createProductDto.Price,
                createProductDto.Stock
            );
        }
    }
}
