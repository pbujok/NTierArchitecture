using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ItEmperorNTierArchitecture.ReadModelAbstraction;
using Microsoft.AspNetCore.Mvc;

namespace ItEmperor.NTierArchitecture.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentProvider _commentProvider;
        private readonly ICommentService _commentService;

        public CommentController(ICommentProvider commentProvider, ICommentService commentService)
        {
            _commentProvider = commentProvider ?? throw new ArgumentNullException(nameof(commentProvider));
            _commentService = commentService ?? throw new ArgumentNullException(nameof(commentService));
        }

        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<CommentDto>> GetAll()
        {
            return await _commentProvider.GetCommentsAsync();
        }

        [Route("")]
        [HttpPost]
        public async Task Add([FromBody] NewCommentModel model)
        {
            await _commentService.AddComment(model.Comment, model.AuthorName);
        } 
    }
}