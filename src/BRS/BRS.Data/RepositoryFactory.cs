using BRS.Core.Models;
using BRS.Core.Repositories;
using BRS.Data.SqlRepositories;

namespace BRS.Data
{
    public class RepositoryFactory
    {
        private static RepositoryFactory _instance;
        private IRepository<Destination> _destinationRepositry;

        private RepositoryFactory()
        {
            _destinationRepositry = new DestinationSqlRepository();
        }

        public static RepositoryFactory Instance()
        {
            if (_instance == null)
                _instance = new RepositoryFactory();

            return _instance;
        }

        public IRepository<Destination> DestinationRepository()
        {
            return _destinationRepositry;
        }
    }
}
