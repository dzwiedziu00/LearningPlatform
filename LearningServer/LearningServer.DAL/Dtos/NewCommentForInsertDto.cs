using System;

namespace LearningServer.DAL.Dtos
{
    /// <summary>
    /// Complete Dto for comment insert with all required fields
    /// </summary>
    public class NewCommentForInsertDto : INewCommentDto
    {
        public int UserId { get; set; }
        public int ExerciseLevel { get; set; }
        public int ExerciseNumber { get; set; }
        public string CommentText { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
