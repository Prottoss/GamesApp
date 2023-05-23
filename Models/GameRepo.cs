using System;
using System.Collections.Generic;
using System.Linq;
using GamesWebAppDB.Models;
using GamesWebAppDB.ViewModels;
using GamesWebAppDB.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GamesWebAppDB.Models
{
    public class GameRepo : iGameRepo
    {
        private readonly ApplicationDbContext _appDbContext;

        public GameRepo(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Game> allGames
        {
            get
            {
                return _appDbContext.Games.Include(g => g.Genre);
            }   
        }

        public Game getGameById(int id)
        {
            return _appDbContext.Games.Include(g=>g.Genre).FirstOrDefault(g => g.Id == id);
        }
    }


}
