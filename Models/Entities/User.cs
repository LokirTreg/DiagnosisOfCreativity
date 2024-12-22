namespace Models.Entities;
public class User
{
    public int Id { get; set; }
    public int Role { get; set; }
    public string Login { get; set; } = null!;
    public string? Email { get; set; }
    public string? HashPassword { get; set; }
}
