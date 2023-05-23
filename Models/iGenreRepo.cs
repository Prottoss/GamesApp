using GamesWebAppDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesWebAppDB.Models
{
    public interface iGenreRepo
    {
        IEnumerable<Genre> AllGenres { get; }
    }
}
