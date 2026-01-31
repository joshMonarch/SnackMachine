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
        private User() { }
        public User(int id, string? username, string? email, string? passwordHash, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}
