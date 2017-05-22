namespace LearningServer.DAL.Dtos
{
    public class UserDto
    {
        /// <summary>
        /// User id from database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// User login to service
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// User name that is shown to other users or in session
        /// </summary>
        public string FullUserName { get; set; }
        /// <summary>
        /// All points that user collected
        /// </summary>
        public int? RankingPoints { get; set; }
    }
}
