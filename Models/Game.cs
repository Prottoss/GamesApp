using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesWebAppDB.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string developer { get; set; }
        public bool multiplayer { get; set; }
        public int release { get; set; }
        public decimal price { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public string imgurl { get; set; }

    }
}
