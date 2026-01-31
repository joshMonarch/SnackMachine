using SnackMachine.Application.DTOs.UserDTOs;
using SnackMachine.Domain.Entities;

namespace SnackMachine.Application.Mappers.UserMapper
{
    public static class UserToEntity
    {
        public static User ToEntity(CreateUserDto createUserDto)
        {
            return new User(
                createUserDto.Username,
                createUserDto.Email,
                createUserDto.PasswordHash
            );
        }
    }
}
