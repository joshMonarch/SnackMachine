namespace SnackMachine.Domain.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string? Username { get; private set; }
        public string? Email { get; private set; }
        public string? PasswordHash { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
