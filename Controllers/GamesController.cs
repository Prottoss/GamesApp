using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GamesWebAppDB.Models;
using GamesWebAppDB.ViewModels;
using GamesWebAppDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace GamesWebAppDB.Controllers
{
    [Authorize]
    public class GamesController : Controller
    {
        private readonly iGameRepo _game;
        private readonly iGenreRepo _genre;
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public GamesController(iGameRepo game, iGenreRepo genre, ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _genre = genre;
            _game = game;
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        [AllowAnonymous]
        public IActionResult AllGames()
        {
            var games = _game.allGames;
            return View(games.ToList());
        }

        public IActionResult Details(int id)
        {
            var game = _game.getGameById(id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        public IActionResult Add()
        {
            ViewData["GenreId"] = new SelectList(_genre.AllGenres, "Id", "name");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(CreateGameViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);

                Game game = new Game
                {
                    name = model.name,
                    developer = model.developer,
                    release = model.release,
                    multiplayer = model.multiplayer,
                    GenreId = model.GenreId,
                    price = model.price,
                    imgurl = uniqueFileName
                };

                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AllGames));
            }

            ViewData["GenreId"] = new SelectList(_context.Genres, model.Genre.name);
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            EditGameViewModel model = new EditGameViewModel();

            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.Include(g=>g.Genre).FirstOrDefaultAsync(g => g.Id == id);

            if (game == null)
            {
                return NotFound();
            }
            else
            {
                model.Id = game.Id;
                model.name = game.name;
                model.developer = game.developer;
                model.release = game.release;
                model.multiplayer = game.multiplayer;
                model.price = game.price;
                model.GenreId = game.GenreId;
                model.existingImg = game.imgurl;

            }

            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "name");
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditGameViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Retrieve the game being edited from the database
                    Game game = await _context.Games.Include(g => g.Genre).FirstOrDefaultAsync(g => g.Id == model.Id);

                    // Update the game object with the data in the model object
                    game.name = model.name;
                    game.developer = model.developer;
                    game.release = model.release;
                    game.multiplayer = model.multiplayer;
                    game.price = model.price;
                    game.GenreId = model.GenreId;

                    string uniqueFileName = ProcessUploadedFile(model);

                    // If the user wants to change the image, a new image will be
                    // uploaded and the imgurl property on the model object receives
                    // the uploaded image. If the image property is null, user did
                    // not upload a new image and keeps his existing image
                    if (model.Img!= null)
                    {
                        // If a new image is uploaded, the existing image must be
                        // deleted. So check if there is an existing image and delete
                        if (model.existingImg != null)
                        {
                            string filePath = Path.Combine(hostingEnvironment.WebRootPath,"images", model.existingImg);
                            System.IO.File.Delete(filePath);
                        }
                        // Save the new image in wwwroot/images folder and update
                        // imgurl property of the game object which will be
                        // eventually saved in the database
                        game.imgurl = ProcessUploadedFile(model);
                    }

                    // Call update method on the repository service passing it the
                    // game object to update the data in the database table
                    var updatedGame = _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(AllGames));
            }
            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "Id");
            return View(model);
        }
        private string ProcessUploadedFile(CreateGameViewModel model)
        {
            string uniqueFileName = null;

            // If the image property on the incoming model object is not null, then the user has selected an image to upload
            if (model.Img != null)
            {
                // The image must be uploaded to the images folder in wwwroot To get the path of the wwwroot folder we are using the inject
                // HostingEnvironment service provided by ASP.NET Core
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");

                // To make sure the file name is unique we are appending a new
                // GUID value and and an underscore to the file name
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Img.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                // Use CopyTo() method provided by IFormFile interface to
                // copy the file to wwwroot/images folder
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Img.CopyTo(fileStream);
                }
                    
                
            }

            return uniqueFileName;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.Include(g=>g.Genre).FirstOrDefaultAsync(g => g.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Games.FindAsync(id);
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AllGames));
        }

        private bool GameExists(int id)
        {
            return _context.Games.Any(e => e.Id == id);
        }


    }
}
