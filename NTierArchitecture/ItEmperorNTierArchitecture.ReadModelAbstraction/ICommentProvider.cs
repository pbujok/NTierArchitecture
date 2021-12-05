using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItEmperorNTierArchitecture.ReadModelAbstraction
{
    public interface ICommentProvider
    {
        public Task<ICollection<CommentDto>> GetCommentsAsync();
    }
}