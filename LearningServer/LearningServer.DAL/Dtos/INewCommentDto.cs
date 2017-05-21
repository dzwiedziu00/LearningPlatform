namespace LearningServer.DAL.Dtos
{
    /// <summary>
    /// Interface for new comment
    /// </summary>
    public interface INewCommentDto
    {
        int UserId { get; set; }
        int ExerciseLevel { get; set; }
        int ExerciseNumber { get; set; }
        string CommentText { get; set; }
    }
}
