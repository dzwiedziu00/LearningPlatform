using LearningServer.DAL.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace LearningServer.DAL.Repository
{
    public class CommentsRepository : BaseRepository
    {
        public IEnumerable<UserCommentDto> GetAll()
        {
            return Context.Comments.Select(x => new UserCommentDto
            {
                Id = x.Id,
                UserId = x.UserId,
                Comment = x.UserComment
            });
        }
    }
}
