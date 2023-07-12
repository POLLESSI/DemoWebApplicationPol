using Games_GenreAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_GenreAPI.Repositories
{
    public class GenreRepository : IRepository<GenrePOCO, int>
    {
        public int Add(GenrePOCO obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public GenrePOCO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenrePOCO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(GenrePOCO obj)
        {
            throw new NotImplementedException();
        }
    }
}
