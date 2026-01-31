using SnackMachine.Application.DTOs.UserDTOs;
using SnackMachine.Domain.Entities;

namespace SnackMachine.Application.Mappers.UserMapper
{
    public static class UserToDto
    {
        public static ResponseUserDto ToDto(User user)
        {
            return new ResponseUserDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt
            };
        }

        public static IEnumerable<ResponseUserDto> ToDtoList(IEnumerable<User> users)
        {
            return users.Select(ToDto);
        }
    }
}
