using LearningServer.DAL.Database;

namespace LearningServer.DAL.Repository
{
    /// <summary>
    /// Base repository class with Context for connection to database
    /// </summary>
    public class RepositoryBase
    {
        protected readonly DatabaseModelDataContext Context = new DatabaseModelDataContext();
    }
}
