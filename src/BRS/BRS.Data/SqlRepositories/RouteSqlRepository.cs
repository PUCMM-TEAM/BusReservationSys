using BRS.Core.Models;
using BRS.Core.Repositories;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public Route Read(int id)
        {
            return _context.Routes.Find(id);
        }

        public void Read(int id, Core.IResponse<Route> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Route> ReadAll()
        {
            return _context.Routes;
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

           // _context.Routes.Up
           // _context.SaveChanges();
        }
    }


}
