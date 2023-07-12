using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWebApplicationPol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private IContext _ctx;
        private IRepository<GenrePOCO> _genreRepo;

        public GenreController(IContext context, IRepository<GenrePOCO> genreRepo)
        {
            _ctx = context;
            _genreRepo = genreRepo;
        }
    }
}
