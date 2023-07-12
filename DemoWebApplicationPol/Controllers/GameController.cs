using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWebApplicationPol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private IContext _ctx;
        private IRepository<GamePOCO> _gameRepo;

        public GameController(IContext context, IRepository<GamePOCO> gameRepo)
        {
            _ctx = context;
            _gameRepo = gameRepo;
        }
    }
}
