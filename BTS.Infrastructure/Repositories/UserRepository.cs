using BTS.Application.Interfaces;
using BTS.Domain.User;
using BTS.Infrastructure.Data;
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
            var result = await _context.Users.AddAsync(item);
            return result.Entity;
        }

        public async Task<bool> DeleteItemByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetItemByIdAsync(int Id)
        {
            return await _context.Users.FirstOrDefaultAsync(i => i.Id == Id) ?? new User();
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
