﻿using BRS.Core.Models;
using BRS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Data.SqlRepositories 
{
   

     public class RouteSqlRepository : IRepository<Route>
    {
        private Context _context;

        public RouteSqlRepository()
        {
            _context = new Context();
        }

        public void Create(Route entity)
        {
            _context.Routes.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Route route = Read(id);
            route.Deleted = true;
            Update(route);
        }

        public Route Read(int id)
        {
            return _context.Routes.Where(x => x.Deleted == false && x.ID == id).First();
        }

        public void Read(int id, Core.IResponse<Route> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Route> ReadAll()
        {
            return _context.Routes.Where(x => x.Deleted == false);
        }

        public void ReadAll(Core.CallBacks.IListResponse<Route> callback)
        {
            throw new NotImplementedException();
        }

        public void Update(Route entity)
        {
            Route route = Read(entity.ID);
            route.Pickup = entity.Pickup;
            route.DropOff = entity.DropOff;

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }


}
