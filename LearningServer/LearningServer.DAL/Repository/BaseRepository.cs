using LearningServer.DAL.Database;

namespace LearningServer.DAL.Repository
{
    public class BaseRepository
    {
        protected readonly DatabaseModelDataContext Context = new DatabaseModelDataContext();
    }
}
