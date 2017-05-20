using LearningServer.DAL.Dtos;
using System.Collections.Generic;

namespace LearningServer.BL.Managers
{
    /// <summary>
    /// Bussines logic class for Comments
    /// </summary>
    public class CommentsManager
    {
        public IEnumerable<UserCommentDto> AllComments()
        {
            return new List<UserCommentDto>
            {
                new UserCommentDto
                {
                    Id = 1,
                    UserId = 1,
                    Comment = "Wolo"
                },
                new UserCommentDto
                {
                    Id = 2,
                    UserId = 2,
                    Comment = "Yolo"
                }
            };
        }
    }
}
