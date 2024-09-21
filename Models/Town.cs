namespace coink_api.Models;

public class Town
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? DepartmentId { get; set; }
    public Department? Department { get; set; }
}