using net6.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net6.DapperAccessor.Repositories
{
    /// <summary>
    /// Repository для User
    /// </summary>
    public class UserRepository : DapperGeneric
    {
        public UserRepository(UnitOfWork uw) : base(uw)
        {

        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            return await QueryAsync<User>("SELECT id, name, age FROM public.\"Users\"");
        }

        /// <summary>
        /// Get One Users By ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<User> GetUserById(int Id)
        {
            return await FirstOrDefaultAsync<User>("select * from users where age = @age", new { age = Id });
        }

    }

}
