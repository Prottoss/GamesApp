using GamesWebAppDB.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesWebAppDB.ViewModels
{
    public class EditGameViewModel:CreateGameViewModel
    {
        public int Id { get; set; }
        public string existingImg { get; set; }

    }
}
