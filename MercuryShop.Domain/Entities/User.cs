namespace MercuryShop.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string EmailHash { get; set; }
        public required string PasswordHash { get; set; }
        public string? PhoneNumbre { get; set; }
        public string? Address { get; set; }

        private User () {}

        public User (string firstName, string lastName, string email, string emailHash, string passwordHash)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            EmailHash = emailHash;
            PasswordHash = passwordHash;
        }
    }
}