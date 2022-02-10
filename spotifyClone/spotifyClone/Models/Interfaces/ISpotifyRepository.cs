using System;
using System.Collections.Generic;
using spotifyClone.Models.DbEntities;

namespace spotifyClone.Models.Interfaces
{
    public interface ISpotifyRepository
    {

        IEnumerable<AlbumCategory> Get();
        AlbumCategory Get(Guid id);
        void Create(AlbumCategory item);
        void Update(AlbumCategory item);
        AlbumCategory Delete(Guid id);
    }
}
