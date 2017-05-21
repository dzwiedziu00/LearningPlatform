using LearningServer.DAL.Database;

namespace LearningServer.DAL.Repository
{
    public class BaseRepository
    {
        protected DatabaseModelDataContext Context = new DatabaseModelDataContext();
    }
}
