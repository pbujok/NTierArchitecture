using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItEmperorNTierArchitecture.ReadModelAbstraction;
using Microsoft.EntityFrameworkCore;

namespace ItEmperorNTierArchitecture.DalLayer.Providers
{
    public class CommentProvider : ICommentProvider
    {
        private BoardDbContext DbContext { get; }

        public CommentProvider(BoardDbContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<ICollection<CommentDto>> GetCommentsAsync()
        {
            return await DbContext.Comments
                .AsNoTracking()
                .Select(x => new CommentDto(x.Id, x.Content, x.CreationDate, x.AuthorName))
                .ToListAsync();
        }
    }
}