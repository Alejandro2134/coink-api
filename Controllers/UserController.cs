using coink_api.Data;
using coink_api.DTOs.User;
using coink_api.Mappers;
using coink_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coink_api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly ApplicationDBContext _context;

    public UserController(ILogger<UserController> logger, ApplicationDBContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpPost(Name = "CreateUser")]
    public IActionResult CreateUser([FromBody] UserDTO userDTO)
    {
        try
        {
            //Call stored procedure to check existence of geographic values
            var sql = "CALL check_existence_of_geographic_values({0}, {1}, {2})";
            _context.Database.ExecuteSqlRaw(sql, userDTO.Country, userDTO.Department, userDTO.Town);

            //Create user
            var userModel = userDTO.FromDTOtoModel();
            _context.Users.Add(userModel);
            _context.SaveChanges();
            return Created("", userDTO);
        }
        catch (Exception e)
        {
            return Problem(e.Message, null, 400);
        }
    }
}
