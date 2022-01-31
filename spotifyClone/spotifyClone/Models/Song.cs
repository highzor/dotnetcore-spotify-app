using System;
namespace spotifyClone.Models
{
    public class Song
    {
        public Guid Id { get; set; }
        public string ImageUri { get; set; }
        public string Uri { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }

        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
    }
}

//type Song @model @key(name: "byAlbum", fields:["albumId"]) {
//id: ID!
//  imageUri: String!
//  uri: String!
//  title: String!
//  artist: String!

//  albumId: ID!
//  album: Album @connection(fields: ["albumId"])
//}
