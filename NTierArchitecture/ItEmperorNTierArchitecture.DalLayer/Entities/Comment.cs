using System;
using Microsoft.EntityFrameworkCore;

namespace ItEmperorNTierArchitecture.DalLayer.Entities
{
    public class Comment : IEntity
    {
        public Guid Id { get; set; }
        
        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        public string AuthorName { get; set; }
    }
}