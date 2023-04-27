using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IUserService
    {
        public Task<List<User>> GetAll();
        public Task<User> Create(User user);
    }
}
