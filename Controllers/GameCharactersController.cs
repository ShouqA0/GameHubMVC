using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameHubMVC.Data;
using GameHubMVC.Models;

namespace GameHubMVC.Controllers
{
    public class GameCharactersController : Controller
    {
        private readonly AppDbContext _context;

        public GameCharactersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: GameCharacters
        public async Task<IActionResult> Index()
        {
            return View(await _context.GameCharacters.ToListAsync());
        }

        // GET: GameCharacters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GameCharacters/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GameCharacter gameCharacter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameCharacter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameCharacter);
        }

        // GET: GameCharacters/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var character = await _context.GameCharacters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            return View(character);
        }

        // POST: GameCharacters/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, GameCharacter gameCharacter)
        {
            if (id != gameCharacter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(gameCharacter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameCharacter);
        }
    }
}
