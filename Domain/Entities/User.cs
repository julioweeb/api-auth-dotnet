namespace api_auth.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public bool IsActive { get; set; } = true;
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public string Role { get; set; } = "User";
    }
}
