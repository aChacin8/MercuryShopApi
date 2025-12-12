namespace MercuryShop.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }

        private User () {}

        public User (string firstName, string lastName, string email, string passwordHash, string? phoneNumber, string? address)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = passwordHash;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}