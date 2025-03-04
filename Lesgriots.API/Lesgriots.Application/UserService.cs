using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesgriots.Application.Interfaces;
using Lesgriots.Domain.Models;

namespace Lesgriots.Application
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync() => await _userRepository.GetAllAsync();
        public async Task<User?> GetUserByIdAsync(int id) => await _userRepository.GetByIdAsync(id);
        public async Task AddUserAsync(User user) => await _userRepository.AddAsync(user);
        public async Task UpdateUserAsync(User user) => await _userRepository.UpdateAsync(user);
        public async Task DeleteUserAsync(int id) => await _userRepository.DeleteAsync(id);
    }
}
