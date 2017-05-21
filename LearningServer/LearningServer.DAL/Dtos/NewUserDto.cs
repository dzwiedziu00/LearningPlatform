namespace LearningServer.DAL.Dtos
{
    /// <summary>
    /// Interface for adding new user to database
    /// </summary>
    public interface INewUserDto
    {
        string UserName { get; set; }
        string Password { get; set; }
        string FullUserName { get; set; }
    }
}
