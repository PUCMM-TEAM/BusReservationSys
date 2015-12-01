﻿using BRS.Core.Models;
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
    public class DestinationSqlRepository : IRepository<Destination>
    {
        private Context _context;

        public DestinationSqlRepository()
        {
            _context = new Context();
        }

        public void Create(Destination entity)
        {
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

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
