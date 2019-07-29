using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DndJournalAPI.Data;
using DndJournalAPI.Models;
using DndJournalAPI.Dtos;

namespace DndJournalAPI.Controllers
{
    public class UsersController : Controller
    {
        private readonly DataContext _context;
        private readonly AuthService _authService;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        public async Task<IActionResult> Register(UserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            userDto.Email = userDto.Email.ToLower();
            if (_authService.UserExists(userDto.Email))
            {
                return BadRequest("User already exists");
            }
            var userToCreate = new User()
            {
                Email = userDto.Email
            };
            throw new NotImplementedException();
        }

        private bool EmailExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
