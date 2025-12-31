using SimpleDiContainer.Data;
using System;
using System.Collections.Generic;


namespace SimpleDiContainer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public List<User> GetAllUsers() => _repository.GetAll();

        public User GetUserById(int id) => _repository.GetById(id);

        public void AddUser(string firstName, string lastName, string email)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("First and last name are required");

            _repository.Add(new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email
            });
        }

        public void UpdateUser(int id, string firstName, string lastName, string email)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("First and last name are required");

            _repository.Update(new User
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email
            });
        }

        public void DeleteUser(int id) => _repository.Delete(id);
    }
}
