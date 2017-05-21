using LearningServer.DAL.Dtos;
using LearningServer.DAL.Repository;
using System;
using System.Collections.Generic;

namespace LearningServer.BL.Managers
{
    /// <summary>
    /// Bussines logic class for Comments
    /// </summary>
    public class CommentsManager
    {
        private readonly CommentsRepository _commentsRepository = new CommentsRepository();

        public IEnumerable<UserCommentDto> AllComments()
        {
            return _commentsRepository.GetAll();
        }

        public IEnumerable<UserCommentDto> CommentsForExercise(int exLevel, int exNumber)
        {
            return _commentsRepository.GetCommentsForExercise(exLevel, exNumber);
        }

        public void AddNewComment(NewCommentForInsertDto dto)
        {
            dto.CreationDate = DateTime.Now;
            _commentsRepository.InsertComment(dto);
        }
    }
}
