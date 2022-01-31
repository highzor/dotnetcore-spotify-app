using System;
namespace spotifyClone.Models
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string By { get; set; }
        public int NumberOfLikes { get; set; }
        public string ImageUri { get; set; }
        public string ArtistsHeadline { get; set; }
        public Song[] Song { get; set; }

        public Guid AlbumCategoryId { get; set; }
        public AlbumCategory albumCategory { get; set; }
    }
}

//type Album @model @key(name: "byAlbumCategory", fields:["albumCategoryId"]) {
//id: ID!
//  name: String!
//  by: String!
//  numberOfLikes: Int!
//  imageUri: String!
//  artistsHeadline: String!

//  songs:[Song] @connection(keyName: "byAlbum", fields: ["id"])

//  albumCategoryId: ID!
//  albumCategory: AlbumCategory @connection(fields: ["albumCategoryId"])
//}
