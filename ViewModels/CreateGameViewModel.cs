using GamesWebAppDB.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesWebAppDB.ViewModels
{
    public class CreateGameViewModel
    {
        public string name { get; set; }
        public string developer { get; set; }
        public bool multiplayer { get; set; }
        public int release { get; set; }
        public decimal price { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public IFormFile Img { get; set; }

    }
}
