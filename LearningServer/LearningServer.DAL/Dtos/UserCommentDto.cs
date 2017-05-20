namespace LearningServer.DAL.Dtos
{
    /// <summary>
    /// Data transfer objcet for single user comment
    /// </summary>
    public class UserCommentDto
    {
        /// <summary>
        /// Comment Id from database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id connected to user that added the comment
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Content of comment
        /// </summary>
        public string Comment { get; set; }
    }
}
