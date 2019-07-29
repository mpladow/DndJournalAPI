using DndJournalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndJournalAPI.Data
{
    public class AuthService
    {
        private readonly DataContext _context;

        public AuthService(DataContext context)
        {
            this._context = context;
        }

        public bool UserExists(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

    }
}
