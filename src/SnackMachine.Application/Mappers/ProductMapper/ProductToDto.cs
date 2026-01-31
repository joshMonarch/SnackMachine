using SnackMachine.Application.DTOs.ProductDTOs;
using SnackMachine.Domain.Entities;

namespace SnackMachine.Application.Mappers.ProductMapper
{
    public static class ProductToDto
    {
        public static ResponseProductDto ToDto(Product product)
        {
            return new ResponseProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                CreatedAt = product.CreatedAt,
                UpdatedAt = product.UpdatedAt
            };
        }
        public static IEnumerable<ResponseProductDto> ToDtoList(IEnumerable<Product> products)
        {
            return products.Select(ToDto);
        }
    }
}
