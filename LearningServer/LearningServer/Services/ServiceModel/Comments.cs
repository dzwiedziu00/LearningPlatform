using LearningServer.DAL.Dtos;
using ServiceStack;
using System.Collections.Generic;

namespace LearningServer.Services.ServiceModel
{
    /// <summary>
    /// Namespace with all comments RequestDto
    /// </summary>

    #region GET


    [Route("/comments/getall", "GET")]
    public class GetAllCommentsRequestDto : IReturn<IEnumerable<UserCommentDto>>
    {
    }

    #endregion

}