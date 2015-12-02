using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BRS.Core;
using BRS.Core.CallBacks;
using BRS.Core.Models;
using BRS.Core.Repositories;

namespace BRS.Data.SqlRepositories
{
    public class TripSqlRepository : IRepository<Trip>
    {
        private Context _context;

        public TripSqlRepository(Context context)
        {
            _context = context;
        }

        public void Create(Trip entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Trips.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Trip trip = Read(id);
            trip.Deleted = true;
            Update(trip);
        }

        public Trip Read(int id)
        {
            return _context.Trips.Where(x => x.Deleted == false && x.ID == id).First();
        }

        public void Read(int id, IResponse<Trip> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trip> ReadAll()
        {
            return _context.Trips.Where(x => x.Deleted == false);
        }

        public void ReadAll(IListResponse<Trip> callback)
        {
            throw new NotImplementedException();
        }

        public void Update(Trip entity)
        {
            Trip trip = Read(entity.ID);
            trip.Route = entity.Route;
            trip.DateAvailable = entity.DateAvailable;
            trip.DepartureTime = entity.DepartureTime;
            trip.ArrivalTime = entity.ArrivalTime;
            trip.Vehicle = entity.Vehicle;
            trip.Price = entity.Price;
            entity.ModifiedDate = DateTime.Now;

            _context.Entry(trip).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
