namespace MercuryShop.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; } = null!;
        public string LastName { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string PasswordHash { get; private set; } = null!;
        public string? PhoneNumber { get; private set; }
        public string? Address { get; private set; }

        private User() { }

        public User(string firstName, string lastName, string email, string passwordHash, string? phoneNumber, string? address)
        {
            Id = Guid.NewGuid();
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}