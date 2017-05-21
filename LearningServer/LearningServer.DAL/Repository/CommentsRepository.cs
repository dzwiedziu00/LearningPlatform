using LearningServer.DAL.Database;
using LearningServer.DAL.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace LearningServer.DAL.Repository
{
    public class CommentsRepository : BaseRepository
    {
        public IEnumerable<UserCommentDto> GetAll()
        {
            return Context.Comments.Select(x => new UserCommentDto
            {
                Id = x.Id,
                UserId = x.UserId,
                Comment = x.UserComment,
                FullUserName = x.User.FullUserName,
                CreationDateOfComment = x.CreationDate
            });
        }

        public IEnumerable<UserCommentDto> GetCommentsForExercise(int exLevel, int exNumber)
        {
            return
                Context.Comments.Where(x => x.ExerciseLevel == exLevel && x.ExerciseNumber == exNumber)
                    .Select(x => new UserCommentDto
                    {
                        Id = x.Id,
                        UserId = x.UserId,
                        Comment = x.UserComment,
                        FullUserName = x.User.FullUserName,
                        CreationDateOfComment = x.CreationDate

                    });
        }

        public void InsertComment(NewCommentForInsertDto dto)
        {
            Context.Comments.InsertOnSubmit(new Comment
            {
                CreationDate = dto.CreationDate,
                ExerciseLevel = dto.ExerciseLevel,
                ExerciseNumber = dto.ExerciseNumber,
                UserId = dto.UserId,
                UserComment = dto.CommentText
            });
            Context.SubmitChanges();
        }
    }
}
