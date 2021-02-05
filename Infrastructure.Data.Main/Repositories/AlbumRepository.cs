using Domain.Main.Entities;
using Domain.Main.IRepositories;
using Infrastructure.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Main.Repositories
{
    public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
    {
        public IEnumerable<Album> GetAlbumByArtist(int idArtist)
        {
            
            
            throw new NotImplementedException();
        }
    }
}
