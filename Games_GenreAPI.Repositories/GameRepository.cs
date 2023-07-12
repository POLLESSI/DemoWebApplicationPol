using Microsoft.Data.SqlClient;
using Games_GenreAPI.Entities;
using Games_GenreAPI.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Games_GenreAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_GenreAPI.Repositories
{
    public class GameRepository : IRepository<GamePOCO, int>
    {
        public int Add(GamePOCO obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public GamePOCO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GamePOCO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(GamePOCO obj)
        {
            throw new NotImplementedException();
        }
    }
}
