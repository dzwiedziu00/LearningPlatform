using LearningServer.DAL.Database;
using LearningServer.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningServer.DAL.Repository
{
    /// <summary>
    /// Repository connected only to users table from database
    /// </summary>
    public class UsersRepository : RepositoryBase
    {
        public void InsertNewUser(INewUserDto dto)
        {
            Context.Users.InsertOnSubmit(new User
            {
                Username = dto.UserName,
                Password = dto.Password,
                FullUserName = dto.FullUserName,
                CreationDate = DateTime.Now
            });
            Context.SubmitChanges();
        }

        public User GetUserByUsername(string username)
        {
            return Context.Users.FirstOrDefault(x => x.Username == username);
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            return Context.Users
                .Select(x => new UserDto
                {
                    Id = x.Id,
                    UserName = x.Username,
                    FullUserName = x.FullUserName
                });
        }

        public UserDto GetUserForSession(string username, string password)
        {
            return Context.Users
                .Where(x => x.Username == username && x.Password == password)
                .Select(x => new UserDto
                {
                    Id = x.Id,
                    UserName = x.Username,
                    FullUserName = x.FullUserName,
                    RankingPoints = x.RankingPoints
                }).FirstOrDefault();
        }

        public void AddRankingPoint(int userId, int points)
        {
            var user = Context.Users.FirstOrDefault(x => x.Id == userId);

            if (user == null) throw new ArgumentException("User does not exist");

            user.RankingPoints += points;

            Context.SubmitChanges();
        }

        public IEnumerable<UserRankingDto> GetUsersRanking()
        {
            return Context.Users.Select(x => new UserRankingDto
            {
                Id = x.Id,
                FullUserName = x.FullUserName,
                Score = x.RankingPoints
            }).OrderByDescending(x => x.Score);
        }
    }
}
