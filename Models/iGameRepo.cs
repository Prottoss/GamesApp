using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesWebAppDB.Models
{
    public interface iGameRepo
    {
        IEnumerable<Game> allGames { get; }
        Game getGameById(int id);
    }
}
