using System.Security.Principal;

namespace coink_api.Models;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? CountryId { get; set; }
    public Country? Country { get; set; }
}