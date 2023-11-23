﻿using MongoDB.Bson.Serialization.Attributes;

namespace berry.core.DomainObjects.customer
{
    public  class Customer
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
