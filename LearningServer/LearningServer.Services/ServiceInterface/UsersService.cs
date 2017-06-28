using LearningServer.BL.Managers;
using LearningServer.DAL.Dtos;
using LearningServer.ServiceModel;
using ServiceStack;
using System.Collections.Generic;

namespace LearningServer.ServiceInterface
{
    public class UsersService : IService
    {
        private readonly UsersManager _usersManager = new UsersManager();

        #region Get

        public IEnumerable<UserDto> Get(GetAllUsersRequestDto dto)
        {
            return _usersManager.AllUsers();
        }

        public UserDto Get(GetUserSessionRequestDto dto)
        {
            return _usersManager.GetUserSession(dto.Username, dto.Password);
        }

        public IEnumerable<UserRankingDto> Get(GetUsersRankingRequestDto dto)
        {
            return _usersManager.UsersRanking();
        }

        #endregion

        #region Post

        public void Post(PostNewUserRequestDto dto)
        {
            _usersManager.AddNewUser(dto);
        }

        public void Post(PostAddUserPointRequestDto dto)
        {
            _usersManager.AddPoint(dto.Id, dto.Points);
        }

        #endregion

    }
}
