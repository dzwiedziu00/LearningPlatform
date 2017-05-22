using LearningServer.DAL.Dtos;
using ServiceStack;
using System.Collections.Generic;

namespace LearningServer.ServiceModel
{

    #region GET

    [Route("/users/getall", "GET")]
    public class GetAllUsersRequestDto : IReturn<IEnumerable<UserDto>>
    {
    }

    [Route("/users/{Username}/{Password}", "GET")]
    public class GetUserSessionRequestDto : IReturn<UserDto>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    [Route("/users/ranking/getall", "GET")]
    public class GetUsersRankingRequestDto : IReturn<IEnumerable<UserRankingDto>>
    {
    }

    #endregion

    #region POST

    [Route("/users/addnew", "POST")]
    public class PostNewUserRequestDto : IReturn, INewUserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullUserName { get; set; }
    }

    [Route("/users/ranking/addpoint", "POST")]
    public class PostAddUserPointRequestDto : IReturn
    {
        public int Id { get; set; }
    }

    #endregion

}
