namespace LearningServer.DAL.Dtos
{
    /// <summary>
    /// Interface shared between RequestDto and more complete Dto for insert operation
    /// </summary>
    public interface INewCommentDto
    {
        int UserId { get; set; }
        int ExerciseLevel { get; set; }
        int ExerciseNumber { get; set; }
        string CommentText { get; set; }
    }
}
