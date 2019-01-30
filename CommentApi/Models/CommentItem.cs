﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CommentApi.Models
{
    public class CommentItem
    {
        [BsonId]                                    // Designates as document primary key
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string CommentName { get; set; }

        [BsonElement("IsPublic")]
        public string IsPublic { get; set; }

    }

    //public class CommentItem
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //    public bool IsPublic { get; set; }
    //}
}
