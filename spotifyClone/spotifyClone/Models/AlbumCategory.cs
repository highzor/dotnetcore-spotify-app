using System;
namespace spotifyClone.Models
{
    public class AlbumCategory
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Album[] Albumbs { get; set; }
    }
}

//type AlbumCategory @model {
//  id: ID!
//  title: String!
//  albums:[Album] @connection(keyName: "byAlbumCategory", fields: ["id"])
//}
