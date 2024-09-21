using coink_api.DTOs.User;
using coink_api.Models;

namespace coink_api.Mappers;

public static class UserMapper
{
    public static UserDTO FromModeltoDTO(this User userModel)
    {
        return new UserDTO
        {
            Name = userModel.Name,
            Phone = userModel.Phone,
            Country = "",
            Department = "",
            Town = "",
            Address = userModel.Address
        };
    }

    public static User FromDTOtoModel(this UserDTO userDTO)
    {
        return new User
        {
            Name = userDTO.Name,
            Phone = userDTO.Phone,
            Address = userDTO.Address
        };
    }
}