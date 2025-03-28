﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lesgriots.Application.Interfaces;
using Lesgriots.Domain.Models;
using Lesgriots.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Lesgriots.Application.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MaDbContext _context;

        public UserRepository(MaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }

            int rowsAffected = await _context.Database.ExecuteSqlRawAsync(
            "UPDATE Components SET Title = {0}, Version = Version + 1 WHERE InternalId = {1} AND Version = {2}",
            "TATA", "6255IDbneeHGT32", 3);

            if (rowsAffected == 0)
            {
                throw new Exception("Un autre développeur a modifié cet objet. Veuillez rafraîchir vos données.");
            }




        }
    }
}
