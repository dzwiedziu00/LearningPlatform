using LearningServer.BL.Managers;
using LearningServer.DAL.Dtos;
using LearningServer.Services.ServiceModel;
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

        #endregion
    }
}