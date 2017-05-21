using LearningServer.DAL.Dtos;
using ServiceStack;
using System.Collections.Generic;

namespace LearningServer.ServiceModel
{
    /// <summary>
    /// Namespace with all comments RequestDto
    /// </summary>

    #region GET


    [Route("/comments/getall", "GET")]
    public class GetAllCommentsRequestDto : IReturn<IEnumerable<UserCommentDto>>
    {
    }

    [Route("/comments/{ExLevel}/{ExNumber}", "GET")]
    public class GetCommentsForExerciseRequestDto : IReturn<IEnumerable<UserCommentDto>>
    {
        public int ExLevel { get; set; }
        public int ExNumber { get; set; }
    }

    #endregion

    #region POST

    [Route("/comments/addnew", "POST")]
    public class PostNewCommentRequestDto : IReturn, INewCommentDto
    {
        public int UserId { get; set; }
        public int ExerciseLevel { get; set; }
        public int ExerciseNumber { get; set; }
        public string CommentText { get; set; }
    }

    #endregion

}