using net6.DapperAccessor.Repositories;
using net6.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net6.DapperAccessor.Services
{
    /// <summary>
    /// User Business Logic Services
    /// Здесь можно получить данные от репозиторий и добавить бизнес логику
    /// </summary>
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Get All Users type: Enumerable<>
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<User>> GetUserEnumerableAsync() => await _userRepository.GetAllUserAsync();

        /// <summary>
        /// Get All Users type: List<>
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> GetUserListAsync()
        {
            var data = await _userRepository.GetAllUserAsync();
            return data.ToList();
        }

        /// <summary>
        /// Get First One User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<User> GetUserByIdAsync(int id) => await _userRepository.GetUserById(id);

    }
}
