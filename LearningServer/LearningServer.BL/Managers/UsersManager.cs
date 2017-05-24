using LearningServer.DAL.Dtos;
using LearningServer.DAL.Repository;
using System;
using System.Collections.Generic;

namespace LearningServer.BL.Managers
{
    /// <summary>
    /// Bussiness logic for users
    /// </summary>
    public class UsersManager
    {
        /// <summary>
        /// Instance of repository
        /// </summary>
        private readonly UsersRepository _usersRepository = new UsersRepository();

        public void AddNewUser(INewUserDto dto)
        {
            var getSimilarUser = _usersRepository.GetUserByUsername(dto.UserName);

            if (getSimilarUser != null) throw new ArgumentException("Użytkownik o takiej nazwie już istnieje w bazie");

            _usersRepository.InsertNewUser(dto);
        }

        public IEnumerable<UserDto> AllUsers()
        {
            return _usersRepository.GetAllUsers();
        }

        public UserDto GetUserSession(string username, string password)
        {
            var result = _usersRepository.GetUserForSession(username, password);
            if (result == null) throw new ArgumentException("Niepoprawna nazwa użytkownika bądź hasło");

            return result;
        }

        public void AddPoint(int userId)
        {
            _usersRepository.AddRankingPoint(userId);
        }

        public IEnumerable<UserRankingDto> UsersRanking()
        {
            return _usersRepository.GetUsersRanking();
        }
    }
}
