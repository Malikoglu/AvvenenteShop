﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace AvvenenteShop.Catalog.Entities
{
    public class ProductDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductDetailID { get; set; }
        public string ProductDescription { get; set; }
        public string ProducrInfo { get; set; }
        public string ProductId { get; set; }
        [BsonIgnore]
        public Product Product { get; set; }


    }
}
