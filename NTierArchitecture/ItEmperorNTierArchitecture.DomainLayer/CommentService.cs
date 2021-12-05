using System;
using System.Threading.Tasks;
using ItEmperorNTierArchitecture.DalLayer.Entities;
using ItEmperorNTierArchitecture.DalLayer.Repository;

namespace ItEmperorNTierArchitecture.DomainLayer
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _commentRepository;
        private readonly IDateTimeProvider _dateTimeProvider;

        public CommentService(IRepository<Comment> commentRepository, IDateTimeProvider _dateTimeProvider)
        {
            _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
            this._dateTimeProvider = _dateTimeProvider ?? throw new ArgumentNullException(nameof(_dateTimeProvider));
        }

        public async Task AddComment(string content, string authorName)
        {
            _commentRepository.AddAsync(new Comment()
            {
                Content = content,
                AuthorName = authorName,
                CreationDate = _dateTimeProvider.GetCurrent(),
                Id = Guid.NewGuid()
            });
        }
    }
}