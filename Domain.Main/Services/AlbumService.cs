using Domain.Main.Entities;
using Domain.Main.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Main.Services
{
    public class AlbumService
    {
        IAlbumRepository _repository;
        public AlbumService(IAlbumRepository pRepository)
        {
            this._repository = pRepository;
        }
        IEnumerable<Album> GetAlbumByArtist(int idArtist)
        {
            return _repository.GetAlbumByArtist(idArtist);
        }
    }
}
