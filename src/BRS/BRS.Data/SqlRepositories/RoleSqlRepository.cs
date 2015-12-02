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
    public class RoleSqlRepository : IRepository<Role>
    {
        private Context _context;

        public RoleSqlRepository()
        {
            _context = new Context();
        }

        public void Create(Role entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedDate = DateTime.Now;
            _context.Roles.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Role role = Read(id);
            role.Deleted = true;
            Update(role);
        }

        public Role Read(int id)
        {
            return _context.Roles.Where(x => x.Deleted == false && x.ID == id).First();
        }

        public void Read(int id, IResponse<Role> reponse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> ReadAll()
        {
            return _context.Roles.Where(x => x.Deleted == false);
        }

        public void ReadAll(IListResponse<Role> callback)
        {
            throw new NotImplementedException();
        }

        public void Update(Role entity)
        {
            Role role = Read(entity.ID);
            role.Name = entity.Name;
            entity.ModifiedDate = DateTime.Now;

            _context.Entry(role).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }

}
