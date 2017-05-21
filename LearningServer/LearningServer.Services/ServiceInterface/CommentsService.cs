using LearningServer.BL.Managers;
using LearningServer.DAL.Dtos;
using LearningServer.ServiceModel;
using ServiceStack;
using System.Collections.Generic;

namespace LearningServer.ServiceInterface
{
    /// <summary>
    /// ServiceStack web service implementation for comments.
    /// </summary>
    public class CommentsService : IService
    {
        private readonly CommentsManager _commentsManager = new CommentsManager();

        #region Get

        public IEnumerable<UserCommentDto> Get(GetAllCommentsRequestDto dto)
        {
            return _commentsManager.AllComments();
        }

        public IEnumerable<UserCommentDto> Get(GetCommentsForExerciseRequestDto dto)
        {
            return _commentsManager.CommentsForExercise(dto.ExLevel, dto.ExNumber);
        }

        #endregion

        #region Post

        public void Post(PostNewCommentRequestDto dto)
        {
            _commentsManager.AddNewComment(dto);
        }

        #endregion
    }
}