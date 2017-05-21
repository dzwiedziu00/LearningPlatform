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
    public class GetUserSessionRequestDto : IReturn
    {
        public string Username { get; set; }
        public string Password { get; set; }
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

    #endregion

}
