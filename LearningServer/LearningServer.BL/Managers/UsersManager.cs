using LearningServer.DAL.Dtos;
using LearningServer.DAL.Repository;
using System;
using System.Collections.Generic;

namespace LearningServer.BL.Managers
{
    public class UsersManager
    {
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
            return _usersRepository.GetUserForSession(username, password);
        }
    }
}
