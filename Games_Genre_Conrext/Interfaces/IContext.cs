using DemoWebApplicationPol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Genre_Context.Interfaces
{
    public class IContext
    {
        List<Game> Games { get; set; }
        List<Genre> Genres { get; set; }
    }
}
