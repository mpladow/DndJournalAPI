using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DndJournalAPI.Data;
using DndJournalAPI.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DndJournalAPI.Controllers
{
    // Handles the authorisation of users - logging in and out, registration, etc
    public class AuthController : Controller
    {
        private readonly DataContext _db;
        public AuthController(DataContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Register(UserForRegisterDto user) {
            return Ok(0);
        }
        public Task<IActionResult> Login(UserForLoginDto user)
        {
            user.Email = user.Email.ToLower();

            var userExists = _db.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
            if (userExists == null)
            {
                return null;
            }

            return Ok();
            
        }
        public bool VerifyPasswordHash (string password, string[] passwordHash, string[] passwordSalt)
        {
            return false;
        }
    }
}