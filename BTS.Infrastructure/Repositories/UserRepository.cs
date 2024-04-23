using BTS.Domain.Core.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<User> AddItemAsync(User item)
        {
            var result = await _context.User.AddAsync(item);
            return result.Entity;
        }

        public Task<bool> DeleteItemByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetItemByIdAsync(int Id)
        {
            return await _context.User.FirstOrDefaultAsync(u => u.Id == Id) ?? new User();
        }

        public Task<IEnumerable<User>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateItemAsync(User itemChanges)
        {
            throw new NotImplementedException();
        }
    }
}
