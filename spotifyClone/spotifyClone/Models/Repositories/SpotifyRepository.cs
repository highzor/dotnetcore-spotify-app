using System;
using System.Collections.Generic;
using spotifyClone.Models.Context;
using spotifyClone.Models.DbEntities;
using spotifyClone.Models.Interfaces;

namespace spotifyClone.Models.Repositories
{
    public class SpotifyRepository : ISpotifyRepository
    {
        private SpotifyContext Context;

        public void Create(AlbumCategory item)
        {
            Context.AlbumCategory.Add(item);
            Context.SaveChanges();
        }

        public AlbumCategory Delete(Guid id)
        {
            AlbumCategory albumCategoryItem = Get(id);

            if (albumCategoryItem != null)
            {
                Context.AlbumCategory.Remove(albumCategoryItem);
                Context.SaveChanges();
            }
            
            return albumCategoryItem;
        }

        public IEnumerable<AlbumCategory> Get()
        {
            return Context.AlbumCategory;
        }

        public AlbumCategory Get(Guid id)
        {
            return Context.AlbumCategory.Find(id);
        }

        public void Update(AlbumCategory updatedAlbumCategoryItem)
        {
            AlbumCategory currentItem = Get(updatedAlbumCategoryItem.Id);

            Context.AlbumCategory.Update(currentItem);
            Context.SaveChanges();
        }
    }
}
