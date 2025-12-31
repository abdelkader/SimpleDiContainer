using System.Collections.Generic;
using System.Linq;


namespace SimpleDiContainer.Data
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _users = new List<User>
    {
        new User { Id = 1, FirstName = "Jean", LastName = "Dupont", Email = "jean@example.com" },
        new User { Id = 2, FirstName = "Marie", LastName = "Martin", Email = "marie@example.com" },
        new User { Id = 3, FirstName = "Pierre", LastName = "Bernard", Email = "pierre@example.com" }
    };

        public List<User> GetAll() => new List<User>(_users);

        public User GetById(int id) => _users.FirstOrDefault(u => u.Id == id);

        public void Add(User user)
        {
            user.Id = _users.Any() ? _users.Max(u => u.Id) + 1 : 1;
            _users.Add(user);
        }

        public void Update(User user)
        {
            var existing = GetById(user.Id);
            if (existing != null)
            {
                existing.FirstName = user.FirstName;
                existing.LastName = user.LastName;
                existing.Email = user.Email;
            }
        }

        public void Delete(int id)
        {
            var user = GetById(id);
            if (user != null)
                _users.Remove(user);
        }
    }
}
