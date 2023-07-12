using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_GenreAPI.Models
{
    public class GameDTO
    {
        public int Game_ID { get; set; }
        public int AnneeDeSortie { get; set; }
        public int Genre_ID { get; set; }
        public string? Descriptif { get; set; }
    }
}
