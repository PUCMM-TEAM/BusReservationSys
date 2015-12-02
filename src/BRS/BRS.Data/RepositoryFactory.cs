using BRS.Core.Models;
using BRS.Core.Repositories;
using BRS.Data.SqlRepositories;

namespace BRS.Data
{
    public class RepositoryFactory
    {
        private static RepositoryFactory _instance;
        private Context _context;
        private IRepository<Destination> _destinationRepository;
        private IRepository<Route> _routeRepository;
        private IRepository<Trip> _tripRepository;
        private IRepository<Customer> _customerRepository;
        private IRepository<CreditCard> _creditcardRepository;
        private IRepository<User> _userRepository;
        private IRepository<Vehicle> _vehicleRepository;
        private IRepository<Reservation> _reservationRepository;
        private RepositoryFactory()
        {
            _context = new Context();
            _destinationRepository = new DestinationSqlRepository(_context);
            _routeRepository = new RouteSqlRepository(_context);
            _tripRepository = new TripSqlRepository(_context);
            _customerRepository = new CustomerSqlRepository(_context);
            _creditcardRepository = new CreditCardSqlRepository(_context);
            _userRepository = new UserSqlRepository(_context);
            _vehicleRepository = new VehicleSqlRepository(_context);
            _reservationRepository = new ReservationSqlRepository(_context);


        }

        public static RepositoryFactory Instance()
        {
            if (_instance == null)
                _instance = new RepositoryFactory();

            return _instance;
        }

        public IRepository<Destination> DestinationRepository()
        {
            return _destinationRepository;
        }

        public IRepository<Route> RouteRepository()
        {
            return _routeRepository;
        }

        public IRepository<Trip> TripRepository()
        {
            return _tripRepository;
        }

        public IRepository<Customer> CustomerRepository()
        {
            return _customerRepository;
        }

        public IRepository<CreditCard> CreditCardRepository()
        {
            return _creditcardRepository;
        }
        public IRepository<User> UserRepository()
        {
            return _userRepository;
        }
        public IRepository<Vehicle> VehicleRepository()
        {
            return _vehicleRepository;
        }

        public IRepository<Reservation> ReservationRepository()
        {
            return _reservationRepository;
        }



    }
}
