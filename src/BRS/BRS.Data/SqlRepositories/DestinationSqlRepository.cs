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
    public class DestinationSqlRepository : IRepository<Destination>
    {
        private Context _context;

        public DestinationSqlRepository(Context context)
        {
            _context = context;
        }

        public void Create(Destination entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Destinations.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Destination destination = Read(id);
            destination.Deleted = true;
            Update(destination);
        }

        public Destination Read(int id)
        {
            return _context.Destinations.Where(x => x.Deleted == false && x.ID == id).First();
        }

        public void Read(int id, IResponse<Destination> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Destination> ReadAll()
        {
            return _context.Destinations.Where(x=>x.Deleted==false);
        }

        public void ReadAll(IListResponse<Destination> callback)
        {
            throw new NotImplementedException();
        }

        public void Update(Destination entity)
        {
            Destination destination = Read(entity.ID);
            destination.Name = entity.Name;
            destination.ModifiedDate = DateTime.Now;

            _context.Entry(destination).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
