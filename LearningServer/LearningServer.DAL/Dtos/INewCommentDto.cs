namespace LearningServer.DAL.Dtos
{
    /// <summary>
    /// Interface for new comment
    /// </summary>
    public interface INewCommentDto
    {
        /// <summary>
        /// User id connected to user session
        /// </summary>
        int UserId { get; set; }
        /// <summary>
        /// Id of excercise level that user is on
        /// </summary>
        int ExerciseLevel { get; set; }
        /// <summary>
        /// Id of excercise that user is solving
        /// </summary>
        int ExerciseNumber { get; set; }
        /// <summary>
        /// User comment content
        /// </summary>
        string CommentText { get; set; }
    }
}
