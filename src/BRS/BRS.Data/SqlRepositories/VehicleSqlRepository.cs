using BRS.Core.Models;
using BRS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRS.Core;
using BRS.Core.CallBacks;
using System.Data.Entity;

namespace BRS.Data.SqlRepositories
{
     public class VehicleSqlRepository : IRepository<Vehicle>
    {
        private Context _context;


        public VehicleSqlRepository()
        {
            _context = new Context();
        }

        public void Create(Vehicle entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Vehicles.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Vehicle Read(int id)
        {
            return _context.Vehicles.Find(id);
        }

        public void Read(int id, IResponse<Vehicle> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> ReadAll()
        {
            return _context.Vehicles;
        }

        public void ReadAll(IListResponse<Vehicle> callback)
        {
            throw new NotImplementedException();
        }

        public void Update(Vehicle entity)
        {
            Vehicle vehicle = Read(entity.ID);
            vehicle.Name = entity.Name;
            vehicle.Image = entity.Image;
            vehicle.PassengerCapacity = entity.PassengerCapacity;
            vehicle.VehicleType = entity.VehicleType;
            vehicle.Description = entity.Description;
            entity.ModifiedDate = DateTime.Now;

            _context.Entry(vehicle).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
