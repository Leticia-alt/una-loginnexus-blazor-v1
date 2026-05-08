using LoginBlazor.Models;


namespace LoginBlazor.Services
{
    public class AuthService
    {
        private readonly List<User> _users = new()
    {
        new User { Email = "danielr@nexus.edu", Password = "123", Role = "Professor", Name = "Dr. Paiva" },
        new User { Email = "leticia@nexus.edu", Password = "123", Role = "Student", Name = "Letícia P." }
    };

        public User? Authenticate(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}