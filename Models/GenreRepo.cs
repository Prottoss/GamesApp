using System.Collections.Generic;
using GamesWebAppDB.Data;

namespace GamesWebAppDB.Models
{
    public class GenreRepo : iGenreRepo
    {
        
            private readonly ApplicationDbContext _appDbContext;

            public GenreRepo(ApplicationDbContext appDbContext)
            {
                _appDbContext = appDbContext;
            }

            public IEnumerable<Genre> AllGenres => _appDbContext.Genres;
    }
}
 