using Domain.Core;
using Domain.Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Main.IRepositories
{
    public interface IAlbumRepository: IRepository<Album>
    {
        IEnumerable<Album> GetAlbumByArtist(int idArtist);
    }
}
