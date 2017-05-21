using LearningServer.DAL.Dtos;
using LearningServer.DAL.Repository;
using System.Collections.Generic;

namespace LearningServer.BL.Managers
{
    /// <summary>
    /// Bussines logic class for Comments
    /// </summary>
    public class CommentsManager
    {
        private readonly CommentsRepository _commentsRepository = new CommentsRepository();

        public IEnumerable<UserCommentDto> AllComments()
        {
            return _commentsRepository.GetAll();
        }
    }
}
