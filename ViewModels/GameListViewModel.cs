﻿using GamesWebAppDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesWebAppDB.ViewModels
{
    public class GameListViewModel
    {
        public IEnumerable<Game> Games { get; set; }

        public string CurrentCategory { get; set; }
    }
}
